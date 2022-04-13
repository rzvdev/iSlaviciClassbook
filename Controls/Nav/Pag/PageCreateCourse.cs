using iSlavici.Controls.Nav.Pan;
using iSlavici.Controls.Navigator.Pages;
using System;

namespace iSlavici.Controls.Nav.Pag
{
    public class PageCreateCourse : BasePage,IPage
    {
        public string PageIdName => PAGE_CREATE_COURSE_INDEX_NAME;

        public string PageTitle => PAGE_CREATE_COURSE_TITLE;

        public string PageDescription => PAGE_CREATE_COURSE_DESCRIPTION;

        public string PageGroup => PAGE_CREATE_COURSE_GROUP;

        public override void InitializePage() {
            SetPageInfo();
            PanelCreateCourseUC panelCreateCourseUC = new PanelCreateCourseUC();
            panelCreateCourseUC.Dock = System.Windows.Forms.DockStyle.Fill;
            Controls.Add(panelCreateCourseUC);
        }

        public override void SetPageInfo() {
            Name = PageIdName;
            Text = PageTitle;
            TextDescription = PageDescription;
            TextTitle = PageGroup;
        }

        public static PageCreateCourse Create() {
            PageCreateCourse pageCreateCourse = new PageCreateCourse();
            pageCreateCourse.InitializePage();
            return pageCreateCourse;
        }
    }
}
