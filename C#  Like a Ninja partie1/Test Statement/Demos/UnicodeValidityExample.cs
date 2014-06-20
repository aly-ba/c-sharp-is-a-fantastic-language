using System.Globalization;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demos
{
    //remarque sur system.Globalization
    [TestClass]
    public class UnicodeValidityExample
    {
        [TestMethod]
        public void Example()
        {
            //tester unicode characeter
            var validCharacter = 'q';

            var ucCategory = char.GetUnicodeCategory(validCharacter);

            //retourne un true bien sur
            var isValidUnicode = ucCategory != UnicodeCategory.OtherNotAssigned;  



            var invalidCharacter = (char) 888;

            ucCategory = char.GetUnicodeCategory(invalidCharacter);

            //retourne false
            isValidUnicode = 
                ucCategory != UnicodeCategory.OtherNotAssigned;
        }
    }
}
