using iSlavici.Controls.Nav.Pan;
using iSlavici.Controls.Navigator.Pages;

namespace iSlavici.Controls.Nav.Pag
{
    public class PageAddNote : BasePage, IPage
    {
        public string PageIdName => PAGE_ADD_NOTE_INDEX_NAME;

        public string PageTitle => PAGE_ADD_NOTE_TITLE;

        public string PageDescription => PAGE_ADD_NOTE_DESCRIPTION;

        public string PageGroup => PAGE_ADD_NOTE_GROUP;

        public override void InitializePage() {
            SetPageInfo();
            PanelAddNoteUC panelAddNoteUC = new PanelAddNoteUC();
            panelAddNoteUC.Dock = System.Windows.Forms.DockStyle.Fill;
            Controls.Add(panelAddNoteUC);
        }

        public override void SetPageInfo() {
            Name = PageIdName;
            Text = PageTitle;
            TextDescription = PageDescription;
            TextTitle = PageGroup;
        }

        public static PageAddNote Create() {
            PageAddNote pageAddNote = new PageAddNote();
            pageAddNote.InitializePage();
            return pageAddNote;
        }
    }
}
