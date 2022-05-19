using iSlavici.Controls.Nav.Pan;
using iSlavici.Controls.Navigator.Pages;


namespace iSlavici.Controls.Nav.Pag
{
    public class PageCreateUser : BasePage,IPage
    {
        public string PageIdName => PAGE_CREATE_USER_INDEX_NAME;

        public string PageTitle => PAGE_CREATE_USER_TITLE;

        public string PageDescription => PAGE_CREATE_USER_DESCRIPTION;

        public string PageGroup => PAGE_CREATE_USER_GROUP;

        public override void InitializePage() {
            SetPageInfo();
            PanelCreateUserUC panelCreateUserUC = new PanelCreateUserUC();
            panelCreateUserUC.Dock = System.Windows.Forms.DockStyle.Fill;
            Controls.Add(panelCreateUserUC);
        }

        public override void SetPageInfo() {
            Name = PageIdName;
            Text = PageTitle;
            TextDescription = PageDescription;
            TextTitle = PageGroup;
        }

        public static PageCreateUser Create() {
            PageCreateUser pageCreateUser = new PageCreateUser();
            pageCreateUser.InitializePage();
            return pageCreateUser;
        }
        
    }
}
