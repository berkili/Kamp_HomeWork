using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        List<Customer> customerList = new List<Customer>();

        public void CustomerAdd(Customer customer)
        {
            customerList.Add(customer);
            Console.WriteLine("{0} adlı müşteri eklendi.", customer.CustomerNameSurname);
        }
        public void CustomerAdd(Customer[] customers)
        {
            foreach (Customer customer in customers)
            {
                customerList.Add(customer);
                Console.WriteLine("{0} adlı müşteri eklendi.", customer.CustomerNameSurname);
            }
        }
        public void CustomerRemove(Customer customer)
        {
            Console.WriteLine("{0} - {1} adlı müşteri silindi.", customer.CustomerId, customer.CustomerNameSurname);
            customerList.Remove(customer);
        }
        public void CustomerUpdate(Customer customer)
        {
            var cs = customerList.FindIndex(m => m.CustomerId == customer.CustomerId);
            customerList[cs] = customer;
            Console.WriteLine("{0} - {1} adlı müşterinin bilgileri güncellendi.", customer.CustomerId, customer.CustomerNameSurname);
        }
        public void CustomerList()
        {
            Console.WriteLine("\n==========================================================================================");
            Console.WriteLine("************************************ MÜŞTERİ  LİSTESİ ************************************");
            Console.WriteLine("==========================================================================================\n\n");
            Console.WriteLine("Müşteri ID        \tMüşteri Adı-Soyadı\tHesapNo            \tBakiye            ");
            Console.WriteLine("==================\t==================\t==================\t==================");

            foreach (Customer customer in customerList)
            {
                Console.WriteLine("     " + customer.CustomerId + "            \t"
                    + customer.CustomerNameSurname + "        \t"
                    + customer.CustomerAccountNo + "             \t"
                    + customer.CustomerAccountBalance);
            }
            Console.WriteLine("==========================================================================================");
        }
    }
}
