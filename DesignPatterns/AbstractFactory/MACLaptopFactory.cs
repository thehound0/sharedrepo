    namespace DesignPatterns.AbstractFactory
    {
        public class MACLaptopFactory : MACFactory
        {

            public override ISystemType SystemType()
            {
                return new Laptop();
            }
        }
    }

