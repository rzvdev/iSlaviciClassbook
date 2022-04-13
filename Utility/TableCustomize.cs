using iSlavici.Models;
using System.Drawing;
using System.Windows.Forms;

namespace iSlavici.Utility
{
    public class TableCustomize
    {
        /// <summary>
        /// DGVCS1 - FIRST ROW CELLS
        /// </summary>
        private readonly Font CELL_FONT_STYLE = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        private readonly Color CELL_BACK_COLOR = Color.Gainsboro;
        private readonly Color CELL_FORE_COLOR = Color.Black;
        private readonly Color CELL_SELECTION_BACK_COLOR = Color.FromArgb(125,141,161);
        private readonly Color CELL_SELECTION_FORE_COLOR = Color.WhiteSmoke;
        private readonly DataGridViewContentAlignment CELL_CONTENT_ALIGN = DataGridViewContentAlignment.MiddleCenter;

        /// <summary>
        /// DGVCS2 - HEADER CELLS
        /// </summary>
        private readonly DataGridViewContentAlignment CELL_HEADER_CONTENT_ALIGN = DataGridViewContentAlignment.TopCenter;
        private readonly Color CELL_HEADER_BACK_COLOR = Color.FromArgb(50,62,68);
        private readonly Color CELL_HEADER_FORE_COLOR = Color.FromArgb(213,242,242);
        private readonly Color CELL_HEADER_SELECTION_BACK_COLOR = SystemColors.Highlight;
        private readonly Font CELL_HEADER_FONT_STYLE = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        private readonly Color CELL_HEADER_SELECTION_FORE_COLOR = SystemColors.HighlightText;
        private readonly Padding CELL_HEADER_PADDING = new Padding(5, 0, 0, 0);
        private readonly DataGridViewTriState CELL_HEADER_TRISTATE = DataGridViewTriState.True;

        public DataGridView Dgv { get; set; }
        public TableType Type { get; set; }

        private DataGridViewCellStyle dgvcs1;
        private DataGridViewCellStyle dgvcs2;
        private DataGridViewCellStyle dgvcs3;
        private DataGridViewCellStyle dgvcs4;
        private DataGridViewCellStyle dgvcs5;


        public TableCustomize(DataGridView dgv, TableType type)
        {
            InitializeStyles();
            Dgv = SetTableSetting(dgv);
            Type = type;
        }



        private DataGridView SetTableSetting(DataGridView dgv)
        {
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.AlternatingRowsDefaultCellStyle = dgvcs1;
            dgv.BackgroundColor = SystemColors.ActiveCaption;
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle = dgvcs2;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.DefaultCellStyle = dgvcs3;
            dgv.Dock = DockStyle.Fill;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ReadOnly = true;
            dgv.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.RowHeadersDefaultCellStyle = dgvcs4;
            dgv.RowHeadersWidth = 40;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.RowsDefaultCellStyle = dgvcs5;
            dgv.RowTemplate.Resizable = DataGridViewTriState.False;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            return dgv;
        }

        private void InitializeStyles()
        {
            dgvcs1 = new DataGridViewCellStyle
            {
                Alignment = CELL_CONTENT_ALIGN,
                BackColor = CELL_BACK_COLOR,
                Font = CELL_FONT_STYLE,
                ForeColor = CELL_FORE_COLOR,
                SelectionBackColor = CELL_SELECTION_BACK_COLOR,
                SelectionForeColor = CELL_SELECTION_FORE_COLOR
            };

            dgvcs2 = new DataGridViewCellStyle()
            {
                Alignment = CELL_HEADER_CONTENT_ALIGN,
                BackColor = CELL_HEADER_BACK_COLOR,
                Font = CELL_HEADER_FONT_STYLE,
                ForeColor = CELL_HEADER_FORE_COLOR,
                Padding = CELL_HEADER_PADDING,
                SelectionBackColor = CELL_HEADER_SELECTION_BACK_COLOR,
                SelectionForeColor = CELL_HEADER_SELECTION_FORE_COLOR,
                WrapMode = CELL_HEADER_TRISTATE
            };

            dgvcs3 = new DataGridViewCellStyle()
            {
                Alignment = CELL_CONTENT_ALIGN,
                BackColor = Color.WhiteSmoke,
                ForeColor = CELL_FORE_COLOR,
                SelectionBackColor = CELL_SELECTION_BACK_COLOR,
                SelectionForeColor = CELL_SELECTION_FORE_COLOR,
                Font = CELL_FONT_STYLE,
                WrapMode = DataGridViewTriState.False
            };

            dgvcs4 = new DataGridViewCellStyle()
            {
                Alignment = CELL_CONTENT_ALIGN,
                BackColor = CELL_BACK_COLOR,
                ForeColor = CELL_FORE_COLOR,
                SelectionBackColor = CELL_SELECTION_BACK_COLOR,
                SelectionForeColor = CELL_SELECTION_FORE_COLOR,
                Font = CELL_FONT_STYLE,
                WrapMode = DataGridViewTriState.True
            };

            dgvcs5 = new DataGridViewCellStyle()
            {
                Alignment = CELL_CONTENT_ALIGN
            };
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
            foreach (DataGridViewColumn column in Dgv.Columns)
            {
                if (column.Tag == deleteBtn.Tag || column.Tag == editBtn.Tag)
                {
                    return;
                }
            }


            for (int i = 0; i < Dgv.Columns.Count; i++)
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

        public void MakeColumns()
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
                    Dgv.Columns[1].Width = 250;
                    Dgv.Columns[1].HeaderText = "Student";

                    // Subject Name
                    Dgv.Columns[2].Width = 300;
                    Dgv.Columns[2].HeaderText = "Course";

                    // Abrv
                    Dgv.Columns[3].Width = 80;
                    Dgv.Columns[3].HeaderText = "Abrv";

                    // Teacher Name
                    Dgv.Columns[4].Width = 250;
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
                    Dgv.Columns[0].Width = 300;
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
