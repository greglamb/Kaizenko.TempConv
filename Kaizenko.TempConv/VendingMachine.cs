using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizenko.TempConv
{
    public class VendingMachine
    {
        public double paid;

        public double ReleaseChange()
        {
            return paid;
        }

        public void InsertCoin(double v)
        {
            paid = paid + v;
        }
    }
}
