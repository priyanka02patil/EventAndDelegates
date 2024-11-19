using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegates
{
    public class BankEvent
    {
        static void InsuffBalance()
        {
            Console.WriteLine("OOPs ! You have insufficient balance");
        }
        static void LowBalance()
        {
            Console.WriteLine("OOPs ! You have low balance");
        }
        static void ZeroBalance()
        {
            Console.WriteLine("COOPs ! You have Zero balance");
        }

        static void Main(string[] args)
        {
            Bank b = new Bank(0);
            //b.Credit(3000);
            //b.Debit(500);
            b.Insuff += new Bank.DisplayBankMessage(InsuffBalance);
            b.Low += new Bank.DisplayBankMessage(LowBalance);
            b.Zero += new Bank.DisplayBankMessage(ZeroBalance);


            b.Credit(5000);
            b.Debit(5000);
            b.Debit(2000);


        }

    }
}
