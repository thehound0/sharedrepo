    namespace DesignPatterns.AbstractFactory
    {
        public class MAC : IBrand
        {
            public string GetBrand()
            {
                return Enumerations.Brands.APPLE.ToString();
            }
        }
    }

