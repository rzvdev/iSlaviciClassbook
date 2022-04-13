using System;
using System.Threading.Tasks;

namespace iSlavici.Controls.Spl
{
    public class SplitterUserList : BaseSplitter
    {
        public UserUC userUC { get; set; }

        public SplitterUserList() {
            AddPanel2Component();
        }

        public override void AddPanel1Component() {
            throw new NotImplementedException();
        }

        public override void AddPanel2Component() {
            userUC = new UserUC();
            Panel2.Controls.Add(userUC);

        }
    }
}
