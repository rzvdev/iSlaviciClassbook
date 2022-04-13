using iSlavici.Connection.Models.builder;
using iSlavici.Connection.Models.db;
using iSlavici.Connection.Models.db.interfaces;
using iSlavici.Connection.Models.interfaces;
using iSlavici.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;

namespace classbook.Connection
{
    public class DataAccess
    {
        private static readonly string _ISLAVICI_DB_IP_ADDRESS = Helper.GetConnectionServer("SlaviciDB");


        public static Account _loggedAccount;
        public static Person _loggedPerson;
        public static Profile _loggedProfile;
        public static Role _loggedRole;
        public static Student _loggedStudent;

        public static Subject _subject;
        public static SubjectType subjectType;

        public static SlaviciContext _dbContext;
        public static bool _isConnection;

        public static List<NoteListModel> notes = new List<NoteListModel>();
        public static List<NoteOneStudentListModel> studentNotes = new List<NoteOneStudentListModel>();
        public static List<UserListModel> users = new List<UserListModel>();
        public static List<CourseListModel> courses = new List<CourseListModel>();

        public static List<Profile> profiles = new List<Profile>();
        public static List<NoteType> noteTypes = new List<NoteType>();
        public static List<Person> students = new List<Person>();



        public static void AddNoteType(string typeName) {
            try {
                NoteType toAdd = new NoteType {
                    TypeName = typeName
                };
                _dbContext.NoteType.Add(toAdd);
                _dbContext.SaveChanges();
            }catch(Exception ex) {
                throw ex;
            }
        }

