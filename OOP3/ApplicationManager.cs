using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class ApplicationManager
    {
        //Dependency Injection(DI)
        public void Apply(ILoanManager loanManager,ILoggerService loggerService)
        {
            //Parametrede hangi kredi türü gönderildiyse onun Calculate() metodu çalışır
            loanManager.Calculate();
            loggerService.Log();
        }

        //Birden fazla kredi hesaplaması
        public void PreInformOfLoan(List<ILoanManager> loans)
        {
            foreach (var loan in loans)
            {
                loan.Calculate();
            }
        }
    }
}
