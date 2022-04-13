using iSlavici.Controls.Nav.Pan;
using iSlavici.Controls.Spl;

namespace iSlavici.Controls.Nav.Spl
{
    internal class SplitterNoteList : BaseSplitter
    {
        public NoteUC noteUC { get; set; }
        public SplitterNoteList() {
            AddPanel2Component();
            AddPanel1Component();
            SplitterDistance = 75;
        }

        public override void AddPanel1Component() {
            PanelNoteListFiltersUC panelNoteListFiltersUC = new PanelNoteListFiltersUC();
            Panel1.Controls.Add(panelNoteListFiltersUC);
        }

        public override void AddPanel2Component() {
            noteUC = new NoteUC();
            Panel2.Controls.Add(noteUC);
        }
    }
}