using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iSlavici.Connection.Models.db
{
    public class NoteType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
    }
}