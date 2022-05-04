using ComponentFactory.Krypton.Navigator;
using iSlavici.Connection.Models.db;
using iSlavici.Controls.Nav.Pag;
using iSlavici.Controls.Navigator.Pages;
using iSlavici.Models;
using System.Collections.Generic;

namespace iSlavici.Controls.Navigator
{
    public class Navigator : KryptonNavigator
    {
        private static Navigator instance = null;


        /// <summary>
        /// PAGES
        /// </summary>
        private static PageUserList pageUserList;
        private static PageCreateUser pageCreateUser;
        private static PageEditUser pageEditUser;
        private static PageCreateCourse pageCreateCourse;
        private static PageCourseList pageCourseList;
        private static PageNoteList pageNoteList;
        private static PageAddNote pageAddNote;
        private static PageAddNoteType pageAddNoteType;

        private Navigator() {

        }

        public static Navigator GetInstance() {

            if (instance == null) {
                instance = new Navigator();
                instance.SetSettings();
                instance.InitializePages();
            }
            return instance;
        }

        private void SetSettings() {
            Bar.ItemOrientation = ComponentFactory.Krypton.Toolkit.ButtonOrientation.FixedTop;
            Button.ButtonDisplayLogic = ButtonDisplayLogic.None;
            Button.CloseButtonAction = CloseButtonAction.HidePage;
            Button.CloseButtonDisplay = ButtonDisplay.ShowEnabled;
            Dock = System.Windows.Forms.DockStyle.Fill;
            Group.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ButtonStandalone;
            Header.HeaderStyleBar = ComponentFactory.Krypton.Toolkit.HeaderStyle.Primary;
            Location = new System.Drawing.Point(0, 0);
            Name = "navigator";
            NavigatorMode = NavigatorMode.HeaderGroupTab;
            PageBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.TabLowProfile;
            Size = new System.Drawing.Size(708, 455);
            TabIndex = 0;
            Visible = true;
        }

        private void InitializePages() {
            pageUserList = PageUserList.Create();
            pageCreateUser = PageCreateUser.Create();
            pageCreateCourse = PageCreateCourse.Create();
            pageCourseList = PageCourseList.Create();
            pageNoteList = PageNoteList.Create();
            pageAddNote = PageAddNote.Create();
            pageAddNoteType = PageAddNoteType.Create();

            Pages.Add(pageCreateUser);
            Pages.Add(pageUserList);
            Pages.Add(pageCreateCourse);
            Pages.Add(pageCourseList);
            Pages.Add(pageNoteList);
            Pages.Add(pageAddNote);
            Pages.Add(pageAddNoteType);
        }
        public void SelectEditUserPage(int id,string username, string password, string fullname, string email, string cnp, string phone, string role, string profile, int year) {
            pageEditUser = PageEditUser.Create();
            Pages.Add(pageEditUser);

            pageEditUser.InitializePage(id,username, password, fullname, email, cnp, phone, role, profile, year);
            pageEditUser.Visible = true;
            SelectedPage = pageEditUser;
        }

        private void AddPage(BasePage page) {
            Pages.Add(page);
        }

        private List<BasePage> GetPages() {
            List<BasePage> pages = new List<BasePage>();
            pages.Add(pageCreateCourse);
            pages.Add(pageUserList);
            pages.Add(pageCourseList);
            pages.Add(pageNoteList);
            pages.Add(pageCreateUser);
            pages.Add(pageAddNote);
            pages.Add(pageAddNoteType);

            return pages;
        }

        public new void HideAllPages() {
            foreach(var page in GetPages()) {
                page.Visible = false;
            }
        }

        public void SetNotesPageVisible() {
            pageNoteList.Visible = true;
            pageAddNote.Visible = true;
            pageAddNoteType.Visible = true;
        }

        public void SetProfilesPageVisible() {
            pageCreateUser.Visible = true;
            pageUserList.Visible = true;
        }

        public void SetCoursesPageVisible() {
            pageCourseList.Visible = true;
            pageCreateCourse.Visible = true;
        }

        public void SetEditUserPageHiden() {
            pageEditUser.Visible = false;
        }

        public void SelectUserListPage() {
            SelectedPage = pageUserList;
        }

        public PageUserList GetPageUserList() {
            return pageUserList;
        }
        public PageCourseList GetPageCourseList() {
            return pageCourseList;
        }

        public void RefreshPageNoteList() {
            pageNoteList.splitter.noteUC.noteDGV.RefreshData();
        }
        public void RefreshNoteTypesDGV() {
            pageAddNoteType.splitter.noteTypeUC.noteTypeDGV.RefreshData();
        }

        public void RefreshNoteDGVfiltred(IFiltrableNotes notes) {
            pageNoteList.splitter.noteUC.noteDGV.FillTableFiltred((IFiltrable)notes);
        }
    }
}
