using iSlavici.Components.interfaces;
using iSlavici.Controls;
using System;
using System.Collections.Generic;

namespace iSlavici.Models
{
    public class UserListModel : IFiltrable,IFiltrableUser
    {
        private List<UserListModel> UserLists { get; set; }
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string CNP { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Profile { get; set; }
        public int Year { get; set; }
        public DateTime CreatedDate 
        {
            get;
            set;
        }

        public UserListModel(int Id, string username,string password, string name, string cnp, string role, string email, string profile, string phone, int year, DateTime createdDate)
        {
            ID = Id;
            Username = username;
            Password = password;
            Name = name;
            CNP = cnp;
            Role = role;
            Email = email;
            Phone = phone;
            Profile = profile;
            Year = year;
            CreatedDate = createdDate;
        }

        public UserListModel()
        {

        }

        public List<UserListModel> GetUserList() {
            return UserLists;
        }

        public void SetUserList(List<UserListModel> userList) {
            UserLists = userList;
        }

        public List<NoteListModel> GetNoteList() {
            throw new NotImplementedException();
        }

        public List<NoteOneStudentListModel> GetOneStudentNoteList() {
            throw new NotImplementedException();
        }

        public void SetNoteList(List<NoteListModel> notes) {
            throw new NotImplementedException();
        }

        public void SetOneStudentNoteList(List<NoteOneStudentListModel> notes) {
            throw new NotImplementedException();
        }

        public List<CourseListModel> GetCourseList() {
            throw new NotImplementedException();
        }

        public void SetCourseList(List<CourseListModel> courseList) {
            throw new NotImplementedException();
        }
    }
}
