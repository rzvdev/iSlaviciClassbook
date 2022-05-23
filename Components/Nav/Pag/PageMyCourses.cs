using iSlavici.Controls.Navigator.Pages;
using iSlavici.Controls.Spl;

namespace iSlavici.Controls.Nav.Pag
{
    public class PanelMyCouresListFilter : BasePage, IPage,IPageSplitted
    {
        public string PageIdName => PAGE_MY_COURSES_INDEX_NAME;

        public string PageTitle => PAGE_MY_COURSES_TITLE;

        public string PageDescription => PAGE_MY_COURSES_DESCRIPTION;

        public string PageGroup => PAGE_MY_COURSES_GROUP;


        public SplitterMyCourses SplitterMyCourses { get; set; }

        public override void InitializePage() {
            SetPageInfo();
            AddSplitContainer();
        }

        public override void SetPageInfo() {
            Name = PageIdName;
            Text = PageTitle;
            TextDescription = PageDescription;
            TextTitle = PageGroup;
        }

        public static PanelMyCouresListFilter Create() {
            PanelMyCouresListFilter page = new PanelMyCouresListFilter();
            page.InitializePage();
            return page;
        }

        public void AddSplitContainer() {
            SplitterMyCourses = new SplitterMyCourses();
            Controls.Add(SplitterMyCourses);
        }
    }
}
