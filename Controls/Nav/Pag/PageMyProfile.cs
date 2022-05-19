using iSlavici.Controls.Nav.Pan;
using iSlavici.Controls.Navigator.Pages;

namespace iSlavici.Controls.Nav.Pag
{
    public class PageMyProfile : BasePage, IPage
    {
        public string PageIdName => PAGE_MY_PROFILE_INDEX_NAME;

        public string PageTitle => PAGE_MY_PROFILE_TITLE;

        public string PageDescription => PAGE_MY_PROFILE_DESCRIPTION;

        public string PageGroup => PAGE_MY_PROFILE_GROUP;

        public override void InitializePage() {
            SetPageInfo();
            PanelMyProfileUC panelCreateCourseUC = new PanelMyProfileUC();
            panelCreateCourseUC.Dock = System.Windows.Forms.DockStyle.Fill;
            Controls.Add(panelCreateCourseUC);
        }

        public override void SetPageInfo() {
            Name = PageIdName;
            Text = PageTitle;
            TextDescription = PageDescription;
            TextTitle = PageGroup;
        }

        public static PageMyProfile Create() {
            PageMyProfile page = new PageMyProfile();
            page.InitializePage();
            return page;
        }

    }
}
