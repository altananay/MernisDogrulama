using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Concrete;
using InterfaceAbstractDemo.Entities;
using InterfaceAbstractDemo.Adapters;
using System;

namespace InterfaceAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager(new MernisServiceAdapter());
            //customerManager.Save(new Customer { DateOfBirth = new DateTime(2000, 4,10), FirstName="Suzan", LastName = "YILMAZ",NationalityId="10877687846" });
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2000, 6, 2), FirstName = "Cumhur Utku", LastName = "ATAK", NationalityId = "15838659016" });
        }
    }
}
