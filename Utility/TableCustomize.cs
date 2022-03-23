using iSlavici.Models;
using System.Drawing;
using System.Windows.Forms;

namespace iSlavici.Utility
{
    public class TableCustomize
    {
        public DataGridView Dgv { get; set; }
        public TableType Type { get; set; }

        public TableCustomize(DataGridView dgv, TableType type)
        {
            Dgv = dgv;
            Type = type;
        }

        public void AddButtons()
        {
            DGVimageButtonDeleteColumn deleteBtn = new DGVimageButtonDeleteColumn
            {
                HeaderText = "",
                Width = 20,
                Text = "Delete this user",
                Tag = "dgvDeleteBtn"
            };


            DGVimageButtonEditColumn editBtn = new DGVimageButtonEditColumn()
            {
                HeaderText = "",
                Width = 20,
                Text = "Edit this user",
                Tag = "dgvEditBtn"
            };


            /// This collides re-adding these buttons
            //foreach (DataGridViewColumn column in Dgv.Columns)
            //{
            //    if (column.Tag == deleteBtn.Tag || column.Tag == editBtn.Tag)
            //    {
            //        return;
            //    }
            //}


            for(int i = 0; i < Dgv.Columns.Count; i++)
            {
                DataGridViewColumn col = Dgv.Columns[i];
                if(col.Tag == deleteBtn.Tag || col.Tag == editBtn.Tag)
                {
                    Dgv.Columns.RemoveAt(i);
                }
            }

            switch (Type)
            {
                case TableType.UserTable:
                    Dgv.Columns.Add(deleteBtn);
                    Dgv.Columns.Add(editBtn);
                    break;
                case TableType.CourseTable:
                    Dgv.Columns.Add(deleteBtn);
                    break;
                case TableType.NoteTable:
                    Dgv.Columns.Add(editBtn);
                    break;
            }
        }

        public void CustomizeTable()
        {
            Dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(50, 58, 68);
            Dgv.ColumnHeadersHeight = 30;
            Dgv.RowHeadersVisible = false;
            Dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;

            foreach (DataGridViewColumn col in Dgv.Columns)
            {
                col.DefaultCellStyle.Font = new Font("Tahoma", 11f, FontStyle.Regular);
            }

       

            switch (Type)
            {
                case TableType.UserTable:
                    // DELETE
                    Dgv.Columns[0].Width = 20;

                    // EDIT
                    Dgv.Columns[1].Width = 20;

                    // ID
                    Dgv.Columns[2].Width = 50;

                    // USERNAME
                    Dgv.Columns[3].Width = 150;

                    // FULLNAME
                    Dgv.Columns[4].Width = 200;

                    // CNP
                    Dgv.Columns[5].Width = 200;

                    // ROLE
                    Dgv.Columns[6].Width = 100;

                    // EMAIL
                    Dgv.Columns[7].Width = 250;

                    // PHONE
                    Dgv.Columns[8].Width = 200;

                    // PROFILE
                    Dgv.Columns[9].Width = 150;

                    // YEAR
                    Dgv.Columns[10].Width = 50;

                    // CREATEDDATE
                    Dgv.Columns[11].Width = 200;
                    Dgv.Columns[11].HeaderText = "Date Created";

                    break;

                case TableType.CourseTable:
                    // DELETE
                    Dgv.Columns[0].Width = 20;

                    // ID
                    Dgv.Columns[1].Width = 60;

                    // Name
                    Dgv.Columns[2].Width = 300;

                    // Abvr
                    Dgv.Columns[3].Width = 80;
                    Dgv.Columns[3].HeaderText = "Abrv";

                    // Teacher Name
                    Dgv.Columns[4].Width = 250;

                    // Profile Name
                    Dgv.Columns[5].Width = 200;

                    // Subject Type
                    Dgv.Columns[6].Width = 150;

                    // Examination Mode
                    Dgv.Columns[7].Width = 150;
                    Dgv.Columns[7].HeaderText = "Examination";

                    // Credit
                    Dgv.Columns[8].Width = 80;

                    // Year
                    Dgv.Columns[9].Width = 80;

                    // Semester
                    Dgv.Columns[10].Width = 80;

                    break;

                case TableType.NoteTable:
                    //ID
                    Dgv.Columns[0].Width = 50;
                    Dgv.Columns[0].HeaderText = "ID";

                    // Student Name
                    Dgv.Columns[1].Width = 200;
                    Dgv.Columns[1].HeaderText = "Student";

                    // Subject Name
                    Dgv.Columns[2].Width = 200;
                    Dgv.Columns[2].HeaderText = "Course";

                    // Abrv
                    Dgv.Columns[3].Width = 80;
                    Dgv.Columns[3].HeaderText = "Abrv";

                    // Teacher Name
                    Dgv.Columns[4].Width = 200;
                    Dgv.Columns[4].HeaderText = "Teacher";

                    // Note Type
                    Dgv.Columns[5].Width = 200;
                    Dgv.Columns[5].HeaderText = "Type";

                    // Note Value
                    Dgv.Columns[6].Width = 50;
                    Dgv.Columns[6].HeaderText = "Note";

                    // Added Date
                    Dgv.Columns[7].Width = 100;
                    Dgv.Columns[7].HeaderText = "Date Added";

                    break;

                case TableType.NoteOnlyOneStudentTable:
                    // Course Name
                    Dgv.Columns[0].Width = 250;
                    Dgv.Columns[0].HeaderText = "Course";

                    // Abvr 
                    Dgv.Columns[1].Width = 100;
                    Dgv.Columns[1].HeaderText = "Abvr";

                    // Teacher Name
                    Dgv.Columns[2].Width = 200;
                    Dgv.Columns[2].HeaderText = "Teacher";

                    // Note type
                    Dgv.Columns[3].Width = 150;
                    Dgv.Columns[3].HeaderText = "Note Type";

                    // Note
                    Dgv.Columns[4].Width = 50;
                    Dgv.Columns[4].HeaderText = "Note";

                    // Added Date
                    Dgv.Columns[5].Width = 100;
                    Dgv.Columns[5].HeaderText = "Date Added";
                    break;

            }
            Dgv.Refresh();
        }
    }
}
