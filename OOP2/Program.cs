using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Customer customer1 = new Customer();
            //customer1.Id = 1;
            //customer1.Name = "Tom";
            //customer1.Surname = "Bombadil";
            //customer1.IdentificationNo = "123143141";
            
            
            //Tom Bombadil gerçek bir kişi ve bir şirketi veya vergi numarası yok!
            //customer1.CompanyName = "????";
            //customer1.TaxNo = "??";


            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.Name = "Stannis";
            customer1.Surname = "Baratheon";
            customer1.CustomerNo = "12345";
            customer1.IdentificationNo = "31314123123";


            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "12346";
            customer2.TaxNo = "3123412313";
            customer2.CompanyName = "Microsoft";

            //Base class bir referans tutucudur.
            Customer customer3 = new CorporateCustomer();
            Customer customer4 = new IndividualCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            customerManager.Add(customer4);
        }

    }
}


