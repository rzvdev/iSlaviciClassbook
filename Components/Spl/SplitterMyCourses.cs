using System;

namespace iSlavici.Controls.Spl
{
    public class SplitterMyCourses : BaseSplitter
    {
        public MyCoursesUC MyCoursesUC { get; set; }

        public SplitterMyCourses() {
            AddPanel2Component();
        }

        public override void AddPanel1Component() {
            throw new NotImplementedException();
        }

        public override void AddPanel2Component() {
            MyCoursesUC = new MyCoursesUC();
            Panel2.Controls.Add(MyCoursesUC);
        }
    }
}
