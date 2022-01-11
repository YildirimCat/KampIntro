using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethodDemo
{
    internal class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli müşteri sisteme eklendi.");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli müşteri sistemden silindi!");
        }

        public void ListCustomers(Customer[] customers)
        {

            Console.WriteLine("Sistemdeki müşteriler:");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.Name);
            }
        }
    }
}
