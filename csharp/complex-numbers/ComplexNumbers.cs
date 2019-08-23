using System;

public struct ComplexNumber
{
    private double real;
    private double imaginary;

    public ComplexNumber(double real, double imaginary)
    {
        this.real = real;
        this.imaginary = imaginary;
    }

    public double Real() => this.real;

    public double Imaginary() => this.imaginary;

    public ComplexNumber Mul(ComplexNumber other)
    {
        var a = this.real * other.real;
        var b = (this.imaginary * other.imaginary) * -1;
        var i = this.real * other.imaginary + this.imaginary * other.real;

        return new ComplexNumber(a + b, i);
    }

    public ComplexNumber Add(ComplexNumber other) => new ComplexNumber(this.real + other.real, this.imaginary + other.imaginary);

    public ComplexNumber Sub(ComplexNumber other) => new ComplexNumber(this.real - other.real, this.imaginary - other.imaginary);

    public ComplexNumber Div(ComplexNumber other)
    {
        var complex1 = this.Mul(new ComplexNumber(this.real, this.imaginary * -1));
        var complex2 = other.Mul(new ComplexNumber(this.real, this.imaginary * -1));

        
        return new ComplexNumber(complex1.real + complex2.real, complex1.imaginary + complex2.imaginary);
    }

    public double Abs() => Math.Pow((Math.Pow(this.real, 2) + Math.Pow(this.imaginary, 2)), 0.5);

    public ComplexNumber Conjugate()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
    
    public ComplexNumber Exp()
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}