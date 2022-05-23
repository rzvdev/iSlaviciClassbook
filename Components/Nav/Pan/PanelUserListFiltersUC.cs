using classbook.Connection;
using iSlavici.Connection.Models.db;
using iSlavici.Controls.Navigator;
using iSlavici.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace iSlavici.Components.Nav.Pan
{
    public partial class PanelUserListFiltersUC : UserControl
    {
        private Profile SelectedProfile { get; set; }
        private int SelectedYear { get; set; }



        public PanelUserListFiltersUC() {
            InitializeComponent();
        }

        private void LoadUsers(Profile byProfile = null,int inYear = 0) {
            DataAccess.LoadUsers();

            cbSearch.Items.Clear();
            cbSearch.Items.Add("ALL");
            cbSearch.SelectedItem = cbSearch.Items[0];

            if (byProfile != null) {
                DataAccess.users = DataAccess.users.Where(p => p.Profile == byProfile.Name).ToList();
            }

            if (inYear != 0) {
                DataAccess.users = DataAccess.users.Where(p => p.Year == inYear).ToList();
            }

            foreach (var people in DataAccess.users) {
                cbSearch.Items.Add(people.Name);
            }

            RefreshUserTable(DataAccess.users);
        }

        private void RefreshUserTable(List<UserListModel> users) {
            UserListModel usr = new UserListModel();
            usr.SetUserList(DataAccess.users);
            Navigator.GetInstance().RefreshUserDGVfiltred(usr);
        }

        private void LoadProfiles() {
            DataAccess.LoadProfiles();
            cbProfile.Items.Clear();
            cbProfile.Items.Add("ALL");
            cbProfile.SelectedItem = cbProfile.Items[0];

            foreach (var profile in DataAccess.profiles) {
                cbProfile.Items.Add(profile.Name);
            }
        }

        private void LoadYears(int year = 0) {
            cbYear.Items.Clear();
            cbYear.Items.Add("ALL");
            cbYear.SelectedItem = cbYear.Items[0];
            SelectedYear = 0;

            if (year == 0) {
                int posibilityMaxYear = (from pro in DataAccess.profiles
                                         select pro.Years).Max();

                for (int i = 1; i <= posibilityMaxYear; i++) {
                    cbYear.Items.Add(i.ToString());
                }
            } else {
                for (int i = 1; i <= SelectedProfile.Years; i++) {
                    cbYear.Items.Add(i.ToString());
                }
            }
        }

        private void SearchActiveFilter(object sender,EventArgs e) {
            ComboBox cb = (ComboBox)sender;
            bool allUsers = cb.SelectedItem.ToString().Equals("ALL");

            if (!allUsers) {
                string searched = cb.SelectedItem.ToString();
                List<UserListModel> userSearched = DataAccess.users.Where(u => u.Name == searched).ToList();
                UserListModel userList = new UserListModel();
                userList.SetUserList(userSearched);
                Navigator.GetInstance().RefreshUserDGVfiltred(userList);
            } else {
                LoadUsers(SelectedProfile, SelectedYear);
            }
        }

        private void ProfileActiveFilterClickEvent(object sender, EventArgs e) {
            ComboBox cb = (ComboBox)sender;
            bool allProfile = cb.SelectedItem.ToString().Equals("ALL");

            if (!allProfile) {
                string selected = cb.SelectedItem.ToString();
                SelectedProfile = (from pr in DataAccess._dbContext.Profile
                                   where pr.Name == selected
                                   select pr).FirstOrDefault();
            } else {
                SelectedProfile = null;
                SelectedYear = 0;
            }

            LoadUsers(SelectedProfile,SelectedYear);
            LoadYears(SelectedYear);
        }

        private void YearActiveFilterClickEvent(object sender, EventArgs e) {
            ComboBox cb = (ComboBox)sender;
            bool allYears = cb.SelectedItem.ToString().Equals("ALL");

            if (!allYears) {
                int selected = int.Parse(cb.SelectedItem.ToString());
                SelectedYear = selected;
            } else {
                SelectedYear = 0;
            }

            LoadUsers(SelectedProfile,SelectedYear);
        }

        private void PanelUserListFiltersUC_Load(object sender, EventArgs e) {
            LoadUsers();
            LoadProfiles();
            LoadYears();
        }
    }
}