        public static bool AddNote(Person person, Subject subject, NoteType noteType, int noteValue) {
            try {
                Note toAdd = new Note {
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
            } catch {
                return false;
            }
        }


        public static void LoadStudents() {
            _dbContext = new SlaviciContext();
            students = (from per in _dbContext.Person
                        join stu in _dbContext.Student on per.Id equals stu.PersonId
                        select per).ToList();
        }

        public static void LoadProfiles() {
            _dbContext = new SlaviciContext();
            profiles = (from pr in _dbContext.Profile
                        select pr).ToList();
        }

        public static void LoadNoteTypes() {
            _dbContext = new SlaviciContext();
            noteTypes = (from nt in _dbContext.NoteType
                         select nt).ToList();
        }

        /// <summary>
        /// Represents the method that load user list from database 
        /// Account and Person tables
        /// </summary>
        public static void LoadUsers() {
            _dbContext = new SlaviciContext();
            users = (from acc in _dbContext.Account
                     join per in _dbContext.Person on acc.PersonId equals per.Id
                     join stu in _dbContext.Student on per.Id equals stu.PersonId into lftStudentJoin
                     from leftStudent in lftStudentJoin.DefaultIfEmpty()
                     join rol in _dbContext.Role on acc.RoleId equals rol.Id
                     join pro in _dbContext.Profile on leftStudent.ProfileId equals pro.Id into lftJoin
                     from leftJoin in lftJoin.DefaultIfEmpty()
                     select new UserListModel {
                         ID = acc.Id,
                         Username = acc.Username,
                         Password = acc.Password,
                         Name = per.FullName,
                         CNP = per.CNP,
                         Role = rol.Name,
                         Email = per.Email,
                         Phone = per.Phone,
                         Profile = (leftJoin == null ? string.Empty : leftJoin.Name),
                         Year = leftStudent.InYear,
                         CreatedDate = per.CreatedDate
                     }).ToList();
        }

        public static void LoadStudentNotes(string studentCnp, string subjectName) {
            _dbContext = new SlaviciContext();
            studentNotes = (from student in _dbContext.Person
                            where student.CNP.Equals(studentCnp)
                            join note in _dbContext.Note on student.Id equals note.PersonId
                            join subject in _dbContext.Subject on note.SubjectId equals subject.Id
                            where subject.Name == subjectName
                            orderby note.AddedDate descending
                            select new NoteOneStudentListModel {
                                SubjectName = subject.Name,
                                SubjectAbvr = subject.Abvr,
                                TeacherName = subject.TeacherName,
                                NoteType = note.NoteTypeName,
                                Note = note.NoteValue,
                                DateAdded = note.AddedDate
                            }).ToList();
        }

        public static void LoadNotes() {
            _dbContext = new SlaviciContext();
            notes = (from n in _dbContext.Note
                     join stu in _dbContext.Person on n.PersonId equals stu.Id
                     join ty in _dbContext.NoteType on n.NoteTypeId equals ty.Id
                     select new NoteListModel {
                         Id = n.Id,
                         SubjectName = n.SubjectName,
                         SubjectAbrv = n.Subject.Abvr,
                         StudentName = n.StudentName,
                         TeacherName = n.Subject.TeacherName,
                         NoteType = n.NoteTypeName,
                         NoteValue = n.NoteValue,
                         AddedDate = n.AddedDate
                     }).ToList();
        }

        /// <summary>
        /// Represents the method that load 
        /// list from database Subject table
        /// </summary>
        /// <returns></returns>
        public static void LoadCourses() {
            _dbContext = new SlaviciContext();
            courses = (from c in _dbContext.Subject
                       join pro in _dbContext.Profile on c.ProfileId equals pro.Id
                       join subType in _dbContext.SubjectType on c.SubjectTypeId equals subType.Id
                       select new CourseListModel {
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
        }


        /// <summary>
        /// Represents the method that delete a user from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static bool DeleteUser(int id) {
            try {
                if (_isConnection) {
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

            } catch (Exception ex) {
                throw ex;
            }
        }

        public static bool DeleteNoteType(int id) {
            try {
                if (_isConnection) {
                    NoteType deleteNoteType = (from nt in _dbContext.NoteType
                                               where nt.Id == id
                                               select nt).FirstOrDefault();

                    _dbContext.NoteType.Remove(deleteNoteType);
                    _dbContext.SaveChanges();
                    return true;
                }
                return false;
            } catch(Exception ex) {
                throw ex;
            }
        }

        /// <summary>
        /// Represents the method that check if can be a connection to database ip address
        /// </summary>
        /// <returns></returns>
        public static bool TryConnection() {
            try {
                string ipAddress = _ISLAVICI_DB_IP_ADDRESS;
                IPAddress ip = Dns.GetHostEntry(ipAddress).AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(ip, 1433);

                using (TcpClient tcpClient = new TcpClient()) {
                    tcpClient.Connect(ipEndPoint);
                    return true;
                }
            } catch {
                return false;
            }
        }

        /// <summary>
        /// Represents the method that update the user from Edit User page
        /// </summary>
        internal static bool UpdateUser(int editAccountId, string username, string password, int roleId, string fullName, string email, string CNP, string phone, int profileId, int inYear) {
            try {
                Account account = (from acc in _dbContext.Account
                                   where acc.Id == editAccountId
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
            } catch {
                return false;
            }
        }

        /// <summary>
        /// Return a school start year formatted
        /// </summary>
        /// <returns></returns>
        private static DateTime SetStartYear() {
            try {
                DateTime startYear = new DateTime(DateTime.Now.Year, 10, 1);
                return Convert.ToDateTime(startYear.ToString("dd/MM/yyyy"));
            } catch (Exception ex) {
                throw ex;
            }
        }

        /// <summary>
        /// Return year when student mush finish school
        /// </summary>
        /// <param name="profile"></param>
        /// <returns></returns>
        private static DateTime SetEndYear(Profile profile) {
            try {
                return Convert.ToDateTime(new DateTime(SetStartYear().AddYears(profile.Years).Year, 6, 1).ToString("dd/MM/yyyy"));
            } catch (Exception ex) {
                throw ex;
            }
        }

        /// <summary>
        /// Represents the method that create a user account with a person profile
        /// </summary>
        internal static bool CreateUser(string username, string password, int profileId, int roleId, string fullName, string email, string cnp, string phone, int inYear) {
            try {
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

                Role role = (from rol in _dbContext.Role
                             where rol.Id == roleId
                             select rol).FirstOrDefault();

                IStudent student = null;
                if (role.Name.Equals("STUDENT")) {
                    Profile profil = (from pr in _dbContext.Profile
                                      where pr.Id == profileId
                                      select pr).FirstOrDefault();

                    DateTime startYear = new DateTime(DateTime.Now.Year, 10, 1);
                    DateTime endYear = new DateTime(startYear.AddYears(profil.Years).Year, 6, 1);

                    StudentBuilder buildStudent = new StudentBuilder();
                    student = buildStudent.SetPerson(person)
                                                   .WithProfile(profileId)
                                                   .InYear(inYear)
                                                   .StartingIn(SetStartYear())
                                                   .EndingIn(SetEndYear(profil))
                                                   .Build();
                }

                _dbContext.Add(account);
                _dbContext.Add(person);
                if(student != null) _dbContext.Add(student);
                _dbContext.SaveChanges();
                return true;
            } catch {
                return false;
            }
        }


        public static string CheckIfEditUserExist(string editedUsername, string editedCnp, string editedEmail, string editedPhone, string actualUsername, string actualCnp, string actualEmail, string actualPhone) {
            /// SEARCH FOR USERNAME IN DATABASE
            Account searchedUsername = (from acc in _dbContext.Account
                                        where acc.Username == editedUsername
                                        select acc).FirstOrDefault();

            if (searchedUsername != null && searchedUsername.Username != actualUsername) {
                return "This username already exists!";
            }

            /// SEARCH FOR PERSON CNP 
            Person searchedPersonCNP = (from per in _dbContext.Person
                                        where per.CNP == editedCnp
                                        select per).FirstOrDefault();

            if (searchedPersonCNP != null && searchedPersonCNP.CNP != actualCnp) {
                return "There is already a person with the same CNP !";
            }


            /// IF EMAIL FIELD ITS NOT EMPTY 
            /// THEN CHECK IN DATABASE IF EXIST
            if (!string.IsNullOrEmpty(editedEmail)) {
                Person searchedPersonEmail = (from per in _dbContext.Person
                                              where per.Email.Equals(editedEmail)
                                              select per).FirstOrDefault();

                if (searchedPersonEmail != null && searchedPersonEmail.Email != actualEmail) {
                    return "This email already exists!";
                }
            }

            /// IF PHONE FIELD ITS NOT EMPTY
            /// THEN CHECK IN DATABASE IF EXIST
            if (!string.IsNullOrEmpty(editedPhone)) {
                Person searchedPersonNumber = (from per in _dbContext.Person
                                               where per.Phone.Equals(editedPhone)
                                               select per).FirstOrDefault();

                if (searchedPersonNumber != null && searchedPersonNumber.Phone != actualPhone) {
                    return "This phone number already exists!";
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// Represents the method that check if the current user exists in database
        /// used in Create User page and Edit User Page with different rules of validating
        /// </summary>
        internal static string CheckIfUserExist(string username, string cnp, string email, string phone) {
            /// SEARCH FOR USERNAME IN DATABASE
            Account searchedUsername = (from acc in _dbContext.Account
                                        where acc.Username == username
                                        select acc).FirstOrDefault();

            if (searchedUsername != null) {
                return "This username already exists!";
            }

            /// SEARCH FOR PERSON CNP 
            Person searchedPersonCNP = (from per in _dbContext.Person
                                        where per.CNP == cnp
                                        select per).FirstOrDefault();

            if (searchedPersonCNP != null && !string.IsNullOrEmpty(cnp)) {
                return "There is already a person with the same CNP!";
            }


            /// IF EMAIL FIELD ITS NOT EMPTY 
            /// THEN CHECK IN DATABASE IF EXIST
            if (!string.IsNullOrEmpty(email)) {
                Person searchedPersonEmail = (from per in DataAccess._dbContext.Person
                                              where per.Email.Equals(email)
                                              select per).FirstOrDefault();

                if (searchedPersonEmail != null) {
                    return "This email already exists!";
                }
            }

            /// IF PHONE FIELD ITS NOT EMPTY
            /// THEN CHECK IN DATABASE IF EXIST
            if (!string.IsNullOrEmpty(phone)) {
                Person searchedPersonNumber = (from per in DataAccess._dbContext.Person
                                               where per.Phone.Equals(phone)
                                               select per).FirstOrDefault();

                if (searchedPersonNumber != null) {
                    return "This phone number already exists!";
                }
            }
            return string.Empty;
        }

        /// <summary>
        /// Represents the method that check if the current course exist in database
        /// by coursename or abrravation AND profile 
        /// </summary>
        internal static Tuple<bool, string> CheckIfCourseExist(string courseName, string abrv, int profilId) {
            Subject subject = (from sub in _dbContext.Subject
                               where (sub.Name == courseName || sub.Abvr == abrv) && sub.ProfileId == profilId
                               select sub).FirstOrDefault();

            if (subject != null) {
                return Tuple.Create(true, $"The course already exist");
            } else {
                return Tuple.Create(false, "");
            }
        }

        /// <summary>
        /// Represents the method that create course in Subject table
        /// </summary>
        internal static Tuple<bool, string> CreateCourse(string courseName, string courseAbrv, string courseTeacherName, int courseType, int courseYear, int courseSemester, int courseProfile, int courseExamMode, int courseCredit) {
            try {
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
            } catch (Exception ex) {
                return Tuple.Create(false, "Course cannot be created!\n" + ex.Message);
            }
        }


        /// <summary>
        /// That method delete a course from database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        internal static Tuple<bool, string> DeleteCourse(int id) {
            try {
                if (_isConnection) {
                    Subject deleteSubject = (from sub in _dbContext.Subject
                                             where sub.Id == id
                                             select sub).FirstOrDefault();

                    _dbContext.Subject.Remove(deleteSubject);
                    _dbContext.SaveChanges();
                    return Tuple.Create(true, "Course deleted succesfully!");
                }
                return Tuple.Create(false, "Cannot delete this course!");

            } catch (Exception ex) {
                return Tuple.Create(false, $"Cannot delete this course!\n{ex.Message}");
            }
        }
    }
}
