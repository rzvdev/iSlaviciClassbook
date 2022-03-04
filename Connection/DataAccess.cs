using iSlavici.Connection.Models.db;
using iSlavici.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;

namespace classbook.Connection
{
    public class DataAccess
    {
        private static readonly string _ISLAVICI_DB_IP_ADDRESS = Helper.GetConnectionServer("iSlaviciDB");
        public static Account _loggedAccount;
        public static Person _loggedPerson;
        public static Profile _loggedProfile;
        public static Role _loggedRole;

        public static Subject _subject;
        public static SubjectType subjectType;

        public static SlaviciContext _dbContext;
        public static bool _isConnection;


        /// <summary>
        /// Represents the method that load user list from database 
        /// Account and Person tables
        /// </summary>
        public static List<UserList> LoadUserList()
        {
            List<UserList> userAndPerson;
            userAndPerson = (from acc in _dbContext.Account
                             join per in _dbContext.Person on acc.PersonId equals per.Id
                             join rol in _dbContext.Role on acc.RoleId equals rol.Id
                             join pro in _dbContext.Profile on acc.ProfileId equals pro.Id into lftJoin
                             from leftJoin in lftJoin.DefaultIfEmpty()
                             select new UserList
                             {
                                 ID = acc.Id,
                                 Username = acc.Username,
                                 Name = per.FullName,
                                 CNP = per.CNP,
                                 Role = rol.Name,
                                 Email = per.Email,
                                 Phone = per.Phone,
                                 Profile = (leftJoin == null ? string.Empty : leftJoin.Name),
                                 Year = 1,
                                 CreatedDate = per.CreatedDate
                             }).ToList();
            return userAndPerson;
        }

        /// <summary>
        /// Represents the method that load course list from database Subject table
        /// </summary>
        /// <returns></returns>
        public static List<CourseList> LoadCourseList()
        {
            List<CourseList> courses = (from c in _dbContext.Subject
                                        join pro in _dbContext.Profile on c.ProfileId equals pro.Id
                                        join subType in _dbContext.SubjectType on c.SubjectTypeId equals subType.Id
                                        select new CourseList
                                        {
                                            ID = c.Id,
                                            Name = c.Name,
                                            Abrv = c.Abvr,
                                            Teacher = c.TeacherName,
                                            Profile = c.ProfileName,
                                            Type = c.SubjectTypeName,
                                            Year = c.YearStudy,
                                            Semester = c.SemesterStudy
                                        }).ToList();
            return courses;
        }


