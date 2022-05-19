using iSlavici.Controls.Nav.Pag;
using iSlavici.Controls.Nav.Pan;

namespace iSlavici.Controls.Spl
{
    public class SplitterNoteType : BaseSplitter
    {
        public NoteTypeUC noteTypeUC { get; set; }
        public SplitterNoteType() {
            AddPanel1Component();
            AddPanel2Component();
        }   

        public override void AddPanel1Component() {
            PanelAddNoteTypeUC addNoteType = new PanelAddNoteTypeUC();
            Panel1.Controls.Add(addNoteType);
        }

        public override void AddPanel2Component() {
            noteTypeUC = new NoteTypeUC();
            Panel2.Controls.Add(noteTypeUC);
        }
    }
}
