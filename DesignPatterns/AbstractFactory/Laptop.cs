    namespace DesignPatterns.AbstractFactory
    {
        public class Laptop : ISystemType
        {
            public string GetSystemType()
            {
                return Enumerations.ComputerTypes.Laptop.ToString();
            }
        }
    }
