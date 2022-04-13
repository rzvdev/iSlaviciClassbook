using iSlavici.Controls.Navigator.Pages;
using iSlavici.Controls.Spl;

namespace iSlavici.Controls.Nav.Pag
{
    public class PageCourseList : BasePage, IPage, IPageSplitted
    {
        public string PageIdName => PAGE_COURSE_LIST_INDEX_NAME;

        public string PageTitle => PAGE_COURSE_LIST_TITLE;

        public string PageDescription => PAGE_COURSE_LIST_DESCRIPTION;

        public string PageGroup => PAGE_COURSE_LIST_GROUP;

        public SplitterCourseList splitterCourseList { get; set; }

        public void AddSplitContainer() {
            splitterCourseList = new SplitterCourseList();
            Controls.Add(splitterCourseList);
        }

        public override void InitializePage() {
            SetPageInfo();
            AddSplitContainer();
        }

        private PageCourseList() { }

        public static PageCourseList Create() {
            PageCourseList pageCourseList = new PageCourseList();
            pageCourseList.InitializePage();
            return pageCourseList;
        }

        public override void SetPageInfo() {
            Name = PageIdName;
            Text = PageTitle;
            TextDescription = PageDescription;
            TextTitle = PageGroup;
        }
    }
}
