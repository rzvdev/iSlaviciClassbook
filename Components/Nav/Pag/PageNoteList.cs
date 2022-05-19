using iSlavici.Controls.Nav.Spl;
using iSlavici.Controls.Navigator.Pages;

namespace iSlavici.Controls.Nav.Pag
{
    internal class PageNoteList : BasePage, IPage, IPageSplitted
    {
        public string PageIdName => PAGE_NOTE_LIST_INDEX_NAME;

        public string PageTitle => PAGE_NOTE_LIST_TITLE;

        public string PageDescription => PAGE_NOTE_LIST_DESCRIPTION;

        public string PageGroup => PAGE_NOTE_LIST_GROUP;

        public SplitterNoteList splitter { get; set; }
        public void AddSplitContainer() {
            splitter = new SplitterNoteList();
            Controls.Add(splitter);
        }

        public override void InitializePage() {
            SetPageInfo();
            AddSplitContainer();
        }

        public static PageNoteList Create() {
            PageNoteList pageNoteList = new PageNoteList();
            pageNoteList.InitializePage();
            return pageNoteList;
        }

        public override void SetPageInfo() {
            Name = PageIdName;
            Text = PageTitle;
            TextDescription = PageDescription;
            TextTitle = PageGroup;
        }
    }
}
