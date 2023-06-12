
using static System.Runtime.InteropServices.JavaScript.JSType;
using Object = System.Object;

public struct Meters
{
    private double value;


    public Meters(double val)
    {
        value = val;
    }

    public double Value
    {
        get { return value; }
    }

    public static Meters operator +(Meters obj)
    {
        Meters m = new (obj.value + 1.0);
        return m;
    }

    public static Meters operator -(Meters obj)
    {
        Meters m = new (obj.value - 1.0);
        return m;
    }

    public static bool operator ==(Meters obj1, Meters obj2)
    {
        return obj1.value == obj2.value;
    }

    public static bool operator !=(Meters obj1, Meters obj2)
    {
        return obj1.value != obj2.value;
    }

    public static bool operator >(Meters obj1, Meters obj2)
    {
        return obj1.value > obj2.value;
    }

    public static bool operator <(Meters obj1, Meters obj2)
    {
        return obj1.value < obj2.value;
    }

    public static bool operator >=(Meters obj1, Meters obj2)
    {
        return obj1.value >= obj2.value;
    }

    public static bool operator <=(Meters obj1, Meters obj2)
    {
        return obj1.value <= obj2.value;
    }

    public static Meters operator +(Meters obj1, Meters obj2)
    {
        Meters m = new(obj1.value + obj2.value);
        return m;
    }

    public static Meters operator +(Meters obj1, double obj2)
    {
        Meters m = new(obj1.value + obj2);
        return m;
    }

    public static Meters operator +(double obj1, Meters obj2)
    {
        Meters m = new(obj1 + obj2.value);
        return m;
    }

    public static Meters operator +(Meters obj1, Inches obj2)
    {
        Meters m = new(obj1.value + 0.025*obj2.Value);
        return m;
    }

    //public static Meters operator +(Inches obj1, Meters obj2)
    //{
    //    Meters m = new(0.025 * obj1.Value + obj2.value);
    //    return m;
    //}

    public static Meters operator -(Meters obj1, Meters obj2)
    {
        Meters m = new(obj1.value - obj2.value);
        return m;
    }

    public static Meters operator -(Meters obj1, double obj2)
    {
        Meters m = new(obj1.value - obj2);
        return m;
    }

    public static Meters operator -(double obj1, Meters obj2)
    {
        Meters m = new(obj1 - obj2.value);
        return m;
    }

    public static Meters operator -(Meters obj1, Inches obj2)
    {
        Meters m = new(obj1.value - 0.025 * obj2.Value);
        return m;
    }

    //public static Meters operator -(Inches obj1, Meters obj2)
    //{
    //    Meters m = new(0.025 * obj1.Value - obj2.value);
    //    return m;
    //}

    public static Meters operator *(Meters obj1, Meters obj2)
    {
        Meters m = new(obj1.value * obj2.value);
        return m;
    }

    public static Meters operator *(Meters obj1, double obj2)
    {
        Meters m = new(obj1.value * obj2);
        return m;
    }

    public static Meters operator *(double obj1, Meters obj2)
    {
        Meters m = new(obj1 * obj2.value);
        return m;
    }

    public static Meters operator *(Meters obj1, Inches obj2)
    {
        Meters m = new(obj1.value * 0.025 * obj2.Value);
        return m;
    }

    //public static Meters operator *(Inches obj1, Meters obj2)
    //{
    //    Meters m = new(0.025 * obj1.Value * obj2.value);
    //    return m;
    //}

    public static Meters operator /(Meters obj1, Meters obj2)
    {
        Meters m = new(obj1.value / obj2.value);
        return m;
    }

    public static Meters operator /(Meters obj1, double obj2)
    {
        Meters m = new(obj1.value / obj2);
        return m;
    }

    public static Meters operator /(double obj1, Meters obj2)
    {
        Meters m = new(obj1 / obj2.value);
        return m;
    }

    public static Meters operator /(Meters obj1, Inches obj2)
    {
        Meters m = new(obj1.value / (0.025 * obj2.Value));
        return m;
    }

    //public static Meters operator /(Inches obj1, Meters obj2)
    //{
    //    Meters m = new(0.025 * obj1.Value / obj2.value);
    //    return m;
    //}

    public static explicit operator Meters(Inches obj)
    {
        Meters m = new(0.025 * obj.Value);
        return m;
    }

    public static implicit operator Meters(double obj)
    {
        Meters m = new(obj);
        return m;
    }

    public override string ToString()
    {
        return $"{value} m";
    }

    public override bool Equals(Object obj)
    {
        if (obj == null || !(obj is Meters))
            return false;
        else
            return value == ((Meters)obj).value;
    }

    public override int GetHashCode()
    {
        return (int)value;
    }


}