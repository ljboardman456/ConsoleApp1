using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print prompt for width
            Console.WriteLine("What is the width?");
            //collect width input
            double width = Convert.ToDouble(Console.ReadLine());
            //print prompt for height
            Console.WriteLine("What is the height?");
            //collect height input
            double height = Convert.ToDouble(Console.ReadLine());
            //collect area
            double area = width * height;   
            //collect perimeter
            double perimeter = (width+height)/2;
            //print result area
            Console.WriteLine("Area: " + area);
            //print result perimeter
            Console.WriteLine("Perimeter: " + perimeter);
            //wait for user input
            Console.ReadLine();
        }
    }
}
