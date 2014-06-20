using System;
using System.Collections;
using System.Collections.Generic;

namespace Library
{
    public class StandardCatalog : ISaveable , IPersistable
    {
        public void Load()
        {
        }

        // private string Save() : false when we have a contract all 
        //our method implementation must be public
        public string Save()
        {
            return "Catalog Save";
        }
    }

    public class ExplicitCatalog : ISaveable, IPersistable
    {
        public string Save()
        {
            return "Catalog Save";
        }
        
        //public item not valid in this context
        //if we try to get put public encap on this member 
        //we get error

        //les méthodes Save sont completement overridé 
        string ISaveable.Save()
        {
            return "ISaveable Save";
        }


        string IPersistable.Save()
        {
            return "IPersistable Save";
        }
    }

    public class EnumerableCatalog : IEnumerable<string>
    {

        public IEnumerator<string> GetEnumerator()
        {
           // all of our code
            return null;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {

            return this.GetEnumerator();
        }
    }

}
