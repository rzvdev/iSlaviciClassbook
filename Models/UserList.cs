using System;

namespace iSlavici.Models
{
    public class UserList
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Name { get; set; }
        public string CNP { get; set; }
        public string Role { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Profile { get; set; }
        public int Year { get; set; }
        public DateTime CreatedDate 
        {
            get;
            set;
        }

        public UserList(int Id, string username, string name, string cnp, string role, string email, string profile, string phone, int year, DateTime createdDate)
        {
            ID = Id;
            Username = username;
            Name = name;
            CNP = cnp;
            Role = role;
            Email = email;
            Phone = phone;
            Profile = profile;
            Year = year;
            CreatedDate = createdDate;
        }

        public UserList()
        {

        }
       
    }
}
