using System;

namespace iSlavici.Controls.Spl
{
    public class SplitterMyNotes : BaseSplitter
    {
        public MyNotesUC MyNotesUC { get; set; }

        public SplitterMyNotes() {
            AddPanel2Component();
        }

        public override void AddPanel1Component() {
            throw new NotImplementedException();
        }

        public override void AddPanel2Component() {
            MyNotesUC = new MyNotesUC();
            Panel2.Controls.Add(MyNotesUC);
        }
    }
}
