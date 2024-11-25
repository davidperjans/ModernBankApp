﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernBankApp.Classes.BankFolder
{
    public class BankAccount
    {
        public string Name { get; set; }
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public DateTime CreatedDate { get; set; }

        public BankAccount(string name, string accountNumber, decimal balance)
        {
            Name = name;
            AccountNumber = accountNumber;
            Balance = balance;
            CreatedDate = DateTime.Now;
        }

        public void TransferTo(BankAccount targetAccount, decimal amount)
        {
            if (amount <= 0 || amount > Balance)
                throw new InvalidOperationException("Invalid transfer amount");

            Balance -= amount;
            targetAccount.Balance += amount;
        }
    }
}
