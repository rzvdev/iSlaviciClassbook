using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace iSlavici.Connection.Models.db
{
    public class SubjectType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }

    }
}