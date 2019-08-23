using System;
using System.Diagnostics;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r) => r.Expreal(realNumber);
}

public struct RationalNumber
{
    public int numerator { get; }
    public int denominator { get; }

    public RationalNumber(int numerator, int denominator)
    {
        this.numerator = numerator;
        this.denominator = denominator;
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        int denominator = r1.denominator != r2.denominator ? (r1.denominator * r2.denominator) : 1;

        int numerator = (denominator / r1.denominator) * r1.numerator + (denominator / r2.denominator) * r2.numerator;
        
        return new RationalNumber(numerator, denominator);     
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        int denominator = r1.denominator != r2.denominator ? r1.denominator * r2.denominator : 1;

        int numerator = (denominator / r1.denominator) * r1.numerator - (denominator / r2.denominator) * r2.numerator;
        
        return new RationalNumber(numerator, denominator); 
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        int denominator = r1.denominator * r2.denominator;
        int numerator = r1.numerator * r2.numerator;

        return new RationalNumber(numerator, denominator).Reduce();
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {   
        int denominator = r1.denominator * r2.numerator;
        int numerator = r1.numerator * r2.denominator;

        if (r2.numerator < 0)
        {
            denominator = r1.denominator * (r2.numerator * -1);
            numerator = r1.numerator * (r2.denominator * -1);  
        }

        return new RationalNumber(numerator, denominator).Reduce();
    }

    public RationalNumber Abs()
    {
        // With Math.Abs
        // return new RationalNumber(Math.Abs(this.numerator), Math.Abs(this.denominator));

        var tempNumerator = this.numerator;
        var tempDenominator = this.denominator;

        if (this.numerator < 0)
        {
            tempNumerator *= -1;
        }

        if (this.denominator < 0)
        {
            tempDenominator *= -1;
        }

        return new RationalNumber(tempNumerator, tempDenominator);
    }

    public RationalNumber Reduce()
    {
        int lenght = this.numerator > this.denominator ? this.numerator : this.denominator;
        var tempDenominator = this.denominator;
        var tempNumerator = this.numerator;

        for (int i = lenght; i >= 1; i--)
        {
            if(tempDenominator % i == 0 && tempNumerator % i == 0)
            {
                tempDenominator = tempDenominator / i;
                tempNumerator = tempNumerator / i;
            }
        }

        if (this.denominator < 0)
        {
            return new RationalNumber(-tempNumerator, -tempDenominator);
        }

        return new RationalNumber(tempNumerator, tempDenominator);
    }

    public RationalNumber Exprational(int power)
    {
        // With Math.Pow()
        //return new RationalNumber((int)Math.Pow(this.numerator, power), (int)Math.Pow(this.denominator, power));
        
        var tempNumerator = this.numerator;
        var tempDenominator = this.denominator;

        if (power > 0)
        {
            for (int i = 1; i < power; ++i)
            {
                tempNumerator *= this.numerator;
                tempDenominator *= this.denominator;
            }
        }
        else if (power < 0)
        {
            for (int i = -1; i > power; --i)
            {
                tempNumerator /= this.numerator;
                tempDenominator /= this.denominator;
            }
        }
        else
        {
            tempNumerator = 1;
            tempDenominator = 1;
        }

        return new RationalNumber(tempNumerator, tempDenominator);
    }

    public double Expreal(int baseNumber) => Math.Pow(baseNumber, (double)numerator / (double)denominator);
}