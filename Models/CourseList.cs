using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iSlavici.Models   
{
    public class CourseList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Abrv { get; set; }
        public string Teacher { get; set; }
        public string Profile { get; set; }
        public string Type{ get; set; }
        public int Year{ get; set; }
        public int Semester{ get; set; }

        public CourseList(int id, string courseName, string abrv, string teacherName, string profileName, string subjectType, int year, int semester)
        {
            ID = id;
            Name = courseName;
            Abrv = abrv;
            Teacher = teacherName;
            Profile = profileName;
            Type = subjectType;
            Year = year;
            Semester = semester;
        }

        public CourseList()
        {

        }
    }
}
