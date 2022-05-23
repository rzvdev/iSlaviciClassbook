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
        protected readonly string PAGE_USER_LIST_DESCRIPTION = "This is the page with registered users, where you can see the account information as well as the person's information. You can also delete and edit accounts.";
        protected readonly string PAGE_USER_LIST_GROUP = "Profiles";

        // CREATE USER PAGE
        protected readonly string PAGE_CREATE_USER_INDEX_NAME = "pagCreateUser";
        protected readonly string PAGE_CREATE_USER_TITLE = "CREATE USER";
        protected readonly string PAGE_CREATE_USER_DESCRIPTION = "This is the page where you can create user accounts. Follow the good practice of usernamers name_surname_date of birth like lungu_razvan_12121999";
        protected readonly string PAGE_CREATE_USER_GROUP = "Profiles";

        // EDIT USER PAGE
        protected readonly string PAGE_EDIT_USER_INDEX_NAME = "pagEditUser";
        protected readonly string PAGE_EDIT_USER_TITLE = "EDIT USER";
        protected readonly string PAGE_EDIT_USER_DESCRIPTION = "This is the page where you can edit the accounts and user information. ";
        protected readonly string PAGE_EDIT_USER_GROUP = "Profiles";

        // CREATE COURSE PAGE
        protected readonly string PAGE_CREATE_COURSE_INDEX_NAME = "pagCreateCourse";
        protected readonly string PAGE_CREATE_COURSE_TITLE = "CREATE COURSE";
        protected readonly string PAGE_CREATE_COURSE_DESCRIPTION = "This is the page where you can create courses. In order to give a note to a student we need the created course.";
        protected readonly string PAGE_CREATE_COURSE_GROUP = "Courses";

        // COURSE LIST PAGE
        protected readonly string PAGE_COURSE_LIST_INDEX_NAME = "pagCourseList";
        protected readonly string PAGE_COURSE_LIST_TITLE = "COURSE LIST";
        protected readonly string PAGE_COURSE_LIST_DESCRIPTION = "This is the page where you can see all the created courses of the university.";
        protected readonly string PAGE_COURSE_LIST_GROUP = "Courses";

        // ADD NOTE PAGE
        protected readonly string PAGE_ADD_NOTE_INDEX_NAME = "pagAddNote";
        protected readonly string PAGE_ADD_NOTE_TITLE = "ADD NOTE";
        protected readonly string PAGE_ADD_NOTE_DESCRIPTION = "This is the page where we can give grades to students, for this we need the course created and the type of grade example Presentation1, Presentation2, Activity ..";
        protected readonly string PAGE_ADD_NOTE_GROUP = "Notes";

        // NOTE LIST PAGE
        protected readonly string PAGE_NOTE_LIST_INDEX_NAME = "pagNoteList";
        protected readonly string PAGE_NOTE_LIST_TITLE = "NOTE LIST";
        protected readonly string PAGE_NOTE_LIST_DESCRIPTION = "This is the page with all the students' notes.";
        protected readonly string PAGE_NOTE_LIST_GROUP = "Notes";

        // ADD NOTE TYPE PAGE
        protected readonly string PAGE_NOTE_TYPE_INDEX_NAME = "pagNoteType";
        protected readonly string PAGE_NOTE_TYPE_TITLE = "NOTE TYPES";
        protected readonly string PAGE_NOTE_TYPE_DESCRIPTION = "This is the page where we can create note types, for example Presentation1, Presentation2, Activity.";
        protected readonly string PAGE_NOTE_TYPE_GROUP = "Notes";

        // MY PROFILE PAGE
        protected readonly string PAGE_MY_PROFILE_INDEX_NAME = "pagMyProfile";
        protected readonly string PAGE_MY_PROFILE_TITLE = "MY PROFILE";
        protected readonly string PAGE_MY_PROFILE_DESCRIPTION = "This is the page where you can see your user profile which contains some of your information.";
        protected readonly string PAGE_MY_PROFILE_GROUP = "Profile";

        // MY COURSES PAGE
        protected readonly string PAGE_MY_COURSES_INDEX_NAME = "pagMyCourses";
        protected readonly string PAGE_MY_COURSES_TITLE = "MY COURSES";
        protected readonly string PAGE_MY_COURSES_DESCRIPTION = "This is the page where you see the courses you have attended and are currently enrolled in. You cannot see the courses you will have.";
        protected readonly string PAGE_MY_COURSES_GROUP = "Course";

        // MY NOTES PAGE
        protected readonly string PAGE_MY_NOTES_INDEX_NAME = "pagMyNotes";
        protected readonly string PAGE_MY_NOTES_TITLE = "MY NOTES";
        protected readonly string PAGE_MY_NOTES_DESCRIPTION = "This is the page where you see the notes you received.";
        protected readonly string PAGE_MY_NOTES_GROUP = "Note";


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
