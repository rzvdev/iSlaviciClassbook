using classbook.Connection;
using iSlavici.Connection.Models.db;
using iSlavici.Controls;
using iSlavici.Controls.Navigator;
using iSlavici.Models;
using iSlavici.Utility;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace iSlavici.Forms
{
    public partial class AddNote : Form
    {
        private readonly Person _person;
        private readonly Profile _profile;
        private NoteType _noteType;
        private Subject _subject;
        private Student _student;
        private List<Note> _notes;
        NoteOneStudentListModel studentNote = new NoteOneStudentListModel();


        public AddNote(Person person, Profile profile, Subject subject, Student student)
        {
            InitializeComponent();

            lblNameInput.Text = person.FullName;
            lblCnpInput.Text = person.CNP;
            lblProfileInput.Text = profile.Name;
            lblYearInput.Text = student.InYear.ToString();

            _person = person;
            _profile = profile;
            _subject = subject;
            _student = student;

            InitializeComboboxes();
            droBtnCourse.Text = subject.Name;
            droBtnCourse.SelectedValueChanged += Course_ItemClicked;
        }

        private void InitializeComboboxes()
        {
            try
            {
                droBtnCourse.Items.Clear();
                droBtnNotetype.Items.Clear();

                List<string> courseNames = (from c in DataAccess._dbContext.Subject
                                            where c.ProfileId == _profile.Id
                                            select c.Name).ToList();

                List<string> noteTypes = (from nt in DataAccess._dbContext.NoteType
                                               select nt.TypeName).ToList();

                droBtnCourse.Items.AddRange(courseNames.ToArray());
                droBtnNotetype.Items.AddRange(noteTypes.ToArray());
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        private void Course_ItemClicked(object sender, EventArgs e) {
            try {
                ComboBox cb = (ComboBox)sender;

                if (cb.SelectedItem != null) {
                    string selectedCourse = cb.SelectedItem.ToString();

                    _subject = (from sub in DataAccess._dbContext.Subject
                                where sub.Name == selectedCourse
                                select sub).FirstOrDefault();

                    _notes = (from not in DataAccess._dbContext.Note
                              where not.Subject == _subject
                              && not.StudentName == _person.FullName
                              select not).ToList();


                    List<NoteOneStudentListModel> studentNotes = new List<NoteOneStudentListModel>();

                    foreach(var note in _notes) {
                        NoteOneStudentListModel noteModel = new NoteOneStudentListModel {
                            SubjectName = note.SubjectName,
                            SubjectAbvr = _subject.Abvr,
                            Note = note.NoteValue,
                            NoteType = note.NoteTypeName,
                            DateAdded = note.AddedDate,
                            TeacherName = _subject.TeacherName,
                            NoteId = note.Id
                        };
                        studentNotes.Add(noteModel);
                    }

                    studentNote.SetOneStudentNoteList(studentNotes);
                    Navigator.GetInstance().RefreshStudentNoteDGVfiltred(studentNote);
                }
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        _notes = (from not in DataAccess._dbContext.Note
                                  where not.Subject == _subject
                                  && not.StudentName == _person.FullName
                                  select not).ToList();


                        List<NoteOneStudentListModel> studentNotes = new List<NoteOneStudentListModel>();

                        foreach (var note in _notes) {
                            NoteOneStudentListModel noteModel = new NoteOneStudentListModel {
                                SubjectName = note.SubjectName,
                                SubjectAbvr = _subject.Abvr,
                                Note = note.NoteValue,
                                NoteType = note.NoteTypeName,
                                DateAdded = note.AddedDate,
                                TeacherName = _subject.TeacherName,
                                NoteId = note.Id
                            };
                            studentNotes.Add(noteModel);
                        }

                        studentNote.SetOneStudentNoteList(studentNotes);
                        Navigator.GetInstance().RefreshStudentNoteDGVfiltred(studentNote);

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



        private void droBtnNotetype_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                string notetype = droBtnNotetype.SelectedItem.ToString();
                if (notetype != null)
                {
                    _noteType = (from nt in DataAccess._dbContext.NoteType
                                 where nt.TypeName == notetype
                                 select nt).FirstOrDefault();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddNote_Load(object sender, EventArgs e) {
            string studentCnp = _student.Person.CNP;
            string courseName = _subject.Name;

            StudentNoteUC studentNoteUC = new StudentNoteUC(studentCnp,courseName);
            studentNoteUC.Visible = true;
            studentNoteUC.Dock = DockStyle.Fill;
            splitContainerTableNote.Panel1.Controls.Add(studentNoteUC);
        }
    }
}
