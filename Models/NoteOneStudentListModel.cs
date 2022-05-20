using iSlavici.Controls;
using System;
using System.Collections.Generic;

namespace iSlavici.Models
{
    public class NoteOneStudentListModel : IFiltrable, IFiltrableNotes
    {
        private List<NoteOneStudentListModel> noteList { get; set; }

        public int NoteId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectAbvr { get; set; }
        public string TeacherName { get; set; }
        public string NoteType { get; set; }
        public int Note { get; set; }
        public DateTime DateAdded { get; set; }

        

        public List<NoteListModel> GetNoteList() {
            throw new NotImplementedException();
        }

        public List<NoteOneStudentListModel> GetOneStudentNoteList() {
            return noteList;
        }

        public void SetNoteList(List<NoteListModel> notes) {
            throw new NotImplementedException();
        }

        public void SetOneStudentNoteList(List<NoteOneStudentListModel> notes) {
            noteList = notes;
        }

        public List<CourseListModel> GetCourseList() {
            throw new NotImplementedException();
        }

        public void SetCourseList(List<CourseListModel> courseList) {
            throw new NotImplementedException();
        }
    }
}
