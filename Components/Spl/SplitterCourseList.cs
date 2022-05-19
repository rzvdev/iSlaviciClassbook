using System;

namespace iSlavici.Controls.Spl
{
    public class SplitterCourseList : BaseSplitter
    {
        public CourseUC courseUC { get; set; }

        public SplitterCourseList() {
            AddPanel2Component();
        }

        public override void AddPanel1Component() {
            throw new NotImplementedException();
        }

        public override void AddPanel2Component() {
            courseUC = new CourseUC();
            Panel2.Controls.Add(courseUC);
        }
    }
}
