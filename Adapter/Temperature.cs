namespace Adapter;

public class Temperature
{
    private double value;
 
    public virtual void SetValue(double value)
    {
        this.value = value;
    }

    public virtual double GetValue()
    {
        return this.value;
    }
}
