using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the amount : ");
            double amount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the type of card : ");
            Console.WriteLine("1 for Membership Card , 2 for Employee Card and 3 for No Card ");
            int card = Convert.ToInt32(Console.ReadLine());
            switch (card)
            {
                case 1:
                    DiscountContext discountContext = new DiscountContext(new MembershipCard());
                    discountContext.giveDiscount(amount);
                    break;
                case 2:
                    DiscountContext discountContext1 = new DiscountContext(new EmployeeCard());
                    discountContext1.giveDiscount(amount);
                    break;
                case 3:
                    DiscountContext discountContext2 = new DiscountContext(new NoCard());
                    discountContext2.giveDiscount(amount);
                    break;
                default:
                    Console.WriteLine("Invalid Input ");
                    break;
            }
            Console.ReadLine();
            
        }
    }
}
