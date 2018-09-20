// Fig. 12.17: ComplexNumber.cs
// Class that overloads operators for adding, subtracting
// and multiplying complex numbers.
	using System;

public class ComplexNumber
{
    // read-only property that gets the real component
    public double Real { get; private set; }

    // read-only property that gets the imaginary component
    public double Imaginary { get; private set; }

    // constructor
    public ComplexNumber(double a, double b)
    {
        Real = a;
        Imaginary = b;
    } // end constructor

    // return string representation of ComplexNumber
    public override string ToString()
    {
        return string.Format("({0} {1} {2}i)",
           Real, (Imaginary < 0 ? "-" : "+"), Math.Abs(Imaginary));
    } // end method ToString

    // overload the addition operator
    public static ComplexNumber operator +(
   ComplexNumber x, ComplexNumber y)
    {
        return new ComplexNumber(x.Real + y.Real,
           x.Imaginary + y.Imaginary);
    } // end operator +                          

    static void Main(String[] args)
    {
        Console.WriteLine("ComplexNumber ......");

        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();


    }

}
