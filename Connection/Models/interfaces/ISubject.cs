namespace iSlavici.Connection.Models.interfaces
{
    public interface ISubject
    {
        int Id { get; set; }
        string Name { get; set; }
        string Abvr { get; set; }
        string TeacherName { get; set; }

        int ProfileId { get; set; }
        string ProfileName { get; set; }

        int YearStudy { get; set; }
        int SemesterStudy { get; set; }

        int SubjectTypeId { get; set; }
        string SubjectTypeName { get; set; }

        int CourseExaminationId { get; set; }
        string CourseExaminationName { get; set; }

        int Credit { get; set; }
    }
}
