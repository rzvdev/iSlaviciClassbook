
using iSlavici.Connection.Models.db;

namespace iSlavici.Connection.Models.builder
{
    public class PersonBuilder
    {
        private readonly Person _person = new Person();

        public PersonBuilder Name(string fullName)
        {
            _person.FullName = fullName;
            return this;
        }

        public PersonBuilder HaveEmail(string email)
        {
            _person.Email = email;
            return this;
        }

        public PersonBuilder HavePhone(string phone)
        {
            _person.Phone = phone;
            return this;
        }

        public PersonBuilder HaveCnp(string cnp)
        {
            _person.CNP = cnp;
            return this;
        }

        public PersonBuilder WithAccount(Account account)
        {
            _person.Account = account;
            return this;
        }

        public Person Build()
        {
            return _person;
        }
    }
}
