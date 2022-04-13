using ComponentFactory.Krypton.Navigator;

namespace iSlavici.Controls.Navigator.Pages
{
    public abstract class BasePage : KryptonPage
    {
        /// <summary>
        /// PAGE INFORMATION CONSTANTS
        /// </summary>
        // USER LIST PAGE
        protected readonly string PAGE_USER_LIST_INDEX_NAME = "pagUserList";
        protected readonly string PAGE_USER_LIST_TITLE = "USER LIST";
        protected readonly string PAGE_USER_LIST_DESCRIPTION = "This is a user list";
        protected readonly string PAGE_USER_LIST_GROUP = "Profiles";

        // CREATE USER PAGE
        protected readonly string PAGE_CREATE_USER_INDEX_NAME = "pagCreateUser";
        protected readonly string PAGE_CREATE_USER_TITLE = "CREATE USER";
        protected readonly string PAGE_CREATE_USER_DESCRIPTION = "This is for creating users";
        protected readonly string PAGE_CREATE_USER_GROUP = "Profiles";

        // EDIT USER PAGE
        protected readonly string PAGE_EDIT_USER_INDEX_NAME = "pagEditUser";
        protected readonly string PAGE_EDIT_USER_TITLE = "EDIT USER";
        protected readonly string PAGE_EDIT_USER_DESCRIPTION = "This is for editing users";
        protected readonly string PAGE_EDIT_USER_GROUP = "Profiles";

        // CREATE COURSE PAGE
        protected readonly string PAGE_CREATE_COURSE_INDEX_NAME = "pagCreateCourse";
        protected readonly string PAGE_CREATE_COURSE_TITLE = "CREATE COURSE";
        protected readonly string PAGE_CREATE_COURSE_DESCRIPTION = "This is for creating courses";
        protected readonly string PAGE_CREATE_COURSE_GROUP = "Courses";

        // COURSE LIST PAGE
        protected readonly string PAGE_COURSE_LIST_INDEX_NAME = "pagCourseList";
        protected readonly string PAGE_COURSE_LIST_TITLE = "COURSE LIST";
        protected readonly string PAGE_COURSE_LIST_DESCRIPTION = "This is a course list";
        protected readonly string PAGE_COURSE_LIST_GROUP = "Courses";

        // ADD NOTE PAGE
        protected readonly string PAGE_ADD_NOTE_INDEX_NAME = "pagAddNote";
        protected readonly string PAGE_ADD_NOTE_TITLE = "ADD NOTE";
        protected readonly string PAGE_ADD_NOTE_DESCRIPTION = "This is for adding notes";
        protected readonly string PAGE_ADD_NOTE_GROUP = "Notes";

        // NOTE LIST PAGE
        protected readonly string PAGE_NOTE_LIST_INDEX_NAME = "pagNoteList";
        protected readonly string PAGE_NOTE_LIST_TITLE = "NOTE LIST";
        protected readonly string PAGE_NOTE_LIST_DESCRIPTION = "This is a notes list";
        protected readonly string PAGE_NOTE_LIST_GROUP = "Notes";

        // ADD NOTE TYPE PAGE
        protected readonly string PAGE_NOTE_TYPE_INDEX_NAME = "pagNoteType";
        protected readonly string PAGE_NOTE_TYPE_TITLE = "NOTE TYPES";
        protected readonly string PAGE_NOTE_TYPE_DESCRIPTION = "This is a note types list";
        protected readonly string PAGE_NOTE_TYPE_GROUP = "Notes";

        public BasePage() {
            SetPageSettings(this);
        }

        public abstract void InitializePage();
        public abstract void SetPageInfo();

        protected void SetPageSettings(KryptonPage page) {
            page.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            page.LastVisibleSet = true;
            page.MinimumSize = new System.Drawing.Size(50, 50);
            page.Size = new System.Drawing.Size(704, 375);
            page.Visible = true;
        }
    }
}
