﻿using classbook.Connection;
using iSlavici.Connection.Models.db;
using iSlavici.Models;
using iSlavici.Utility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Forms
{
    public partial class AddNote : Form
    {
        private readonly Person _person;
        private readonly Profile _profile;
        private NoteType _noteType;
        private Subject _subject;

        public AddNote(Person person, Profile profile, Subject subject)
        {
            InitializeComponent();

            lblNameInput.Text = person.FullName;
            lblCnpInput.Text = person.CNP;
            lblProfileInput.Text = profile.Name;
            lblYearInput.Text = 1.ToString();


            _person = person;
            _profile = profile;
            _subject = subject;

            InitializeComboboxes();
            droBtnCourse.Text = subject.Name;
        }

        private async void InitializeComboboxes()
        {
            try
            {
                droBtnCourse.Items.Clear();
                droBtnNotetype.Items.Clear();

                List<string> courseNames = await(from c in DataAccess._dbContext.Subject
                                                 select c.Name).ToListAsync();

                List<string> noteTypes = await(from nt in DataAccess._dbContext.NoteType
                                               select nt.TypeName).ToListAsync();

                droBtnCourse.Items.AddRange(courseNames.ToArray());
                droBtnNotetype.Items.AddRange(noteTypes.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private async Task LoadDgvNoteList()
        {
            try
            {
                await DataAccess.LoadStudentNotesAsync(_person.CNP,_subject.Name);
                dgvStudentNote.DataSource = DataAccess.studentNoteList;
                TableCustomize customize = new TableCustomize(dgvStudentNote,TableType.NoteOnlyOneStudentTable);
                customize.CustomizeTable();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void droBtnCourses_Click(object sender, EventArgs e)
        {
            var subjects = (from sub in DataAccess._dbContext.Subject
                            where sub.ProfileId == _profile.Id
                            select sub).ToList();

           
            List<ToolStripDropDownButton> toolStrip = new List<ToolStripDropDownButton>();
            foreach(var subject in subjects)
            {
                toolStrip.Add(new ToolStripDropDownButton
                {
                    ShowDropDownArrow = false,
                    TextAlign = ContentAlignment.TopCenter,
                    ForeColor = Color.Red,
                    Text = $"{subject.Name}",
                });
            }

            ContextMenuStrip context = new ContextMenuStrip();
            context.ItemClicked += Course_ItemClicked;
            context.Items.AddRange(toolStrip.ToArray());

            droBtnCourse.ContextMenuStrip = context;
        }

        private void Course_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem != null)
                {
                    droBtnCourse.Text = e.ClickedItem.Text;
                    _subject = (from sub in DataAccess._dbContext.Subject
                                where sub.Name == e.ClickedItem.Text
                                select sub).FirstOrDefault();
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void droBtnNotetype_Click(object sender, EventArgs e)
        {
            var noteTypes = (from not in DataAccess._dbContext.NoteType
                            select not).ToList();


            List<ToolStripDropDownButton> toolStrip = new List<ToolStripDropDownButton>();
            foreach (var type in noteTypes)
            {
                toolStrip.Add(new ToolStripDropDownButton
                {
                    ShowDropDownArrow = false,
                    TextAlign = ContentAlignment.TopCenter,
                    ForeColor = Color.Red,
                    Text = $"{type.TypeName}",
                });
            }

            ContextMenuStrip context = new ContextMenuStrip();
            context.ItemClicked += NoteType_ItemClicked;
            context.Items.AddRange(toolStrip.ToArray());

            droBtnNotetype.ContextMenuStrip = context;
        }

        private void NoteType_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                if (e.ClickedItem != null)
                {
                    droBtnNotetype.Text = e.ClickedItem.Text;
                    _noteType = (from nt in DataAccess._dbContext.NoteType
                                 where nt.TypeName == e.ClickedItem.Text
                                 select nt).FirstOrDefault();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void numBtnNoteValue_ValueChanged(object sender, EventArgs e)
        {
            if(numBtnNoteValue.Value < 0)
            {
                numBtnNoteValue.Value = 1;
            }
            if(numBtnNoteValue.Value > 10)
            {
                numBtnNoteValue.Value = 10;
            }
        }

        private void Add(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    if (_subject == null || _noteType == null || _profile == null) throw new ArgumentNullException();
                    if (DataAccess.AddNote(_person, _subject, _noteType, int.Parse(numBtnNoteValue.Value.ToString())))
                    {
                        dgvStudentNote.DataSource = LoadDgvNoteList();
                        return;
                    }
                    MessageBox.Show("Cannot add this note!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot add the note\n{ex}","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }


        private void AddNote_Load(object sender, EventArgs e)
        {
            LoadDgvNoteList();
        }

        private void splitcontainer_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvStudentNote_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
