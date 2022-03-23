using iSlavici.Connection.Models.builder;
using iSlavici.Connection.Models.db;
using iSlavici.Connection.Models.db.interfaces;
using iSlavici.Connection.Models.interfaces;
using iSlavici.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace classbook.Connection
{
    public class DataAccess
    {
        private static readonly string _ISLAVICI_DB_IP_ADDRESS = Helper.GetConnectionServer("iSlaviciDB");
        public static Account _loggedAccount;
        public static Person _loggedPerson;
        public static Profile _loggedProfile;
        public static Role _loggedRole;
        public static Student _loggedStudent;

        public static Subject _subject;
        public static SubjectType subjectType;

        public static SlaviciContext _dbContext;
        public static bool _isConnection;

        public static List<NoteList> noteList = new List<NoteList>();
        public static List<StudentNoteList> studentNoteList = new List<StudentNoteList>();
        public static List<UserList> userList = new List<UserList>();


        public static bool AddNote(Person person,Subject subject,NoteType noteType,int noteValue)
        {
            try
            {
                Note toAdd = new Note
                {
                    StudentName = person.FullName,
                    PersonId = person.Id,
                    SubjectName = subject.Name,
                    SubjectId = subject.Id,
                    NoteTypeId = noteType.Id,
                    NoteTypeName = noteType.TypeName,
                    NoteValue = noteValue,
                    AddedDate = DateTime.Now
                };

                _dbContext.Note.Add(toAdd);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }


        /// <summary>
        /// Represents the method that load user list from database 
        /// Account and Person tables
        /// </summary>
        public static async void LoadUserList()
        {
            userList = await (from acc in _dbContext.Account
                             join per in _dbContext.Person on acc.PersonId equals per.Id
                             join stu in _dbContext.Student on per.Id equals stu.PersonId
                             join rol in _dbContext.Role on acc.RoleId equals rol.Id
                             join pro in _dbContext.Profile on stu.ProfileId equals pro.Id into lftJoin
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
                                 Year = stu.InYear,
                                 CreatedDate = per.CreatedDate
                             }).ToListAsync();
        }

        public static async Task LoadStudentNotesAsync(string studentCnp, string subjectName)
        {
            await Task.Run(async () =>
            {
                studentNoteList = await (from student in _dbContext.Person
                                         where student.CNP.Equals(studentCnp)
                                         join note in _dbContext.Note on student.Id equals note.PersonId
                                         join subject in _dbContext.Subject on note.SubjectId equals subject.Id
                                         where subject.Name == subjectName
                                         orderby note.AddedDate descending
                                         select new StudentNoteList
                                         {
                                             SubjectName = subject.Name,
                                             SubjectAbvr = subject.Abvr,
                                             TeacherName = subject.TeacherName,
                                             NoteType = note.NoteTypeName,
                                             Note = note.NoteValue,
                                             DateAdded = note.AddedDate
                                         }).ToListAsync();
            });
        }

        public static async Task LoadNoteListAsync()    
        {
            await Task.Run(async () =>
            {
                noteList = await (from n in _dbContext.Note
                         join stu in _dbContext.Person on n.PersonId equals stu.Id
                         join ty in _dbContext.NoteType on n.NoteTypeId equals ty.Id
                         select new NoteList
                         {
                             Id = n.Id,
                             SubjectName = n.SubjectName,
                             SubjectAbrv = n.Subject.Abvr,
                             StudentName = n.StudentName,
                             TeacherName = n.Subject.TeacherName,
                             NoteType = n.NoteTypeName,
                             NoteValue = n.NoteValue,
                             AddedDate = n.AddedDate
                         }).ToListAsync();
            });
        }

        /// <summary>
        /// Represents the method that load 
        /// 
        /// 
        /// 
        /// 
        /// 
        /// list from database Subject table
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
                                            ExaminationMode = c.CourseExaminationName,
                                            Credit = c.Credit,
                                            Year = c.YearStudy,
                                            Semester = c.SemesterStudy,
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
        internal static bool UpdateUser(string editAccountId, string username, string password, int roleId, string fullName, string email, string CNP, string phone, int profileId, int inYear)
        {
            try
            {
                Account account = (from acc in _dbContext.Account
                                   where acc.Id == int.Parse(editAccountId)
                                   select acc).FirstOrDefault();

                account.Username = username;
                account.Password = password;
                account.RoleId = roleId;

                Person person = (from per in _dbContext.Person
                                 where per.Id == account.PersonId
                                 select per).FirstOrDefault();

                person.FullName = fullName;
                person.Email = email;
                person.CNP = CNP;
                person.Phone = phone;
                person.Account = account;

                Student student = (from stu in _dbContext.Student
                                   where stu.PersonId == person.Id
                                   select stu).FirstOrDefault();

                student.ProfileId = profileId;
                student.InYear = inYear;

                _dbContext.Account.Update(account);
                _dbContext.Person.Update(person);
                _dbContext.Student.Update(student);
                _dbContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Return a school start year formatted
        /// </summary>
        /// <returns></returns>
        private static DateTime SetStartYear()
        {
            try
            {
                DateTime startYear = new DateTime(DateTime.Now.Year, 10, 1);
                return Convert.ToDateTime(startYear.ToString("dd/MM/yyyy"));
            } catch(Exception ex)
            {
                throw ex;
            }
        } 

        /// <summary>
        /// Return year when student mush finish school
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        private static DateTime SetEndYear(Profile profile)
        {
            try
            {
                return Convert.ToDateTime(new DateTime(SetStartYear().AddYears(profile.Years).Year, 6, 1).ToString("dd/MM/yyyy"));
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Represents the method that create a user account with a person profile
        /// </summary>
        internal static bool CreateUser(string username, string password, int profileId, int roleId, string fullName, string email, string cnp, string phone, int inYear)
        {
            try
            {
                /// USING BUILDER DESIGN PATTERN
                AccountBuilder buildAccount = new AccountBuilder();
                IAccount account = buildAccount.Username(username)
                                                .Password(password)
                                                .Have(roleId)
                                                .Build();

                PersonBuilder buildPerson = new PersonBuilder();
                IPerson person = buildPerson.Name(fullName)
                                           .HavePhone(phone)
                                           .HaveCnp(cnp)
                                           .HaveEmail(email)
                                           .WithAccount((Account)account)
                                           .Build();
                
                Profile profil = (from pr in _dbContext.Profile
                                  where pr.Id == profileId
                                  select pr).FirstOrDefault();

                DateTime startYear = new DateTime(DateTime.Now.Year, 10, 1);
                DateTime endYear = new DateTime(startYear.AddYears(profil.Years).Year, 6, 1);

                StudentBuilder buildStudent = new StudentBuilder();
                IStudent student = buildStudent.SetPerson(person)
                                               .WithProfile(profileId)
                                               .InYear(inYear)
                                               .StartingIn(SetStartYear())
                                               .EndingIn(SetEndYear(profil))
                                               .Build();
                _dbContext.Add(account);
                _dbContext.Add(person);
                _dbContext.Add(student);
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
        internal static Tuple<bool, string> CreateCourse(string courseName, string courseAbrv, string courseTeacherName, int courseType, int courseYear, int courseSemester, int courseProfile, int courseExamMode, int courseCredit)
        {
            try
            {
                var subjectType = _dbContext.SubjectType.Where(x => x.Id == courseType).FirstOrDefault();
                var profile = _dbContext.Profile.Where(x => x.Id == courseProfile).FirstOrDefault();
                var examMode = _dbContext.SubjectExamination.Where(x => x.Id == courseExamMode).FirstOrDefault();

                /// USING BUILDER DESIGN PATTERN
                SubjectBuilder subjectBuilder = new SubjectBuilder();
                ISubject subject = subjectBuilder.HaveName(courseName)
                                                 .WithAbvr(courseAbrv)
                                                 .TeachBy(courseTeacherName)
                                                 .TypeOf(subjectType)
                                                 .In(courseYear, courseSemester)
                                                 .On(profile)
                                                 .ExaminationMode(examMode)
                                                 .WithCredit(courseCredit)
                                                 .Build();

                _dbContext.Add(subject);
                _dbContext.SaveChanges();

                return Tuple.Create(true, "Course created succesfully!");
            }
            catch (Exception ex)
            {
                return Tuple.Create(false, "Course cannot be created!\n" + ex.Message);
            }
        }


        /// <summary>
        /// That method delete a course from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
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
