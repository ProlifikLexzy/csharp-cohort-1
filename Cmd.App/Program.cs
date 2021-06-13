using Cmd.App.Banking;
using Cmd.App.Company;
using Cmd.App.Generics;
using System;

namespace Program
{
    public class Tester
    {
        public static void Main()
        {

            var employeeManager = new EmployeeManager();
            employeeManager.Create(new Employee());

            var customerManager = new CustomerManager();
            customerManager.Update(new Customer());

            var empManager = new Manager<Employee>();
            employeeManager.Create(new());
            employeeManager.Update(new());

            var custManager = new Manager<Customer>();
            custManager.Create(new());
            custManager.Update(new());

            var savingsManager = new Manager<SavingAccount>();
            savingsManager.Create(new());

            var vendorManager = new Manager<Vendor>();
            vendorManager.Create(new());

            var submision = new VendorSubmission();
            custManager.Submit<Customer, Quote>(new());
            empManager.Submit(new Invoice());
            vendorManager.Submit<Vendor, Receipt>(new Receipt());

            Console.WriteLine("End of Main");
        }

        public static void WriteLine(object obj)
        {
            string value = obj.ToString();

            Console.WriteLine(value);
        }

    }
}
