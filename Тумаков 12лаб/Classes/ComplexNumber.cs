
namespace Тумаков_12лаб.Classes
{
    public class ComplexNumber
    {
        public double RealPart { get; }
        public double ImaginaryPart { get; }

        public ComplexNumber(double realPart, double imaginaryPart)
        {
            RealPart = realPart;
            ImaginaryPart = imaginaryPart;
        }

        public override string ToString()
        {
            return $"{RealPart} + {ImaginaryPart}i";
        }

        public static ComplexNumber operator +(ComplexNumber complex1, ComplexNumber complex2)
        {
            double realPart = complex1.RealPart + complex2.RealPart;
            double imaginaryPart = complex1.ImaginaryPart + complex2.ImaginaryPart;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static ComplexNumber operator -(ComplexNumber complex1, ComplexNumber complex2)
        {
            double realPart = complex1.RealPart - complex2.RealPart;
            double imaginaryPart = complex1.ImaginaryPart - complex2.ImaginaryPart;
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static ComplexNumber operator *(ComplexNumber complex1, ComplexNumber complex2)
        {
            double realPart = (complex1.RealPart * complex2.RealPart) - (complex1.ImaginaryPart * complex2.ImaginaryPart);
            double imaginaryPart = (complex1.RealPart * complex2.ImaginaryPart) + (complex1.ImaginaryPart * complex2.RealPart);
            return new ComplexNumber(realPart, imaginaryPart);
        }

        public static bool operator ==(ComplexNumber complex1, ComplexNumber complex2)
        {
            if (ReferenceEquals(complex1, complex2))
            {
                return true;
            }

            if (ReferenceEquals(complex1, null) || ReferenceEquals(complex2, null))
            {
                return false;
            }

            return complex1.RealPart == complex2.RealPart && complex1.ImaginaryPart == complex2.ImaginaryPart;
        }

        public static bool operator !=(ComplexNumber complex1, ComplexNumber complex2)
        {
            return !(complex1 == complex2);
        }
    }
}
