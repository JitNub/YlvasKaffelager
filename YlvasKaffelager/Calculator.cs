using YlvasKaffelager.DataModels;
using YlvasKaffelager.ViewModels;

namespace YlvasKaffelager
{
    public class Calculator
    {
        public decimal GetTotal(decimal amount, decimal price)
        {
            decimal total = 0;
            total = amount * price;

            return total;
        }
    }
}
