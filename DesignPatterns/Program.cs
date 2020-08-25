using DesignPatterns.AbstractFactory;
using DesignPatterns.Decorator;
using System;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            #region factory method pattern
            //contract employee
            var employee = new FactoryMethod.Employee
            {
                //EmployeeTypeID = 1,
                EmployeeTypeID = 2,
                Bonus = 100,
                HourlyPay = 40,
                HouseAllowance = 40,
                MedicalAllowance = 30
            };
            BaseEmployeeFactory empFactory =
                   new EmployeeManagerFactory().CreateFactory(employee);
            empFactory.ApplySalary();
            Console.WriteLine($"Employee: {employee.EmployeeTypeID}{Environment.NewLine} " +
                $"House Allowance: {employee.HouseAllowance}{Environment.NewLine} " +
                $"Medical Allowance: {employee.MedicalAllowance}");
            #endregion

            #region Abstract Factory Method
            var abstractFactoryEmployee = new Employee { };
            IComputerFactory factory = new EmployeeSystemFactory().Create(abstractFactoryEmployee);
            EmployeeSystemManager manager = new EmployeeSystemManager(factory);
            abstractFactoryEmployee.ComputerDetails = manager.GetSystemDetails();
            Console.WriteLine($"Computer Details: {abstractFactoryEmployee.ComputerDetails}{Environment.NewLine} " +
                $"Job Description: {abstractFactoryEmployee.JobDescription}");
            #endregion

            #region Singleton Pattern
            /*
           * Assuming Singleton is created from employee class
           * we refer to the GetInstance property from the Singleton class
           */
            DesignPatterns.Singleton.Singleton fromEmployee = DesignPatterns.Singleton.Singleton.GetInstance;
            fromEmployee.PrintDetails("From Employee");
            /*
             * Assuming Singleton is created from student class
             * we refer to the GetInstance property from the Singleton class
             */
            DesignPatterns.Singleton.Singleton fromStudent = DesignPatterns.Singleton.Singleton.GetInstance;
            fromStudent.PrintDetails("From Student");
            #endregion

            #region Decorator Pattern
            ICar car = new Suzuki();
            CarDecorator decorator = new OfferPrice(car);
            Console.WriteLine(string.Format("Make :{0}  Price:{1} " +
                "DiscountPrice : {2}"
                , decorator.Make, decorator.GetPrice().ToString(),
                decorator.GetDiscountedPrice().ToString()));
            #endregion

            Console.ReadLine();
        }
    }
}
