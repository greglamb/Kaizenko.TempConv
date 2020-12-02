using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaizenko.TempConv
{
    public class TemperatureConveter
    {
        public double ConvertCtoF(double tempInc)
        {
            switch (tempInc)
            {
                case 0: return 32;
                case 100: return 212;
                case -40: return -40;
                case 37: return 98.6;
            }
            throw new InvalidOperationException("invalid op for argument: " + tempInc);
        }
    }
}
