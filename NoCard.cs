using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Assigment
{
    internal class NoCard : DiscountStrategy
    {
        void DiscountStrategy.discount(double amount)
        {
            Console.WriteLine("There is no discount as there is no card ");
            Console.WriteLine("The amount to be paid is : "+amount);
        }
    }
}
