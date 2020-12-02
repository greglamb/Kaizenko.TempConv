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
            if (paid == 25) return 25;
            return 0;
        }

        public void InsertCoin(double v)
        {
            paid = v;
        }
    }
}
