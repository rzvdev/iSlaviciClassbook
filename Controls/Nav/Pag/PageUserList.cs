using iSlavici.Controls.Navigator.Pages;
using iSlavici.Controls.Spl;

namespace iSlavici.Controls.Nav.Pag
{
    public class PageUserList : BasePage, IPage, IPageSplitted
    {
        public string PageIdName { get => PAGE_USER_LIST_TITLE; }
        public string PageTitle { get => PAGE_USER_LIST_TITLE; }
        public string PageDescription { get => PAGE_USER_LIST_DESCRIPTION; }
        public string PageGroup { get => PAGE_USER_LIST_GROUP; }

        public SplitterUserList spliitterUserList { get; set; }

        public void AddSplitContainer() {
            spliitterUserList = new SplitterUserList();
            Controls.Add(spliitterUserList);
        }

        public override void SetPageInfo() {
            Name = PageIdName;
            Text = PageTitle;
            TextDescription = PageDescription;
            TextTitle = PageGroup;
        }

        private PageUserList() {
        }

        public static PageUserList Create() {
            PageUserList pageUserList = new PageUserList();
            pageUserList.InitializePage();
            return pageUserList;
        }

        public override void InitializePage() {
            SetPageInfo();
            AddSplitContainer();
        }


    }
}
