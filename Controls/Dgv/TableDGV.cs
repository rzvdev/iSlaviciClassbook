using iSlavici.Controls;
using iSlavici.Controls.Dgv;
using iSlavici.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace iSlavici.Models
{
    public abstract class TableDGV : DataGridView
    {
        /// <summary>
        /// DGVCS1 - FIRST ROW CELLS
        /// </summary>
        private readonly Font CELL_FONT_STYLE = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        private readonly Color CELL_BACK_COLOR = Color.Gainsboro;
        private readonly Color CELL_FORE_COLOR = Color.Black;
        private readonly Color CELL_SELECTION_BACK_COLOR = Color.FromArgb(125, 141, 161);
        private readonly Color CELL_SELECTION_FORE_COLOR = Color.WhiteSmoke;
        private readonly DataGridViewContentAlignment CELL_CONTENT_ALIGN = DataGridViewContentAlignment.MiddleCenter;

        /// <summary>
        /// DGVCS2 - HEADER CELLS
        /// </summary>
        private readonly DataGridViewContentAlignment CELL_HEADER_CONTENT_ALIGN = DataGridViewContentAlignment.TopCenter;
        private readonly Color CELL_HEADER_BACK_COLOR = Color.FromArgb(50, 62, 68);
        private readonly Color CELL_HEADER_FORE_COLOR = Color.FromArgb(213, 242, 242);
        private readonly Color CELL_HEADER_SELECTION_BACK_COLOR = SystemColors.Highlight;
        private readonly Font CELL_HEADER_FONT_STYLE = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        private readonly Color CELL_HEADER_SELECTION_FORE_COLOR = SystemColors.HighlightText;
        private readonly Padding CELL_HEADER_PADDING = new Padding(5, 0, 0, 0);
        private readonly DataGridViewTriState CELL_HEADER_TRISTATE = DataGridViewTriState.True;

        /// <summary>
        /// BUTTONS IMAGES
        /// </summary>
        private readonly Image btnEditImg = Resources.dgvUserListEditBtn_24px;
        private readonly Image btnDeleteImg = Resources.dgvUserListDeleteBtn_24px;

        private DataGridViewCellStyle dgvcs1;
        private DataGridViewCellStyle dgvcs2;
        private DataGridViewCellStyle dgvcs3;
        private DataGridViewCellStyle dgvcs4;
        private DataGridViewCellStyle dgvcs5;

        public TableDGV() {
            SetTableSettings(this);
            SetStyleSettings();
        }

        public abstract void InitializeTable();
        public abstract void AddColumns();
        public abstract void FillTable();
        public abstract void LoadData();
        public abstract void RefreshData();

        public abstract void FillTableFiltred(IFiltrable filtred);


        protected void SetTableSettings(TableDGV tbl) {
            tbl.AllowUserToAddRows = false;
            tbl.AllowUserToDeleteRows = false;
            tbl.AllowUserToResizeRows = false;
            tbl.AlternatingRowsDefaultCellStyle = dgvcs1;
            tbl.BackgroundColor = SystemColors.ActiveCaption;
            tbl.BorderStyle = BorderStyle.None;
            tbl.CellBorderStyle = DataGridViewCellBorderStyle.None;
            tbl.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tbl.ColumnHeadersDefaultCellStyle = dgvcs2;
            tbl.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl.DefaultCellStyle = dgvcs3;
            tbl.Dock = DockStyle.Fill;
            tbl.EnableHeadersVisualStyles = false;
            tbl.ReadOnly = true;
            tbl.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            tbl.RowHeadersDefaultCellStyle = dgvcs4;
            tbl.RowHeadersWidth = 40;
            tbl.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            tbl.RowsDefaultCellStyle = dgvcs5;
            tbl.RowTemplate.Resizable = DataGridViewTriState.False;
            tbl.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            tbl.RowHeadersVisible = false;
            tbl.AutoGenerateColumns = true;
            tbl.ColumnHeadersHeight = 29;
            tbl.Location = new Point(0, 0);
            tbl.Margin = new Padding(0);
            tbl.DoubleBuffered = true;
            tbl.RowHeadersWidth = 51;
            tbl.Visible = true;
            tbl.Size = new Size(2000, 2000);
            tbl.CellPainting += CustomizeButtons;
        }

        private void PaintDeleteButton(DataGridViewCellPaintingEventArgs e) {
            int x, y, w, h;

            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            w = btnDeleteImg.Width;
            h = btnDeleteImg.Height;
            x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

            e.Graphics.DrawImage(btnDeleteImg, new Rectangle(x, y, w, h));
            e.Handled = true;
        }
        private void PaintEditButton(DataGridViewCellPaintingEventArgs e) {
            int x, y, w, h;

            e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            w = btnEditImg.Width;
            h = btnEditImg.Height;
            x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

            e.Graphics.DrawImage(btnEditImg, new Rectangle(x, y, w, h));
            e.Handled = true;
        }

        private void CustomizeButtons(object sender, DataGridViewCellPaintingEventArgs e) {
            if (e.RowIndex < 0)
                return;

            if (sender is UserDGV) {
                // DELETE BUTTON
                if (e.ColumnIndex == 11) {
                    PaintDeleteButton(e);
                }
                // EDIT BUTTON
                if (e.ColumnIndex == 12) {
                    PaintEditButton(e);
                }
            } else if (sender is CourseDGV) {
                // DELETE BUTTON
                if (e.ColumnIndex == 10) {
                    PaintDeleteButton(e);
                }
            } else if (sender is NoteTypeDGV) {
                // DELETE BUTTON
                if (e.ColumnIndex == 2) {
                    PaintDeleteButton(e);
                }
            }

        }

        private void SetStyleSettings() {
            dgvcs1 = new DataGridViewCellStyle {
                Alignment = CELL_CONTENT_ALIGN,
                BackColor = CELL_BACK_COLOR,
                Font = CELL_FONT_STYLE,
                ForeColor = CELL_FORE_COLOR,
                SelectionBackColor = CELL_SELECTION_BACK_COLOR,
                SelectionForeColor = CELL_SELECTION_FORE_COLOR
            };

            dgvcs2 = new DataGridViewCellStyle() {
                Alignment = CELL_HEADER_CONTENT_ALIGN,
                BackColor = CELL_HEADER_BACK_COLOR,
                Font = CELL_HEADER_FONT_STYLE,
                ForeColor = CELL_HEADER_FORE_COLOR,
                Padding = CELL_HEADER_PADDING,
                SelectionBackColor = CELL_HEADER_SELECTION_BACK_COLOR,
                SelectionForeColor = CELL_HEADER_SELECTION_FORE_COLOR,
                WrapMode = CELL_HEADER_TRISTATE
            };

            dgvcs3 = new DataGridViewCellStyle() {
                Alignment = CELL_CONTENT_ALIGN,
                BackColor = Color.WhiteSmoke,
                ForeColor = CELL_FORE_COLOR,
                SelectionBackColor = CELL_SELECTION_BACK_COLOR,
                SelectionForeColor = CELL_SELECTION_FORE_COLOR,
                Font = CELL_FONT_STYLE,
                WrapMode = DataGridViewTriState.False
            };

            dgvcs4 = new DataGridViewCellStyle() {
                Alignment = CELL_CONTENT_ALIGN,
                BackColor = CELL_BACK_COLOR,
                ForeColor = CELL_FORE_COLOR,
                SelectionBackColor = CELL_SELECTION_BACK_COLOR,
                SelectionForeColor = CELL_SELECTION_FORE_COLOR,
                Font = CELL_FONT_STYLE,
                WrapMode = DataGridViewTriState.True
            };

            dgvcs5 = new DataGridViewCellStyle() {
                Alignment = CELL_CONTENT_ALIGN
            };
        }
    }
}
