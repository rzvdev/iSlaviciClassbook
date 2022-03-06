using iSlavici.Connection.Models.db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSlavici.Connection.Models.builder
{
    public class SubjectBuilder
    {
        private readonly Subject _subject = new Subject();

        public SubjectBuilder HaveName(string name)
        {
            _subject.Name = name;
            return this;
        }

        public SubjectBuilder WithAbvr(string abvr)
        {
            _subject.Abvr = abvr;
            return this;
        }

        public SubjectBuilder TeachBy(string teacherName)
        {
            _subject.TeacherName = teacherName;
            return this;
        }

        public SubjectBuilder On(Profile profile)
        {
            _subject.ProfileId = profile.Id;
            _subject.ProfileName = profile.Name;
            return this;
        }

        public SubjectBuilder In(int year,int semester)
        {
            _subject.YearStudy = year;
            _subject.SemesterStudy = semester;
            return this;
        }

        public SubjectBuilder TypeOf(SubjectType type)
        {
            _subject.SubjectTypeId = type.Id;
            _subject.SubjectTypeName = type.TypeName;
            return this;
        }

        public SubjectBuilder ExaminationMode(SubjectExamination examination)
        {
            _subject.CourseExaminationId = examination.Id;
            _subject.CourseExaminationName = examination.ExaminationName;
            return this;
        }

        public SubjectBuilder WithCredit(int credit)
        {
            _subject.Credit = credit;
            return this;
        }

        public Subject Build()
        {
            return _subject;
        }
    }
}
