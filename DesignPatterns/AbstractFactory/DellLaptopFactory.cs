    namespace DesignPatterns.AbstractFactory
    {
        public class DellLaptopFactory : DellFactory
        {
            public override ISystemType SystemType()
            {
                return new Laptop();
            }
        }
    }

