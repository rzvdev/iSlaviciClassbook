using iSlavici.Connection.Models.db;
using iSlavici.Connection.Models.interfaces;
using System;

namespace iSlavici.Connection.Models.builder
{
    public class StudentBuilder
    {
        private readonly Student _student = new Student();

        public StudentBuilder SetPerson(IPerson person)
        {
            _student.Person = (Person)person;
            return this;
        }

        public StudentBuilder WithProfile(int profileId)
        {
            _student.ProfileId = profileId;
            return this;
        }

        public StudentBuilder InYear(int year)
        {
            _student.InYear = year;
            return this;
        }

        public StudentBuilder StartingIn(DateTime startYear)
        {
            _student.StartYear = startYear;
            return this;
        }

        public StudentBuilder EndingIn(DateTime endYear)
        {
            _student.EndYear = endYear;
            return this;
        }

        public Student Build()
        {
            return _student;
        }
    }
}
