using iSlavici.Connection.Models.db;
using iSlavici.Controls;
using System;
using System.Collections.Generic;

namespace iSlavici.Models
{
    public class NoteListModel : IFiltrable,IFiltrableNotes
    {
        private List<NoteListModel> noteList = new List<NoteListModel>();

        public int Id { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public string SubjectAbrv { get; set; }
        public string TeacherName { get; set; }
        public string NoteType { get; set; }
        public int NoteValue { get; set; }
        public DateTime AddedDate { get; set; }


        // HIDDEN FROM TABLE
        public int ProfileId { get; set; }
        public int CourseYear { get; set; }

        public List<NoteListModel> GetNoteList() {
            return noteList;
        }

        public void SetNoteList(List<NoteListModel> notes) {
            noteList = notes;
        }
    }
}
