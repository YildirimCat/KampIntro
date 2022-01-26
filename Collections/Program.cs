using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        public static void Main(string[] args)
        {   

            //Dynamic Arrays (ArrayList in Java)
            List<string> names = new List<string> { "Haldir","Legolas","Glorfindel"};
  
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            
            names.Add("Jon");
            Console.WriteLine(names[3]);
            
            

        }
    }
}

