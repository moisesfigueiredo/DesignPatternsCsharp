namespace Adapter
{
    public class TemperatureClassAdapter: Temperature
    {
        public override void SetValue(double value)
        {

            base.SetValue(value*9/5+32);
        }

        public override double GetValue()
        {
            return (base.GetValue()-32) * 5 / 9;
        }

        public double GetValueInFahrenheit()
        {
            return base.GetValue();
        }
    }
}
