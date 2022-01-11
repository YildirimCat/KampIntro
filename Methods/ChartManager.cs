using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class ChartManager
    {

        //Best Practice
        public void Add(Product product)
        {
            Console.WriteLine(product.Name + " sepete eklendi.");
        }

        //Bad usage
        public void Add2(string productName,string productExp,int price)
        {
            Console.WriteLine(productName + " sepete eklendi.");
        }
    }
}
