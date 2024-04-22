using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Assigment
{
    internal class DiscountContext
    {
        private DiscountStrategy discountStrategy;

        public DiscountContext(DiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public void setDiscountStategy(DiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public void giveDiscount(double amount)
        {
            discountStrategy.discount(amount);
        }
    }
}
