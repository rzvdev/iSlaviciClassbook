using System;

namespace iSlavici.Models
{
    public class NoteList
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public string SubjectName { get; set; }
        public string SubjectAbrv { get; set; }
        public string TeacherName { get; set; }
        public string NoteType { get; set; }
        public int NoteValue { get; set; }
        public DateTime AddedDate { get; set; }
    }
}
