using System;

namespace iSlavici.Connection.Models.interfaces
{
    internal interface IStudent
    {
        int Id { get; set; }
        int PersonId { get; set; }
        int ProfileId { get; set; }
        int InYear { get; set; }
        DateTime StartYear { get; set; }
        DateTime EndYear { get; set; }
    }
}
