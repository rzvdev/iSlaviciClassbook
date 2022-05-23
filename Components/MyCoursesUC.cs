using iSlavici.Controls.Dgv;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Controls
{
    public partial class MyCoursesUC : UserControl
    {
        public MyCoursesDGV MyCoursesDGV { get; set; }

        public MyCoursesUC() {
            InitializeComponent();
            Visible = true;
            Dock = DockStyle.Fill;
            CreateAndAssignTable();
        }

        private void CreateAndAssignTable() {
            MyCoursesDGV = MyCoursesDGV.Create();
            Controls.Add(MyCoursesDGV);
        }
    }
}
