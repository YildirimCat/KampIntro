using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class DwellingLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Dwelling Loan payment plan is calculated.");
        }
    }
}
