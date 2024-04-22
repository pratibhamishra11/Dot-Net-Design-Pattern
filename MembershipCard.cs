using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Assigment
{
    internal class MembershipCard : DiscountStrategy
    {
        void DiscountStrategy.discount(double amount)
        {
            Console.WriteLine("The discount for membership card is : 10 % ");
            Console.WriteLine("The amount to be paid is : " + (amount - amount * 0.10));
        }
    }
}
