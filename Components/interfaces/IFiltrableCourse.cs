using iSlavici.Models;
using System.Collections.Generic;

namespace iSlavici.Components.interfaces
{
    public interface IFiltrableCourse
    {
        List<CourseListModel> GetCourseList();
        void SetCourseList(List<CourseListModel> courseList);
    }
}
