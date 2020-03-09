using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectStore
{
    [Serializable]
    public class Product
    {
        public long ID;
        public string Name;
        public double Price;

            [NonSerialized]
            string Notes;


        public Product(long id, string name, double price, string notes)
        {
            ID = id;
            Name = name;
            Price = price;
            Notes = notes;
        }

        public override string ToString()
        {
            return string.Format("{0}: {1} (${2:F2}) {3}", ID, Name, Price, Notes);
        }
    }
}
