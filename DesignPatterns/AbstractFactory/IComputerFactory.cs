    namespace DesignPatterns.AbstractFactory
    {
        public interface IComputerFactory
        {
            IProcessor Processor();
            IBrand Brand();
            ISystemType SystemType();
        }
    }
