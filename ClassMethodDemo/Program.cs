using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.CustomerId = 1;
            customer.CustomerNameSurname = "Ali YILDIZ";
            customer.CustomerAccountNo = 2723589;
            customer.CustomerAccountBalance = 600;

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerNameSurname = "Ayşe YILDIZ";
            customer2.CustomerAccountNo = 2723590;
            customer2.CustomerAccountBalance = 102000;

            Customer customer3 = new Customer();
            customer3.CustomerId = 3;
            customer3.CustomerNameSurname = "Erkin YILMAZ";
            customer3.CustomerAccountNo = 2723591;
            customer3.CustomerAccountBalance = 350000;

            Customer customer4 = new Customer();
            customer4.CustomerId = 4;
            customer4.CustomerNameSurname = "Ahmet KUŞ";
            customer4.CustomerAccountNo = 2723592;
            customer4.CustomerAccountBalance = 359000;

            Customer[] customers = new Customer[] { customer, customer2, customer3 };

            CustomerManager customerManager = new CustomerManager();
            customerManager.CustomerAdd(customers); //çoklu müşteri ekleme method overloading ile
            customerManager.CustomerAdd(customer4); //tekli müşteri ekleme method overloading ile

            customerManager.CustomerList();
            customerManager.CustomerRemove(customer2);
            customerManager.CustomerList();
            customer.CustomerAccountBalance += 255;
            customerManager.CustomerUpdate(customer);
            customerManager.CustomerList();
        }
    }
}
