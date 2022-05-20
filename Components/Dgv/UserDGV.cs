using classbook.Connection;
using iSlavici.Controls;
using iSlavici.Controls.Navigator;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iSlavici.Models
{
    public class UserDGV : TableDGV
    {
        private static UserDGV instance = null;
        private UserDGV() {
        }

        public static UserDGV GetInstance() {
            if (instance == null) {
                instance = new UserDGV();
                instance.InitializeTable();
            }
            return instance;
        }

        public override void InitializeTable() {
             CellClick += ButtonCellClick;
             SetTableSettings(this);
             AddColumns();
             FillTable();
        }

        public void ButtonCellClick(object sender, DataGridViewCellEventArgs e) {
            try {
                // TREATING APPEAR TWO TIMES THE DIALOG RESULT
                if (!(sender is UserDGV)) return;

                if ((e.RowIndex < 0) || (e.ColumnIndex < 0)) return;

                if (e.ColumnIndex == 11 || e.ColumnIndex == 12) {
                    string id = Convert.ToString(Rows[e.RowIndex].Cells[0].Value) ?? string.Empty;
                    string username = Convert.ToString(Rows[e.RowIndex].Cells[1].Value) ?? string.Empty;
                    string password = Convert.ToString(Rows[e.RowIndex].Cells[2].Value) ?? string.Empty;
                    string fullname = Convert.ToString(Rows[e.RowIndex].Cells[3].Value) ?? string.Empty;
                    string cnp = Convert.ToString(Rows[e.RowIndex].Cells[4].Value) ?? string.Empty;
                    string role = Convert.ToString(Rows[e.RowIndex].Cells[5].Value) ?? string.Empty;
                    string email = Convert.ToString(Rows[e.RowIndex].Cells[6].Value) ?? string.Empty;
                    string phone = Convert.ToString(Rows[e.RowIndex].Cells[7].Value) ?? string.Empty;
                    string profile = Convert.ToString(Rows[e.RowIndex].Cells[8].Value) ?? string.Empty;
                    string year = Convert.ToString(Rows[e.RowIndex].Cells[9].Value) ?? string.Empty;

                    switch (e.ColumnIndex) {
                        // DELETE BUTTON
                        case 11:
                            DialogResult dg = MessageBox.Show($"Do you really want to delete this user?\n\nID: {id}\nUsername: {username}\nName: {fullname}\nCNP: {cnp}\nProfile: {profile}\nRole: {role}", "Confirm delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                            if (dg == DialogResult.Yes) {
                                DataAccess.DeleteUser(int.Parse(id));
                                RefreshData();
                                return;
                            }
                            break;

                        // EDIT BUTTON
                        case 12:
                            if(role == "ADMINISTRATOR") {
                                MessageBox.Show("Cannot edit admin users!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            Navigator.GetInstance().SelectEditUserPage(int.Parse(id),username, password, fullname, email, cnp, phone, role, profile, int.Parse(year));
                            break;
                    }
                }

            } catch (Exception ex) {
                throw ex;
            }
        }

        public override void FillTable() {
            LoadData();
            foreach (var user in DataAccess.users) {
                Rows.Add(user.ID, user.Username,user.Password, user.Name, user.CNP, user.Role, user.Email, user.Phone, user.Profile, user.Year, FormattedDate(user.CreatedDate));
            }
        }

        private string FormattedDate(DateTime date) {
            return date.ToString("dd/MM/yyyy");
        }

        public override void LoadData() {
            DataAccess.LoadUsers();
            Refresh();
        }

        public override void RefreshData() {
            Rows.Clear();
            FillTable();
            Refresh();
        }

        public override void AddColumns() {
            try {
                    DataGridViewColumn editBtnColumn = new DataGridViewButtonColumn {
                        Width = 40,
                        HeaderText = "ED.",
                        CellTemplate = new DataGridViewButtonCell(),
                    };

                    DataGridViewColumn deleteBtnColumn = new DataGridViewColumn {
                        Width = 40,
                        HeaderText = "DEL.",
                        CellTemplate = new DataGridViewButtonCell()
                    };

                    DataGridViewColumn idColumn = new DataGridViewColumn {
                        Width = 50,
                        HeaderText = "ID",
                        CellTemplate = new DataGridViewTextBoxCell()
                    };

                    DataGridViewColumn usernameColumn = new DataGridViewColumn {
                        Width = 150,
                        HeaderText = "USERNAME",
                        CellTemplate = new DataGridViewTextBoxCell()
                    };

                    DataGridViewColumn passwordColumn = new DataGridViewColumn {
                        Width = 150,
                        HeaderText = "PASSWORD",
                        CellTemplate = new DataGridViewTextBoxCell()
                    };

                    DataGridViewColumn fullnameColumn = new DataGridViewColumn {
                        Width = 200,
                        HeaderText = "FULL NAME",
                        CellTemplate = new DataGridViewTextBoxCell()
                    };

                    DataGridViewColumn cnpColumn = new DataGridViewColumn {
                        Width = 200,
                        HeaderText = "CNP",
                        CellTemplate = new DataGridViewTextBoxCell()
                    };

                    DataGridViewColumn roleColumn = new DataGridViewColumn {
                        Width = 120,
                        HeaderText = "ROLE",
                        CellTemplate = new DataGridViewTextBoxCell()
                    };

                    DataGridViewColumn emailColumn = new DataGridViewColumn {
                        Width = 250,
                        HeaderText = "EMAIL",
                        CellTemplate = new DataGridViewTextBoxCell()
                    };

                    DataGridViewColumn phoneColumn = new DataGridViewColumn {
                        Width = 200,
                        HeaderText = "PHONE",
                        CellTemplate = new DataGridViewTextBoxCell()
                    };

                    DataGridViewColumn profileColumn = new DataGridViewColumn {
                        Width = 150,
                        HeaderText = "PROFILE",
                        CellTemplate = new DataGridViewTextBoxCell()
                    };

                    DataGridViewColumn yearColumn = new DataGridViewColumn {
                        Width = 50,
                        HeaderText = "YEAR",
                        CellTemplate = new DataGridViewTextBoxCell()
                    };

                    DataGridViewColumn createdDateColumn = new DataGridViewColumn {
                        Width = 200,
                        HeaderText = "DATE CREATED",
                        CellTemplate = new DataGridViewTextBoxCell()
                    };


                    Columns.Insert(0, idColumn);
                    Columns.Insert(1, usernameColumn);
                    Columns.Insert(2, passwordColumn);
                    Columns.Insert(3, fullnameColumn);
                    Columns.Insert(4, cnpColumn);
                    Columns.Insert(5, roleColumn);
                    Columns.Insert(6, emailColumn);
                    Columns.Insert(7, phoneColumn);
                    Columns.Insert(8, profileColumn);
                    Columns.Insert(9, yearColumn);
                    Columns.Insert(10, createdDateColumn);
                    Columns.Insert(11, deleteBtnColumn);
                    Columns.Insert(12, editBtnColumn);
            } catch (Exception e) {
                throw e;
            }
        }

        public override void FillTableFiltred(IFiltrable filtred) {
            throw new NotImplementedException();
        }
    }
}
