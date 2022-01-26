using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ConsumerLoanManager : ILoanManager
    {
        public void Calculate()
        {
            Console.WriteLine("Consumer Loan payment plan is calculated.");
        }
    }
}
