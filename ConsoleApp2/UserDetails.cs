using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class UserDetails
    {
        public void User()
        {
            Console.WriteLine("Enter name:");
            string name = Console.ReadLine();

             Console.WriteLine("Enter age (completed years and months):");
            string age = Console.ReadLine();

            Console.WriteLine("Enter gender ('M' for Male and 'F' for Female):");
            string gender = Console.ReadLine();

            Console.WriteLine("Enter city:");
            string city= Console.ReadLine();

            Console.WriteLine("Enter phone number (10 digits): ");
            long mob = Convert.ToInt64(Console.ReadLine());


            Console.WriteLine("Enter pincode:");
            int pincode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***********************************");

            Console.WriteLine("\nUser Details:");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age: " +age);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("City: "+city);
            Console.WriteLine("Mobile: "+mob);
            Console.WriteLine("Pincode: " +pincode);

            Console.WriteLine("***********************************");

        }
    }
}
