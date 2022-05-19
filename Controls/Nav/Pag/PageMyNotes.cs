using iSlavici.Controls.Navigator.Pages;
using iSlavici.Controls.Spl;

namespace iSlavici.Controls.Nav.Pag
{
    public class PageMyNotes : BasePage, IPage, IPageSplitted
    {
        public string PageIdName => PAGE_MY_NOTES_INDEX_NAME;

        public string PageTitle => PAGE_MY_NOTES_TITLE;

        public string PageDescription => PAGE_MY_NOTES_DESCRIPTION;

        public string PageGroup => PAGE_MY_NOTES_GROUP;

        public SplitterMyNotes splitterMyNotes { get; set; }

        public void AddSplitContainer() {
            splitterMyNotes = new SplitterMyNotes();
            Controls.Add(splitterMyNotes);
        }

        public override void InitializePage() {
            SetPageInfo();
            AddSplitContainer();
        }

        public static PageMyNotes Create() {
            PageMyNotes pageMyNotes = new PageMyNotes();
            pageMyNotes.InitializePage();
            return pageMyNotes;
        }

        private PageMyNotes() { }

        public override void SetPageInfo() {
            Name = PageIdName;
            Text = PageTitle;
            TextDescription = PageDescription;
            TextTitle = PageGroup;
        }
    }
}
