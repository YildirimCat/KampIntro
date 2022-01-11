using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "John";
            customer1.SurName = "Nash";
            customer1.Id = 1;
            customer1.Age = 68;

            Customer customer2 = new Customer();
            customer2.Name = "Müslüm";
            customer2.SurName = "Gürses";
            customer2.Id = 2;
            customer2.Age = 34;

            Customer customer3 = new Customer();
            customer3.Name = "Davos";
            customer3.SurName = "Seaworth";
            customer3.Id = 3;
            customer3.Age = 45;

            Customer[] customers = new Customer[] { customer1,customer2,customer3};

            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);
            customerManager.AddCustomer(customer3);

            customerManager.ListCustomers(customers);
            
            customerManager.DeleteCustomer(customer1);

        }
        
       
    }
}
