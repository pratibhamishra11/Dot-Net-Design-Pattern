using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Assigment
{
    internal class EmployeeCard : DiscountStrategy
    {
        void DiscountStrategy.discount(double amount)
        {
            Console.WriteLine("The discount for employee card is 20% ");
            Console.WriteLine("The amount to be paid is : "+ (amount - amount * 0.20));
        }
    }
}
