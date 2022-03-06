using iSlavici.Connection.Models.interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iSlavici.Connection.Models.db
{
    public class Subject : ISubject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Abvr { get; set; }
        public string TeacherName { get; set; }

        public int ProfileId { get; set; }
        public string ProfileName { get; set; }

        public int YearStudy { get; set; }
        public int SemesterStudy { get; set; }

        public int SubjectTypeId { get; set; }
        public string SubjectTypeName{ get; set; }

        public int CourseExaminationId { get; set; }
        public string CourseExaminationName { get; set; }

        public int Credit { get; set; }


    }
}