using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    [TestClass]
    public class StringIsNullOrEmptyExample
    {
        [TestMethod]
        public void Example()
        {
            var aString = "";

            bool isNullOrEmpty;        


            //if (aString == null || aString == "") 
            //peut devenir 
            //if (string.IsNullOrEmpty(aString) )
            //ou bien pour quelques choses de plus sur
            if (string.IsNullOrWhiteSpace(aString))
            {
                isNullOrEmpty = true;
            }
            else
            {
                isNullOrEmpty = false;
            }
        }
    }
}
