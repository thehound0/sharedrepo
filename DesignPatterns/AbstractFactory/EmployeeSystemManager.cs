using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.AbstractFactory
{
    public class EmployeeSystemManager
    {
        IComputerFactory _IComputerFactory;
        public EmployeeSystemManager(IComputerFactory iComputerFactory)
        {
            IComputerFactory = iComputerFactory;
        }

        public IComputerFactory IComputerFactory { get => _IComputerFactory; set => _IComputerFactory = value; }

        public string GetSystemDetails()
        {
            IBrand brand = IComputerFactory.Brand();
            IProcessor processor = IComputerFactory.Processor();
            ISystemType systemType = IComputerFactory.SystemType();
            string returnValue = string.Format("{0} {1} {2}", brand.GetBrand(),
                systemType.GetSystemType(), processor.GetProcessor());
            return returnValue;
        }
    }
}

