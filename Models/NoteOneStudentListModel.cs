using System;

namespace iSlavici.Models
{
    public class NoteOneStudentListModel
    {
        public string SubjectName { get; set; }
        public string SubjectAbvr { get; set; }
        public string TeacherName { get; set; }
        public string NoteType { get; set; }
        public int Note { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
