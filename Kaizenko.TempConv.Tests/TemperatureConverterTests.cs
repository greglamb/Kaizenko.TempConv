using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kaizenko.TempConv;

namespace Kaizenko.TempConv.Tests
{
    public class TemperatureConverterTests
    {
        [Test]
        public void ConverterCtoF_When0C_Expect23F()
        {
            var tempConveter = new TemperatureConveter();
            var tempInF = tempConveter.ConvertCtoF(0);
            Assert.AreEqual(32, tempInF);
        }

        [Test]
        public void ConvertCtoF_When100C_Expect212F()
        {
            var tempConveter = new TemperatureConveter();
            var tempInF = tempConveter.ConvertCtoF(100);
            Assert.AreEqual(212, tempInF);
        }

        [Test]
        public void ConvertCtoF_WhenNegative40C_ExpectNegative40F()
        {
            var tempConveter = new TemperatureConveter();
            var tempInF = tempConveter.ConvertCtoF(-40);
            Assert.AreEqual(-40, tempInF);
        }

        [Test]
        public void ConvertCtoF_When37C_Expect98Point6F()
        {
            var tempConveter = new TemperatureConveter();
            var tempInF = tempConveter.ConvertCtoF(37);
            Assert.AreEqual(98.6, tempInF);
        }







    }
}
