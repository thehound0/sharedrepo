﻿namespace DesignPatterns.Decorator
{
    public sealed class Suzuki : ICar
    {
        public string Make
        {
            get { return "Sedan"; }
        }
        public double GetPrice()
        {
            return 1000000;
        }
    }
}
