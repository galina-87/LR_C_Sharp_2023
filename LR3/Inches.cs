
using static System.Runtime.InteropServices.JavaScript.JSType;
using Object = System.Object;

public struct Inches
{
    private double value;


    public Inches(double val)
    {
        value = val;
    }

    public double Value
    {
        get { return value; }
    }

    public static Inches operator +(Inches obj)
    {
        Inches inch = new(obj.value + 1.0);
        return inch;
    }

    public static Inches operator -(Inches obj)
    {
        Inches inch = new(obj.value - 1.0);
        return inch;
    }

    public static bool operator ==(Inches obj1, Inches obj2)
    {
        return obj1.value == obj2.value;
    }

    public static bool operator !=(Inches obj1, Inches obj2)
    {
        return obj1.value != obj2.value;
    }

    public static bool operator >(Inches obj1, Inches obj2)
    {
        return obj1.value > obj2.value;
    }

    public static bool operator <(Inches obj1, Inches obj2)
    {
        return obj1.value < obj2.value;
    }

    public static bool operator >=(Inches obj1, Inches obj2)
    {
        return obj1.value >= obj2.value;
    }

    public static bool operator <=(Inches obj1, Inches obj2)
    {
        return obj1.value <= obj2.value;
    }

    public static Inches operator +(Inches obj1, Inches obj2)
    {
        Inches inch = new(obj1.value + obj2.value);
        return inch;
    }

    public static Inches operator +(Inches obj1, double obj2)
    {
        Inches inch = new(obj1.value + obj2);
        return inch;
    }

    public static Inches operator +(double obj1, Inches obj2)
    {
        Inches inch = new(obj1 + obj2.value);
        return inch;
    }

    //public static Inches operator +(Meters obj1, Inches obj2)
    //{
    //    Inches inch = new(39.37*obj1.Value + obj2.value);
    //    return inch;
    //}

    public static Inches operator +(Inches obj1, Meters obj2)
    {
        Inches inch = new(obj1.value + 39.37 * obj2.Value);
        return inch;
    }

    public static Inches operator -(Inches obj1, Inches obj2)
    {
        Inches inch = new(obj1.value - obj2.value);
        return inch;
    }

    public static Inches operator -(Inches obj1, double obj2)
    {
        Inches inch = new(obj1.value - obj2);
        return inch;
    }

    public static Inches operator -(double obj1, Inches obj2)
    {
        Inches inch = new(obj1 - obj2.value);
        return inch;
    }

    //public static Inches operator -(Meters obj1, Inches obj2)
    //{
    //    Inches inch = new(39.37 * obj1.Value - obj2.value);
    //    return inch;
    //}

    public static Inches operator -(Inches obj1, Meters obj2)
    {
        Inches inch = new(obj1.value - 39.37 * obj2.Value);
        return inch;
    }

    public static Inches operator *(Inches obj1, Inches obj2)
    {
        Inches inch = new(obj1.value * obj2.value);
        return inch;
    }

    public static Inches operator *(Inches obj1, double obj2)
    {
        Inches inch = new(obj1.value * obj2);
        return inch;
    }

    public static Inches operator *(double obj1, Inches obj2)
    {
        Inches inch = new(obj1 * obj2.value);
        return inch;
    }

    //public static Inches operator *(Meters obj1, Inches obj2)
    //{
    //    Inches inch = new(39.37 * obj1.Value * obj2.value);
    //    return inch;
    //}

    public static Inches operator *(Inches obj1, Meters obj2)
    {
        Inches inch = new(obj1.value * 39.37 * obj2.Value);
        return inch;
    }

    public static Inches operator /(Inches obj1, Inches obj2)
    {
        Inches inch = new(obj1.value / obj2.value);
        return inch;
    }

    public static Inches operator /(Inches obj1, double obj2)
    {
        Inches inch = new(obj1.value / obj2);
        return inch;
    }

    public static Inches operator /(double obj1, Inches obj2)
    {
        Inches inch = new(obj1 / obj2.value);
        return inch;
    }

    public static Inches operator /(Inches obj1, Meters obj2)
    {
        Inches inch = new(obj1.value / (39.37 * obj2.Value));
        return inch;
    }

    public static explicit operator Inches(Meters obj)
    {
        Inches inch = new(39.37 * obj.Value);
        return inch;
    }

    public static implicit operator Inches(double obj)
    {
        Inches inch = new(obj);
        return inch;
    }

    public override string ToString()
    {
        return $"{value} i";
    }

    public override bool Equals(Object obj)
    {
        if (obj == null || !(obj is Inches))
            return false;
        else
            return value == ((Inches)obj).value;
    }

    public override int GetHashCode()
    {
        return (int)value;
    }


}