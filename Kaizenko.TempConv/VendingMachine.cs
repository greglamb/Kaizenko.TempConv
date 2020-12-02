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
            var change = paid;
            paid = 0;
            return change;
        }

        public void InsertCoin(double v)
        {
            paid = paid + v;
        }
    }
}
