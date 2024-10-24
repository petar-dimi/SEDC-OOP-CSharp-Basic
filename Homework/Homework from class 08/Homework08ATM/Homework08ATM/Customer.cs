using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework08ATM
{
    public class Customer
    {
        public string FullName { get; set; }
        public long CardNumber { get; private set; } 
        private int Pin { get; set; } 
        private decimal Balance { get; set; }

       
        public Customer(string fullName, long cardNumber, int pin, decimal balance)
        {
            FullName = fullName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }

       
        public bool Authenticate(int pin) => Pin == pin;

        
        public decimal CheckBalance() => Balance;

        
        public string Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return $"You withdrew {amount:C}. You have {Balance:C} left on your account.";
            }
            return $"Insufficient funds! You have {Balance:C} on your account.";
        }

        
        public string Deposit(decimal amount)
        {
            Balance += amount;
            return $"You deposited {amount:C}. Your new balance is {Balance:C}.";
        }

    }
}
