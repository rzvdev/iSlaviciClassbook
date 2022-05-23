using iSlavici.Components.Nav.Pan;

namespace iSlavici.Controls.Spl
{
    public class SplitterMyCourses : BaseSplitter
    {
        public MyCoursesUC MyCoursesUC { get; set; }
        public PanelMyCoursesListFiltersUC PanelMyCourses { get; set; }

        public SplitterMyCourses() {
            AddPanel2Component();
            AddPanel1Component();
        }

        public override void AddPanel1Component() {
            PanelMyCourses = new PanelMyCoursesListFiltersUC();
            Panel1.Controls.Add(PanelMyCourses);
        }

        public override void AddPanel2Component() {
            MyCoursesUC = new MyCoursesUC();
            Panel2.Controls.Add(MyCoursesUC);
        }
    }
}
