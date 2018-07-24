using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstname, lastname, email;
            DateTime dob;
            Console.WriteLine("enter firstname,lastname,email,dob:");
            firstname = Console.ReadLine();
            lastname = Console.ReadLine();
            email = Console.ReadLine();
            dob = DateTime.Parse(Console.ReadLine());
            persondata p = new persondata(firstname, lastname, email, dob);
            p.adult();
            p.sun_sign();
            p.birthday();
            persondata p2 = new persondata(firstname, lastname, dob);
            p2.adult();
            p2.sun_sign();
            p2.birthday();
            persondata p3 = new persondata(firstname, lastname, email);
            p3.adult();
            p3.sun_sign();
            p3.birthday();

        }
    }
}
