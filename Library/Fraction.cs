namespace Laboratorna8;

public class Fraction
{
    private int _numerator;
    private int _denominator;
    
    public int Numerator => _numerator;
    public int Denominator => _denominator;

    public Fraction()
    {
        _denominator = 0;
        _numerator = 0;
    }

    public Fraction(Fraction other)
    {
        _numerator = other._numerator;
        _denominator = other._denominator;
    }

    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

        public Fraction Reduce()
    {
        int gcd = GCD(Math.Abs(_numerator), _denominator);
        _numerator /= gcd;
        _denominator /= gcd;
        return this;
    }

    private static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    public static Fraction operator +(Fraction fraction)
    {
        return new Fraction(Math.Abs(fraction._numerator), fraction._denominator);
    }

    public static Fraction operator -(Fraction fraction)
    {
        return new Fraction(-fraction._numerator, fraction._denominator);
    }

    public static Fraction operator +(Fraction left, Fraction right)
    {
        int newNumerator = left._numerator * right._denominator + right._numerator * left._denominator;
        int newDenominator = left._denominator * right._denominator;
        return new Fraction(newNumerator, newDenominator).Reduce();
    }

    public static Fraction operator -(Fraction left, Fraction right)
    {
        int newNumerator = left._numerator * right._denominator - right._numerator * left._denominator;
        int newDenominator = left._denominator * right._denominator;
        return new Fraction(newNumerator, newDenominator).Reduce();
    }

    public static Fraction operator *(Fraction left, Fraction right)
    {
        int newNumerator = left._numerator * right._numerator;
        int newDenominator = left._denominator * right._denominator;
        return new Fraction(newNumerator, newDenominator).Reduce();
    }

    public static Fraction operator /(Fraction left, Fraction right)
    {
        if (right._numerator == 0)
            throw new DivideByZeroException("Cannot divide by a fraction with numerator 0.");
        
        int newNumerator = left._numerator * right._denominator;
        int newDenominator = left._denominator * Math.Abs(right._numerator);
        int sign = right._numerator < 0 ? -1 : 1;
        return new Fraction(sign * newNumerator, newDenominator).Reduce();
    }

    public static bool operator >(Fraction left, Fraction right)
    {
        return left._numerator * right._denominator > right._numerator * left._denominator;
    }

    public static bool operator <(Fraction left, Fraction right)
    {
        return left._numerator * right._denominator < right._numerator * left._denominator;
    }

    public static bool operator >=(Fraction left, Fraction right)
    {
        return left > right || left == right;
    }

    public static bool operator <=(Fraction left, Fraction right)
    {
        return left < right || left == right;
    }

    public static bool operator ==(Fraction left, Fraction right)
    {
        if (ReferenceEquals(left, right)) return true;
        if (ReferenceEquals(left, null) || ReferenceEquals(right, null)) return false;

        left = left.Reduce();
        right = right.Reduce();
        return left._numerator == right._numerator && left._denominator == right._denominator;
    }

    public double Doooble()
    {
        if (_denominator == 0)
        throw new DivideByZeroException("Denominator cannot be zero.");
        
        return (double)_numerator / _denominator;
    }

    public static bool operator !=(Fraction left, Fraction right)
    {
        return !(left == right);
    }


    

    public override string ToString()
    {
        return $"{_numerator}/{_denominator}";
    }
}

