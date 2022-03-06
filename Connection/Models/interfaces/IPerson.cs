using iSlavici.Connection.Models.db;
using System;

namespace iSlavici.Connection.Models.interfaces
{
    public interface IPerson
    {
        int Id { get; set; }
        string FullName { get; set; }
        string Email { get; set; }
        string Phone { get; set; }
        string CNP { get; set; }
        DateTime CreatedDate { get; set; }
        Account Account { get; set; }
    }
}
