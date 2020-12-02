using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizenko.TempConv
{
    public class VendingMachine
    {
        public double coins;

        public double ReleaseChange()
        {
            var change = coins;
            coins = 0;
            return change;
        }

        public void InsertCoin(double v)
        {
            coins = coins + v;
        }

        public Product BuyProduct()
        {
            if (coins >= 50)
            {
                coins = coins - 50;
                return new Product();
            }
            else
            {
                return null;
            }
        }
    }
}
