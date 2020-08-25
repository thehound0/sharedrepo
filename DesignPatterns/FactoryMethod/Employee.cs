namespace DesignPatterns.FactoryMethod
{
    public class Employee
    {
        public decimal Bonus { get; internal set; }
        public decimal HourlyPay { get; internal set; }
        public int EmployeeTypeID { get; internal set; }
        public object HouseAllowance { get; internal set; }
        public decimal MedicalAllowance { get; internal set; }
    }
}
