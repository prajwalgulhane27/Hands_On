using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class PropertyCode
    {
        private int empid;

       
        public int EmpIdReadOnly
        {
            get { return empid; }
        }

       
        public int EmpIdWriteOnly
        {
            set
            {
                if (value > 100)
                {
                    empid = 0;
                }
                else
                {
                    empid = value;
                }
            }
        }

        // Method to set and get EmpId
        public void SetAndDisplayEmpId()
        {
            Console.WriteLine("Enter EmpId:");
            EmpIdWriteOnly = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("EmpId (Read Only): " + EmpIdReadOnly);
        }
    }
}
