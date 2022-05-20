using iSlavici.Components.Nav.Pan;
using System;

namespace iSlavici.Controls.Spl
{
    public class SplitterCourseList : BaseSplitter
    {
        public CourseUC courseUC { get; set; }
        public PanelCourseListFiltersUC PanelCourseListFiltersUC { get; set; }

        public SplitterCourseList() {
            AddPanel2Component();
            AddPanel1Component();
        }

        public override void AddPanel1Component() {
            PanelCourseListFiltersUC = new PanelCourseListFiltersUC();
            Panel1.Controls.Add(PanelCourseListFiltersUC);
        }

        public override void AddPanel2Component() {
            courseUC = new CourseUC();
            Panel2.Controls.Add(courseUC);
        }
    }
}
