using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2
{
    public class SquareAndCube
    {
        public void SC()
        {
            Console.WriteLine("Enter a Square Number:");
            double num = Convert.ToDouble(Console.ReadLine());

            // Calculate square using the FindSquare method
            double squareResult = num * num;
            Console.WriteLine("Square of "+num+ " is"+ squareResult);

            Console.WriteLine("Enter a cube Number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Calculate cube using the FindSquare method
            double cuberesult = num2 * num2 * num2;
            Console.WriteLine("Square of " + num2 );

                 
        }

    }
}
