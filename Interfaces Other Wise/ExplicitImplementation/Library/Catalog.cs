using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Catalog : ISaveable , IVoidSaveable
    {

        string ISaveable.Save()
        {
            throw new NotImplementedException();
        }
    }
}