        /// <summary>
        /// Represents the method that delete a user from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DeleteUser(int id)
        {
            try
            {
                if (_isConnection)
                {
                    Account deleteAccount = (from account in _dbContext.Account
                                             where account.Id == id
                                             select account).FirstOrDefault();
                    Person deletePerson = (from person in _dbContext.Person
                                           where person.Id == deleteAccount.PersonId
                                           select person).FirstOrDefault();

                    _dbContext.Account.Remove(deleteAccount);
                    _dbContext.Person.Remove(deletePerson);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Represents the method that check if can be a connection to database ip address
        /// </summary>
        /// <returns></returns>
        public static bool TryConnection()
        {
            try
            {
                string ipAddress = _ISLAVICI_DB_IP_ADDRESS;

                Ping ping = new Ping();
                PingOptions options = new PingOptions
                {
                    DontFragment = true
                };

                string data = "a";
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                int timeout = 1;

                PingReply reply = ping.Send(ipAddress, timeout, buffer, options);

                if (reply.Status == IPStatus.Success)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Represents the method that update the user from Edit User page
        /// </summary>
        /// <param name="editAccountId"></param>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="profileId"></param>
        /// <param name="roleId"></param>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <param name="CNP"></param>
        /// <param name="phone"></param>
        internal static bool UpdateUser(string editAccountId, string username, string password, int profileId, int roleId, string fullName, string email, string CNP, string phone)
        {
            try
            {
                Account account = (from acc in DataAccess._dbContext.Account
                                   where acc.Id == int.Parse(editAccountId)
                                   select acc).FirstOrDefault();

                account.Username = username;
                account.Password = password;
                account.ProfileId = profileId;
                account.RoleId = roleId;

                Person person = (from per in _dbContext.Person
                                 where per.Id == account.PersonId
                                 select per).FirstOrDefault();

                person.FullName = fullName;
                person.Email = email;
                person.CNP = CNP;
                person.Phone = phone;
                person.Account = account;

                _dbContext.Account.Update(account);
                _dbContext.Person.Update(person);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Represents the method that create a user account with a person profile
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <param name="profileId"></param>
        /// <param name="roleId"></param>
        /// <param name="fullName"></param>
        /// <param name="email"></param>
        /// <param name="cnp"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        internal static bool CreateUser(string username, string password, int profileId, int roleId, string fullName, string email, string cnp, string phone)
        {
            try
            {
                Account account = new Account
                {
                    Username = username,
                    Password = password,
                    ProfileId = profileId,
                    RoleId = roleId
                };

                Person person = new Person()
                {
                    FullName = fullName,
                    Email = email,
                    CNP = cnp,
                    Phone = phone,
                    Account = account
                };


                _dbContext.Add(person);
                _dbContext.Add(account);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Represents the method that check if the current user exists in database
        /// used in Create User page and Edit User Page with different rules of validating
        /// </summary>
        /// <param name="username"></param>
        /// <param name="cnp"></param>
        /// <param name="email"></param>
        /// <param name="phone"></param>
        /// <param name="editMode"></param>
        /// <param name="currUsername"></param>
        /// <param name="currCnp"></param>
        /// <param name="currEmail"></param>
        /// <param name="currPhone"></param>
        /// <returns></returns>
        internal static string CheckIfUserExist(string username, string cnp, string email, string phone, bool editMode = false, string currUsername = "", string currCnp = "", string currEmail = "", string currPhone = "")
        {
            if (!editMode)
            {
                /// SEARCH FOR USERNAME IN DATABASE
                Account searchedUsername = (from acc in _dbContext.Account
                                            where acc.Username == username
                                            select acc).FirstOrDefault();

                if (searchedUsername != null)
                {
                    return "This username already exists!";
                }

                /// SEARCH FOR PERSON CNP 
                Person searchedPersonCNP = (from per in _dbContext.Person
                                            where per.CNP == cnp
                                            select per).FirstOrDefault();

                if (searchedPersonCNP != null && !string.IsNullOrEmpty(cnp))
                {
                    return "There is already a person with the same CNP!";
                }


                /// IF EMAIL FIELD ITS NOT EMPTY 
                /// THEN CHECK IN DATABASE IF EXIST
                if (!string.IsNullOrEmpty(email))
                {
                    Person searchedPersonEmail = (from per in DataAccess._dbContext.Person
                                                  where per.Email.Equals(email)
                                                  select per).FirstOrDefault();

                    if (searchedPersonEmail != null)
                    {
                        return "This email already exists!";
                    }
                }

                /// IF PHONE FIELD ITS NOT EMPTY
                /// THEN CHECK IN DATABASE IF EXIST
                if (!string.IsNullOrEmpty(phone))
                {
                    Person searchedPersonNumber = (from per in DataAccess._dbContext.Person
                                                   where per.Phone.Equals(phone)
                                                   select per).FirstOrDefault();

                    if (searchedPersonNumber != null)
                    {
                        return "This phone number already exists!";
                    }
                }
                return string.Empty;
            }
            else
            {
                /// SEARCH FOR USERNAME IN DATABASE
                Account searchedUsername = (from acc in DataAccess._dbContext.Account
                                            where acc.Username == username
                                            select acc).FirstOrDefault();

                if (searchedUsername != null && searchedUsername.Username != currUsername)
                {
                    return "This username already exists!";
                }

                /// SEARCH FOR PERSON CNP 
                Person searchedPersonCNP = (from per in _dbContext.Person
                                            where per.CNP == cnp
                                            select per).FirstOrDefault();

                if (searchedPersonCNP != null && searchedPersonCNP.CNP != currCnp)
                {
                    return "There is already a person with the same CNP !";
                }


                /// IF EMAIL FIELD ITS NOT EMPTY 
                /// THEN CHECK IN DATABASE IF EXIST
                if (!string.IsNullOrEmpty(email))
                {
                    Person searchedPersonEmail = (from per in _dbContext.Person
                                                  where per.Email.Equals(email)
                                                  select per).FirstOrDefault();

                    if (searchedPersonEmail != null && searchedPersonEmail.Email != currEmail)
                    {
                        return "This email already exists!";
                    }
                }

                /// IF PHONE FIELD ITS NOT EMPTY
                /// THEN CHECK IN DATABASE IF EXIST
                if (!string.IsNullOrEmpty(phone))
                {
                    Person searchedPersonNumber = (from per in _dbContext.Person
                                                   where per.Phone.Equals(phone)
                                                   select per).FirstOrDefault();

                    if (searchedPersonNumber != null && searchedPersonNumber.Phone != currPhone)
                    {
                        return "This phone number already exists!";
                    }
                }
                return string.Empty;
            }
        }

        /// <summary>
        /// Represents the method that check if the current course exist in database
        /// by coursename or abrravation AND profile 
        /// </summary>
        /// <param name="courseName"></param>
        /// <param name="abrv"></param>
        /// <param name="profilId"></param>
        /// <returns></returns>
        internal static Tuple<bool,string> CheckIfCourseExist(string courseName, string abrv, int profilId)
        {
            Subject subject = (from sub in _dbContext.Subject
                               where (sub.Name == courseName || sub.Abvr == abrv) && sub.ProfileId == profilId
                               select sub).FirstOrDefault();

            if(subject != null)
            {
                return Tuple.Create(true,$"The course already exist");
            } else
            {
                return Tuple.Create(false, "");
            }
        }

        /// <summary>
        /// Represents the method that create course in Subject table
        /// </summary>
        /// <param name="courseName"></param>
        /// <param name="courseAbrv"></param>
        /// <param name="courseTeacherName"></param>
        /// <param name="courseType"></param>
        /// <param name="courseYear"></param>
        /// <param name="courseSemester"></param>
        /// <param name="courseProfile"></param>
        /// <returns></returns>
        internal static Tuple<bool, string> CreateCourse(string courseName, string courseAbrv, string courseTeacherName, int courseType, int courseYear, int courseSemester, int courseProfile, int courseExamMode, int courseCredit)
        {
            try
            {
                var subjectType = _dbContext.SubjectType.Where(x => x.Id == courseType).FirstOrDefault();
                var profile = _dbContext.Profile.Where(x => x.Id == courseProfile).FirstOrDefault();
                var examMode = _dbContext.SubjectExamination.Where(x => x.Id == courseExamMode).FirstOrDefault();

                Subject subject = new Subject
                {
                    Name = courseName,
                    Abvr = courseAbrv,
                    TeacherName = courseTeacherName,
                    SubjectTypeName = subjectType.TypeName,
                    SubjectTypeId = subjectType.Id,
                    YearStudy = courseYear,
                    SemesterStudy = courseSemester,
                    ProfileName = profile.Name,
                    ProfileId = profile.Id,
                    CourseExaminationId = examMode.Id,
                    CourseExaminationName = examMode.ExaminationName,
                    Credit = courseCredit
                };

                _dbContext.Add(subject);
                _dbContext.SaveChanges();

                return Tuple.Create(true, "Course created succesfully!");
            }
            catch (Exception ex)
            {
                return Tuple.Create(false, "Course cannot be created!\n" + ex.Message);
            }
        }

        internal static Tuple<bool, string> DeleteCourse(int id)
        {
            try
            {
                if (_isConnection)
                {
                    Subject deleteSubject = (from sub in _dbContext.Subject
                                             where sub.Id == id
                                             select sub).FirstOrDefault();

                    _dbContext.Subject.Remove(deleteSubject);
                    _dbContext.SaveChanges();
                    return Tuple.Create(true,"Course deleted succesfully!");
                }
                return Tuple.Create(false, "Cannot delete this course!");

            }
            catch (Exception ex)
            {
                return Tuple.Create(false, $"Cannot delete this course!\n{ex.Message}");
            }
        }
    }
}
