using System;

namespace DependencyInversionPrinciple
{
    public class Program
    {
        static void Main(string[] args)
        {
          new CustomerBl().getCustomerNameBl();
        }
    }

    public class CustomerDataAccessFactory
    {
        public static ICustomerDataAccess GetCustomerName()
        {
            return new CustomerDataAccess();
        }
    }

    public interface ICustomerDataAccess
    {
        public string getCustomerNameDataAccess();
    }

    public class CustomerDataAccess : ICustomerDataAccess
    {
        public CustomerDataAccess() { }
        public string getCustomerNameDataAccess()
        {
            return "customer name from data access";
        }
    }


    public class CustomerBl
    {
        public CustomerBl(){}

        public void getCustomerNameBl()
        {
            ICustomerDataAccess customerDataAccess = CustomerDataAccessFactory.GetCustomerName();
            Console.WriteLine(customerDataAccess.getCustomerNameDataAccess());
        }
    }
}