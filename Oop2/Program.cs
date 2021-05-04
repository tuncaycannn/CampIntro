using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {

            IndividualCustomer individualCustomer = new IndividualCustomer();
            individualCustomer.CustomerNo = "1234";
            individualCustomer.Id = 1;
            individualCustomer.Name = "Tuncay";
            individualCustomer.Surname = "Can";
            individualCustomer.TcNo = "225445455551";

            InstitutionalCustomer institutionalCustomer = new InstitutionalCustomer();
            institutionalCustomer.Id = 2;
            institutionalCustomer.InstitutionalName = "Kardeşler Kundura";
            institutionalCustomer.VergiNo = "23121515532";
            institutionalCustomer.CustomerNo = "25515";

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new InstitutionalCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(individualCustomer);
            customerManager.Add(institutionalCustomer);
            customerManager.Add(customer3);
            customerManager.Add(customer4);

        }
    }
}
