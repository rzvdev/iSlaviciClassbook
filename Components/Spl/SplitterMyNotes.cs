using iSlavici.Components.Nav.Pan;
using System;

namespace iSlavici.Controls.Spl
{
    public class SplitterMyNotes : BaseSplitter
    {
        public MyNotesUC MyNotesUC { get; set; }
        public PanelMyNotesListFiltersUC PanelNoteListFiltred { get; set; }

        public SplitterMyNotes() {
            AddPanel2Component();
            AddPanel1Component();
        }

        public override void AddPanel1Component() {
            PanelNoteListFiltred = new PanelMyNotesListFiltersUC();
            Panel1.Controls.Add(PanelNoteListFiltred);
        }

        public override void AddPanel2Component() {
            MyNotesUC = new MyNotesUC();
            Panel2.Controls.Add(MyNotesUC);
        }
    }
}
