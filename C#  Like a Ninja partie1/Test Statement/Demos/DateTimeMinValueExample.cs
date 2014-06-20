using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class DateTimeMinValueExample
    {
        [TestMethod]
        public void Example()
        {
            var minVal = DateTime.MinValue;
           
            var localMinVal = minVal.ToLocalTime();

            //renvoie true or false
            var isMinVal = localMinVal == DateTime.MinValue;
        }
    }
}
 