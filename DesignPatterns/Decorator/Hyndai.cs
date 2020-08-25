namespace DesignPatterns.Decorator
{
    public sealed class Huyndai : ICar
    {
        public string Make
        {
            get { return "HatchBack"; }
        }
        public double GetPrice()
        {
            return 800000;
        }
    }
}
