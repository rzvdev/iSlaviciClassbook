using classbook.Connection;
using ComponentFactory.Krypton.Navigator;
using iSlavici.Controls.Nav.Pag;
using iSlavici.Controls.Navigator.Pages;
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
        private static PageMyProfile pageMyProfile;
        private static PageMyCourses pageMyCourses;
        private static PageMyNotes pageMyNotes;

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
            if (DataAccess._loggedRole.Name == "ADMINISTRATOR") {
                pageUserList = PageUserList.Create();
                pageCreateUser = PageCreateUser.Create();
                pageCreateCourse = PageCreateCourse.Create();
                pageCourseList = PageCourseList.Create();
                pageNoteList = PageNoteList.Create();
                pageAddNote = PageAddNote.Create();
                pageAddNoteType = PageAddNoteType.Create();
                pageMyProfile = PageMyProfile.Create();
               

                Pages.Add(pageCreateUser);
                Pages.Add(pageUserList);
                Pages.Add(pageCreateCourse);
                Pages.Add(pageCourseList);
                Pages.Add(pageNoteList);
                Pages.Add(pageAddNote);
                Pages.Add(pageAddNoteType);
                Pages.Add(pageMyProfile);
            } else if(DataAccess._loggedRole.Name == "STUDENT") {
                pageMyProfile = PageMyProfile.Create();
                pageMyCourses = PageMyCourses.Create();
                pageMyNotes = PageMyNotes.Create();

                Pages.Add(pageMyProfile);
                Pages.Add(pageMyCourses);
                Pages.Add(pageMyNotes);
            }
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

            //ADMIN PAGES
            if (DataAccess._loggedRole.Name == "ADMINISTRATOR") {
                pages.Add(pageCreateCourse);
                pages.Add(pageUserList);
                pages.Add(pageCourseList);
                pages.Add(pageNoteList);
                pages.Add(pageCreateUser);
                pages.Add(pageAddNote);
                pages.Add(pageAddNoteType);

                //STUDENT & ADMIN PAGES
                pages.Add(pageMyProfile);

            } else if(DataAccess._loggedRole.Name == "STUDENT") {
                pages.Add(pageMyProfile);
                pages.Add(pageMyCourses);
                pages.Add(pageMyNotes);
            }

            return pages;
        }

        public new void HideAllPages() {
            foreach(var page in GetPages()) {
                page.Visible = false;
            }
        }

        public void SetNotesPageVisible(bool isStudent = false) {
            if (!isStudent) {
                if (pageNoteList != null) pageNoteList.Visible = true;
                if (pageAddNote != null) pageAddNote.Visible = true;
                if (pageAddNoteType != null) pageAddNoteType.Visible = true;
            } else {
                if (pageMyNotes != null) pageMyNotes.Visible = true;
            }

        }

        public void SetProfilesPageVisible() {
            if(pageCreateUser != null) pageCreateUser.Visible = true;
            if(pageUserList != null) pageUserList.Visible = true;
            if(pageMyProfile != null) pageMyProfile.Visible = true;
        }

        public void SetCoursesPageVisible(bool isStudent = false) {
            if (!isStudent) {
                if (pageCourseList != null) pageCourseList.Visible = true;
                if (pageCreateCourse != null) pageCreateCourse.Visible = true;
            } else {
                if (pageMyCourses != null) pageMyCourses.Visible = true;
            }
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

        public void RefreshStudentNoteDGVfiltred(IFiltrableNotes notes) {
            StudentNoteUC.StudentNoteDGV.FillTableFiltred((IFiltrable)notes);
        }
    }
}
