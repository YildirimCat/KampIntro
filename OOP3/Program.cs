using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ConsumerLoanManager consumerLoanManager = new ConsumerLoanManager();
            VehicleLoanManager vehicleLoanManager = new VehicleLoanManager();
        
            //Interfaceler de classların referansını tutabilir!
            ILoanManager dwellingLoanManager = new DwellingLoanManager();
            
            ApplicationManager applicationManager = new ApplicationManager();
            //applicationManager.Apply(consumerLoanManager);

            List<ILoanManager> loanManagers = new List<ILoanManager>() {consumerLoanManager,vehicleLoanManager};
            
            //applicationManager.PreInformOfLoan(loanManagers);

            ILoggerService DBloggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            //Kredi başvurusu ve loglama süreci
            applicationManager.Apply(dwellingLoanManager, DBloggerService);
            applicationManager.Apply(vehicleLoanManager, fileLoggerService);

            //Yeni esnaf kredisi ve sms loglama sistemi eklendi.
            //Sadece yeni classlar oluşturuldu.Var olan kodlarda bir değişiklik yapılmadı.(Open-closed Principle)
            ILoanManager craftsmenLoanManager = new CraftsmenLoanManager();
            ILoggerService smsLoggerService = new SmsLoggerService();

            applicationManager.Apply(craftsmenLoanManager, smsLoggerService);

        }

    }
}


