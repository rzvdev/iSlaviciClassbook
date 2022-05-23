using iSlavici.Components.interfaces;
using iSlavici.Controls;
using System.Collections.Generic;

namespace iSlavici.Models
{
    public class CourseListModel : IFiltrable,IFiltrableCourse
    {
        private List<CourseListModel> CourseLists = new List<CourseListModel>();
        public int ID { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public string Teacher { get; set; }
        public string Profile { get; set; }
        public string Type { get; set; }
        public string ExaminationMode { get; set; }
        public int Credit { get; set; }
        public int Year { get; set; }
        public int Semester { get; set; }

        public CourseListModel(int id, string courseName, string abrv, string teacherName, string profileName, string subjectType, int year, int semester, string examMode, int credit)
        {
            ID = id;
            Name = courseName;
            Abrv = abrv;
            Teacher = teacherName;
            Profile = profileName;
            Type = subjectType;
            Year = year;
            Semester = semester;
            ExaminationMode = examMode;
            Credit = credit;
        }

        public CourseListModel()
        {

        }

        public List<CourseListModel> GetCourseList() {
            return CourseLists;
        }

        public void SetCourseList(List<CourseListModel> courseList) {
            CourseLists = courseList;
        }

        public List<NoteListModel> GetNoteList() {
            throw new System.NotImplementedException();
        }

        public List<NoteOneStudentListModel> GetOneStudentNoteList() {
            throw new System.NotImplementedException();
        }

        public void SetNoteList(List<NoteListModel> notes) {
            throw new System.NotImplementedException();
        }

        public void SetOneStudentNoteList(List<NoteOneStudentListModel> notes) {
            throw new System.NotImplementedException();
        }

        public List<UserListModel> GetUserList() {
            throw new System.NotImplementedException();
        }

        public void SetUserList(List<UserListModel> userList) {
            throw new System.NotImplementedException();
        }
    }
}
