using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iSlavici.Connection.Models.db
{
    public class Student
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int PersonId { get; set; }
        public int ProfileId { get; set; }
        public int InYear { get; set; }
        public DateTime StartYear{ get; set; }
        public DateTime EndYear { get; set; }
    }
}
