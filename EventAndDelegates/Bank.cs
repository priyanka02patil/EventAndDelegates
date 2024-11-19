using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates
{
    public class Bank
    {
        public delegate void DisplayBankMessage();
        // event
        public event DisplayBankMessage Insuff;// it is an event name
        public event DisplayBankMessage Low;
        public event DisplayBankMessage Zero;


        //Create a Bank a class, with Debit & Credit method
        //You can assign a default balance using constructor
        //Credit method will accept the amount that needs to be added in balance
        //Debit method will accept the amount that needs to be deducted from the balance.
        //If amount is greater than balance raise an event → insufficient balance
        //If balance is low (< 3000) raise an event low balance
        //If balance is zero then raise an event zero balance.

        float balance;
        public Bank(float balance)
        {
            this.balance = balance;
        }

        public void Credit(float amount)
        {
            balance = balance + amount;
            Console.WriteLine("Credit balance"+balance);
        }

        public void Debit(float amount)
        {
            if (balance>amount)
            {
                balance = balance - amount;
                Console.WriteLine("Debited balance" + balance);
            }
            else if (balance<amount)
            {
                Insuff();  // raise an event /  call to event
            }
            else if (balance < 3000)
            {
                Low();
            }
            else if (balance == 0)
            {
                Zero();
            }

           

        }

        //public void CheckBalance(float amount)
        //{
        //    if (amount >= balance)
        //    {
        //        Insuff();  // raise an event /  call to event
        //    }
        //    else if(amount <3000)
        //    {
        //        Low();
        //    }
        //    else if(amount ==0)
        //    {
        //        Zero();
        //    }
        //}





    }
}
