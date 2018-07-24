using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findarea
{
    class shape
    {
        int squarearea,rectanglearea;
        double tarea;
        double carea;

        public void area(int side)
        {
            squarearea = side * side;
           
        }
        public void area(int length,int breadth)
        {
            rectanglearea = length * breadth;
        }
        public void area(double radius)
        {
            double pi = 3.14;
            carea = pi * radius;
        }
        public void area(int a,double b)
        {
             tarea = 0.5 * a * b;

        }
        public void showdata()
        {
            Console.WriteLine("area of square:" + squarearea);
            Console.WriteLine("area of :" + rectanglearea);
            Console.WriteLine("area of triangle :" + tarea);
            Console.WriteLine("area of circle:" + carea);

        }

    }
}
