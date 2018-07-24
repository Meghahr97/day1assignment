using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment3
{
    class persondata
    {
        string firstname;
        string lastname;
        string email;
        DateTime dob;
        int age;
        public persondata(string firstname, string lastname,string email,DateTime dob)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.dob = dob;
        }
        public persondata(string firstname,string lastname,string email)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
        }
        public persondata(string firstname,string lastname, DateTime dob)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.dob = dob;
        }

        public void adult()
        {
            age = DateTime.Now.Year - dob.Year;
            if(DateTime.Now.DayOfYear < dob.DayOfYear)
            {
                age = age - 1;

            }
            if (age >= 18)
            {
                Console.WriteLine("the person is over 18");
            }
            else
            {
                Console.WriteLine("the person is not adult");
            }
        }
        public void sun_sign()
        {
            int month = dob.Month;
            string txtZodiac = "";
            if(month==1)
            {
                txtZodiac = "aries";
            }
            if(month==2)
            {
                txtZodiac = "taurus";
            }
            if(month==3)
            {
                txtZodiac = "gemini";
            }
            if(month==4)
            {
                txtZodiac = "cancer";

            }
            if(month==5)
            {
                txtZodiac = "leo";
            }
            if(month==6)
            {
                txtZodiac = "virgo";
            }
            if(month==7)
            {
                txtZodiac = "libra";
            }
            if(month==8)
            {
                txtZodiac = "scorpio";
            }
            if(month==9)
            {
                txtZodiac = "sagitarius ";
            }
            if(month==10)
            {
                txtZodiac = "capricorn ";
            }
            if(month==11)
            {
                txtZodiac = " aquarius";
            }
            if(month==12)
            {
                txtZodiac = "pisces ";
            }
            Console.WriteLine("sun sign" + txtZodiac);
        }
        public void birthday()
        {
            if(this.dob.DayOfYear == DateTime.Now.DayOfYear)
            {
                Console.WriteLine("happy birthday");
            }
        }
        
    }
}
