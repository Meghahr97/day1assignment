using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char transtype;
            Console.WriteLine("do you want to withdraw or deposit (d/w)");
            transtype = char.Parse(Console.ReadLine());
            acc ac = new acc();

            if(transtype=='d')
           
                ac.deposit();

                    else
                ac.withdraw();

                    ac.showdata();
            
        }
    }
}
