
    namespace DesignPatterns.AbstractFactory
    {
        public class MACFactory : IComputerFactory
        {
            public IBrand Brand()
            {
                return new MAC();
            }

            public IProcessor Processor()
            {
                return new I7();
            }

            public virtual ISystemType SystemType()
            {
                return new Desktop();
            }
        }
    }

