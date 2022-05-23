using iSlavici.Components.Nav.Pan;

namespace iSlavici.Controls.Spl
{
    public class SplitterUserList : BaseSplitter
    {
        public UserUC userUC { get; set; }
        public PanelUserListFiltersUC PanelUserList { get; set; }

        public SplitterUserList() {
            AddPanel2Component();
            AddPanel1Component();
        }

        public override void AddPanel1Component() {
            PanelUserList = new PanelUserListFiltersUC();
            PanelUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            Panel1.Controls.Add(PanelUserList);
        }

        public override void AddPanel2Component() {
            userUC = new UserUC();
            Panel2.Controls.Add(userUC);

        }
    }
}
