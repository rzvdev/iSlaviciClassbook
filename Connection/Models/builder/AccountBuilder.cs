using iSlavici.Connection.Models.db;

namespace iSlavici.Connection.Models.builder
{
    public class AccountBuilder
    {
        private readonly Account _account = new Account();

        public AccountBuilder Username(string username)
        {
            _account.Username = username;
            return this;
        }

        public AccountBuilder Password(string password)
        {
           _account.Password = password;
            return this;
        }

        public AccountBuilder Have(int role)
        {
            _account.RoleId = role;
            return this;
        }

        public Account Build()
        {
            return _account;
        }
    }
}