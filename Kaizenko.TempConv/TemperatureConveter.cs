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
            return tempInc * 9 / 5 + 32;
        }
    }
}
