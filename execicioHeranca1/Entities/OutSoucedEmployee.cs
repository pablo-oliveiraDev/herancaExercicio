

namespace execicioHeranca1.Entities
{
    class OutSoucedEmployee : Employee
    {
        public double AdicionalCharge { get; set; }

        public OutSoucedEmployee()
        {

        }
        public OutSoucedEmployee(string name, int hours, double valuePerHour, double adicinalCharge) : base( name,  hours,  valuePerHour)
        {
            AdicionalCharge = adicinalCharge;
        }

        public override double Payment()
        {
            return base.Payment() + AdicionalCharge * 1.1;
        }
    }
}
