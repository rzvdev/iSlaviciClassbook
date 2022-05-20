using ComponentFactory.Krypton.Toolkit;

namespace iSlavici.Controls.Spl
{
    public abstract class BaseSplitter : KryptonSplitContainer
    {

        public BaseSplitter() {
            SetSplitterSettings();
        }

        public abstract void AddPanel1Component();
        public abstract void AddPanel2Component();

        private void SetSplitterSettings() {
            Cursor = System.Windows.Forms.Cursors.Default;
            Dock = System.Windows.Forms.DockStyle.Fill;
            IsSplitterFixed = true;
            Location = new System.Drawing.Point(0, 0);
            Orientation = System.Windows.Forms.Orientation.Horizontal;
            Size = new System.Drawing.Size(704, 375);
            SplitterDistance = 75;

            if(this is SplitterNoteType) {
                Orientation = System.Windows.Forms.Orientation.Vertical;
                SplitterDistance = 350;
            }
        }
    }
}
