using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class CraftsmenLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Craftsmen Loan payment plan is calculated.");
        }
    }
}
