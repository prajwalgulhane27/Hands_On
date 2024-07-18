using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class GenrateBillDetails
    {
        public void Acceptitems()
        {
            Console.WriteLine("Enter the No of Pizzas bought: ");
            int pizza = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the No of Puffs bought: ");
            int puff = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the No of Pepsi bought: ");
            int pepsi = Convert.ToInt32(Console.ReadLine());

            CalculateBill(pizza, puff, pepsi);
        }

        public void CalculateBill(int pizza, int puff, int pepsi)
        {
            int pizza1 = 200 * pizza;
            int puff1 = 40 * puff;
            int pepsi1 = 120 * pepsi;
            Console.WriteLine("Cost of Pizza is: {0}", pizza1);
            Console.WriteLine("Cost of Puff is: {0}", puff1);
            Console.WriteLine("Cost of Pepsi is: {0}", pepsi1);
            float total = pizza1 + puff1 + pepsi1;
            Console.WriteLine("Total Amount: {0}", total);
            float GST = total * 12 / 100;
            Console.WriteLine("GST 12%:{0}", GST);
            float CESS = total * 5 / 100;
            Console.WriteLine("CESS 5%: {0}", CESS);

            float totalcost = total + GST + CESS;
            Console.WriteLine("Final Amount :" + totalcost);
        }
    }

}

