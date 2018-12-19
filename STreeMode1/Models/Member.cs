using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STreeMode1.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone_Number { get; set; }
        public DateTime Birthday { get; set; }

        public Member() { }

        public Member(int Id, string Name, string Account, string Password, string Email, string Address, string Phone_Number , DateTime Birthday)
        {
            this.Id = Id;
            this.Name = Name;
            this.Account = Account;
            this.Password = Password;
            this.Email = Email;
            this.Address = Address;
            this.Phone_Number = Phone_Number;
            this.Birthday = Birthday;
        }
    }
}