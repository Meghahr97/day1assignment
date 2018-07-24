using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class acc
    {
        int accountno=123;
        string custname="megha";
        string account_type="deposit";
        private char trans_type;
        double amount;
        double balance=10000;

      public void deposit()
        {
            Console.WriteLine("enter the amount for ua deposit");
            amount = int.Parse(Console.ReadLine());
            balance = balance + amount;
        }

        public void withdraw()
        {
            Console.WriteLine("enter the amount to withdraw");
            amount = int.Parse(Console.ReadLine());
            balance = balance - amount;
        }

        public void showdata()
        {
            Console.WriteLine("accountno:" + accountno);
            Console.WriteLine("custname:" + custname);
            Console.WriteLine("account_type" + account_type);
            
            Console.WriteLine("balance:" + balance);

        }
    }
}
