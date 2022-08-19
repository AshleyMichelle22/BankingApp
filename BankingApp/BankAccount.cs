using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class BankAccount
    {
        public BankAccount()
        {


        }
        private double balance = 0; //hiding this balance from outside the class

        // Define a method named Deposit that will accept a double
        // and store that value in the balance field

        // Encapsulation
        public void Deposit(double amount)
        {
            balance = amount;
  
        }

        //define a method named GetBalance that will return the amount stored in the balance  field

        public string GetBalance()
            //public double GetBalance() returns no $ sign in front 
            //public string GetBalance() &  {return $"${balance}";} returns the number with money sign in front
        {
            return $"${balance}";

        }











    } 






}

