namespace DesignPatterns.AbstractFactory
{
    public class DellFactory : IComputerFactory
        {
            public IBrand Brand()
            {
                return new DELL();
            }

            public IProcessor Processor()
            {
                return new I5();
            }

            public virtual ISystemType SystemType()
            {
                return new Desktop();
            }
        }
}

