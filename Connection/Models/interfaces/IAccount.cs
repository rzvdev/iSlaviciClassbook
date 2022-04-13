namespace iSlavici.Connection.Models.db.interfaces
{
    public interface IAccount
    {
        int Id { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        Person Person { get; set; }
        int PersonId { get; set; }
        int RoleId { get; set; }
    }
}