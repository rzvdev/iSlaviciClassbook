﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using classbook.Utility;

namespace classbook
{
    public partial class Dashboard : Form
    {
        private readonly Resize _resize;

        public Dashboard()
        {
            this.DoubleBuffered = true;

            InitializeComponent();
            _resize = new Resize(this);
            Load += Dashboard_Load;
            Resize += Dashboard_Resize;

        }

        private void Dashboard_Resize(object sender, EventArgs e)
        {
            _resize.ResizeForm();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           _resize.GetInitialSize();

        }

        private void btnProfiles_Click(object sender, EventArgs e)
        {
            if(navigator.Pages.Contains(pageCreateUser) && pageCreateUser.Visible == false) pageCreateUser.Visible = true; 
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
