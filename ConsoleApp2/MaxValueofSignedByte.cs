using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class MaxValueofSignedByte
    {
        public void MaxValue()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToByte(Console.ReadLine());
            


            Console.WriteLine("Value of number: " + number);


            number = sbyte.MaxValue;


            Console.WriteLine("Largest value stored in a signed byte: " + number);
        }

    }
}
