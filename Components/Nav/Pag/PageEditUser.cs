using iSlavici.Controls.Nav.Pan;
using iSlavici.Controls.Navigator.Pages;

namespace iSlavici.Controls.Nav.Pag
{
    internal class PageEditUser : BasePage,IPage
    {
        public string PageIdName => PAGE_EDIT_USER_INDEX_NAME;

        public string PageTitle => PAGE_EDIT_USER_TITLE;

        public string PageDescription => PAGE_EDIT_USER_DESCRIPTION;

        public string PageGroup => PAGE_EDIT_USER_GROUP;

        public void InitializePage(int id,string username, string password, string fullname, string email, string cnp, string phone, string role, string profile, int year) {
            PanelEditUserUC panelEditUserUC = new PanelEditUserUC(id,username,password,fullname,email, cnp,phone,role, profile,year);
            panelEditUserUC.Dock = System.Windows.Forms.DockStyle.Fill;
            Controls.Add(panelEditUserUC);
        }
        
        public override void SetPageInfo() {
            Name = PageIdName;
            Text = PageTitle;
            TextDescription = PageDescription;
            TextTitle = PageGroup;
        }
        public static PageEditUser Create() {
            PageEditUser pageEditUser = new PageEditUser();
            pageEditUser.InitializePage();
            return pageEditUser;
        }

        public override void InitializePage() {
            Visible = false;
            SetPageInfo();
        }
    }
}
