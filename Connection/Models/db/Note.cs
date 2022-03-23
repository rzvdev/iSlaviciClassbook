using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iSlavici.Connection.Models.db
{
    public class Note
    {
        public int Id { get; set; }

        ///  STUDENT FIELDS
        ///  
        public int PersonId { get; set; }
        public string StudentName { get; set; }


        /// SUBJECTS FIELDS
        /// 
        public Subject Subject { get; set; }
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }

        /// NOTE FIELDS 
        ///
        public int NoteTypeId { get; set; }
        public string NoteTypeName { get; set; }
        public int NoteValue { get; set; }
        public DateTime AddedDate { get; set; }
    }
}