using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModernBankApp.Classes.BankFolder;

namespace ModernBankApp.Classes.UserFolder
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public List<BankAccount> Accounts { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            Accounts = new List<BankAccount>();
        }
    }
}
