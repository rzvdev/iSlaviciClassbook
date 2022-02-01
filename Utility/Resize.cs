using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace classbook.Utility
{
    public class Resize
    {
        /// <summary>
        /// Represents the instance of the form
        /// </summary>
        private Form Form { get; set; }

        /// <summary>
        /// Represents the form size
        /// </summary>
        private SizeF FormSize { get; set; }

        /// <summary>
        /// Represents the font size of the form
        /// </summary>
        private float FontSize { get; set; }

        /// <summary>
        /// Represents the list with all controls on the form
        /// </summary>
        private List<Rectangle> _arr_control_storage = new List<Rectangle>();

        /// <summary>
        /// Represents the boolean variable for show the row header
        /// </summary>
        private bool showRowHeader = false;

        public Resize(Form _form)
        {
            Form = _form;
            FormSize = _form.ClientSize;
            FontSize = _form.Font.Size;
        }

        /// <summary>
        /// Represents the method that set the size of all controls on the form
        /// </summary>
        public void ResizeForm() //Set the resize
        {
            double _form_ratio_width = (double)Form.ClientSize.Width / (double)FormSize.Width; //ratio could be greater or less than 1
            double _form_ratio_height = (double)Form.ClientSize.Height / (double)FormSize.Height; // this one too
            var _controls = GetAllControls(Form); //reenumerate the control collection
            int _pos = -1;//do not change this value unless you know what you are doing
            foreach (Control control in _controls)
            {
                // do some math calc
                _pos += 1;//increment by 1;
                Size _controlSize = new Size((int)(_arr_control_storage[_pos].Width * _form_ratio_width),
                    (int)(_arr_control_storage[_pos].Height * _form_ratio_height)); //use for sizing

                Point _controlposition = new Point((int)
                (_arr_control_storage[_pos].X * _form_ratio_width), (int)(_arr_control_storage[_pos].Y * _form_ratio_height));//use for location

                //set bounds
                control.Bounds = new Rectangle(_controlposition, _controlSize); //Put together

                //Assuming you have a datagridview inside a form()
                //if you want to show the row header, replace the false statement of 
                //showRowHeader on top/public declaration to true;
                if (control.GetType() == typeof(DataGridView))
                    _dgv_Column_Adjust(((DataGridView)control), showRowHeader);


                //Font AutoSize
                control.Font = new System.Drawing.Font(Form.Font.FontFamily,
                 (float)(((Convert.ToDouble(FontSize) * _form_ratio_width) / 2) +
                  ((Convert.ToDouble(FontSize) * _form_ratio_height) / 2)));

            }
        }

        /// <summary>
        /// Represents the method that get the initial size of all controls on the form
        /// </summary>
        public void GetInitialSize()
        {
            var controls = GetAllControls(Form);

            foreach (Control c in controls)
            {
                _arr_control_storage.Add(c.Bounds);

                if (controls.GetType() == typeof(DataGridView))
                {
                    _dgv_Column_Adjust(((DataGridView)c), showRowHeader);
                }
            }
        }

        /// <summary>
        /// Represents the method that ajust datagridview
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="_showRowHeader"></param>
        private void _dgv_Column_Adjust(DataGridView dgv, bool _showRowHeader) 
        {
            int intRowHeader = 0;
            const int Hscrollbarwidth = 5;
            if (_showRowHeader)
                intRowHeader = dgv.RowHeadersWidth;
            else
                dgv.RowHeadersVisible = false;

            for (int i = 0; i < dgv.ColumnCount; i++)
            {
                if (dgv.Dock == DockStyle.Fill) //in case the datagridview is docked
                    dgv.Columns[i].Width = ((dgv.Width - intRowHeader) / dgv.ColumnCount);
                else
                    dgv.Columns[i].Width = ((dgv.Width - intRowHeader - Hscrollbarwidth) / dgv.ColumnCount);
            }
        }

        /// <summary>
        /// Represents the method that get all controls from the form
        /// </summary>
        /// <param name="control"></param>
        /// <returns></returns>
        private static IEnumerable<Control> GetAllControls(Control control)
        {
            return control.Controls.Cast<Control>().SelectMany(c => GetAllControls(c)).Concat(control.Controls.Cast<Control>()).Where(c => c.Name != string.Empty);
        }
    }
}
