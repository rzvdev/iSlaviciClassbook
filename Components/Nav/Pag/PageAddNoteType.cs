using iSlavici.Controls.Nav.Pan;
using iSlavici.Controls.Navigator.Pages;
using iSlavici.Controls.Spl;

namespace iSlavici.Controls.Nav.Pag
{
    public class PageAddNoteType : BasePage, IPage
    {
        public string PageIdName => PAGE_NOTE_TYPE_INDEX_NAME;

        public string PageTitle => PAGE_NOTE_TYPE_TITLE;

        public string PageDescription => PAGE_NOTE_TYPE_DESCRIPTION;

        public string PageGroup => PAGE_NOTE_TYPE_GROUP;

        public SplitterNoteType splitter { get; set; }
        public override void InitializePage() {
            SetPageInfo();
            splitter = new SplitterNoteType();
            Controls.Add(splitter);
        }

        public override void SetPageInfo() {
            Name = PageIdName;
            Text = PageTitle;
            TextDescription = PageDescription;
            TextTitle = PageGroup;
        }
        public static PageAddNoteType Create() {
            PageAddNoteType pageAddNotetype = new PageAddNoteType();
            pageAddNotetype.InitializePage();
            return pageAddNotetype;
        }
    }
}
