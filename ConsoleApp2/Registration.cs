using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Registration
    {
        public void Registration_Details() 
        {
            Console.WriteLine("Enter Your Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age : ");
            int age = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Enter your Country : ");
            string country = Console.ReadLine();

            Console.WriteLine("Enter phone number (10 digits): ");
            long mob = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("************************************");

            Console.WriteLine("Welcome " + name + ".Your age is " + age + " and you are from " + country + " with Mobile number " + mob);

            Console.WriteLine("************************************");

        }
    }
}
