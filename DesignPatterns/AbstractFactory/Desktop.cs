
namespace DesignPatterns.AbstractFactory
{
    public class Desktop : ISystemType
    {
        public string GetSystemType()
        {
            return Enumerations.ComputerTypes.Desktop.ToString();
        }
    }
}
