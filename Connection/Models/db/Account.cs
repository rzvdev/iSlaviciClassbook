using iSlavici.Connection.Models.db.interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace iSlavici.Connection.Models.db
{
    public partial class Account : IAccount
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public Person Person { get; set; }
        public int PersonId { get; set; }

        public int RoleId { get; set; }
        public int? ProfileId { get; set; }


    }
}
