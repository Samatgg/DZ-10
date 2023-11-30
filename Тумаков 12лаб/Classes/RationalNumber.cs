using System;

namespace Тумаков_12лаб
{
    public class RationalNumber
    {
        private int numerator;
        private int denominator;

        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Знаменатель не может быть равен нулю!");
            }

            this.numerator = numerator;
            this.denominator = denominator;
        }

        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public static bool operator ==(RationalNumber rational1, RationalNumber rational2)
        {
            if (ReferenceEquals(rational1, rational2))
            {
                return true;
            }

            if (ReferenceEquals(rational1, null) || ReferenceEquals(rational2, null))
            {
                return false;
            }

            return (rational1.numerator * rational2.denominator) == (rational1.denominator * rational2.numerator);
        }

        public static bool operator !=(RationalNumber rational1, RationalNumber rational2)
        {
            return !(rational1 == rational2);
        }

        public static bool operator <(RationalNumber rational1, RationalNumber rational2)
        {
            return (rational1.numerator * rational2.denominator) < (rational1.denominator * rational2.numerator);
        }

        public static bool operator >(RationalNumber rational1, RationalNumber rational2)
        {
            return (rational1.numerator * rational2.denominator) > (rational1.denominator * rational2.numerator);
        }

        public static bool operator <=(RationalNumber rational1, RationalNumber rational2)
        {
            return (rational1.numerator * rational2.denominator) <= (rational1.denominator * rational2.numerator);
        }

        public static bool operator >=(RationalNumber rational1, RationalNumber rational2)
        {
            return (rational1.numerator * rational2.denominator) >= (rational1.denominator * rational2.numerator);
        }

        public static RationalNumber operator +(RationalNumber rational1, RationalNumber rational2)
        {
            int newNumerator = (rational1.numerator * rational2.denominator) + (rational2.numerator * rational1.denominator);
            int newDenominator = rational1.denominator * rational2.denominator;
            return new RationalNumber(newNumerator, newDenominator);
        }

        public static RationalNumber operator -(RationalNumber rational1, RationalNumber rational2)
        {
            int newNumerator = (rational1.numerator * rational2.denominator) - (rational2.numerator * rational1.denominator);
            int newDenominator = rational1.denominator * rational2.denominator;
            return new RationalNumber(newNumerator, newDenominator);
        }

        public static RationalNumber operator ++(RationalNumber rational)
        {
            return new RationalNumber(rational.numerator + rational.denominator, rational.denominator);
        }

        public static RationalNumber operator --(RationalNumber rational)
        {
            return new RationalNumber(rational.numerator - rational.denominator, rational.denominator);
        }

        public static implicit operator RationalNumber(int number)
        {
            return new RationalNumber(number, 1);
        }

        public static implicit operator RationalNumber(float number)
        {
            int denominator = 1;
            while (Math.Round(number * denominator) != number * denominator)
            {
                denominator *= 10;
            }

            return new RationalNumber((int)(number * denominator), denominator);
        }

        public static implicit operator RationalNumber(double number)
        {
            int denominator = 1;
            while (Math.Round(number * denominator) != number * denominator)
            {
                denominator *= 10;
            }

            return new RationalNumber((int)(number * denominator), denominator);
        }

        public static explicit operator int(RationalNumber rational)
        {
            return rational.numerator / rational.denominator;
        }

        public static explicit operator float(RationalNumber rational)
        {
            return (float)rational.numerator / rational.denominator;
        }

        public static explicit operator double(RationalNumber rational)
        {
            return (double)rational.numerator / rational.denominator;
        }

        public static RationalNumber operator *(RationalNumber rational1, RationalNumber rational2)
        {
            int newNumerator = rational1.numerator * rational2.numerator;
            int newDenominator = rational1.denominator * rational2.denominator;
            return new RationalNumber(newNumerator, newDenominator);
        }

        public static RationalNumber operator /(RationalNumber rational1, RationalNumber rational2)
        {
            int newNumerator = rational1.numerator * rational2.denominator;
            int newDenominator = rational1.denominator * rational2.numerator;
            return new RationalNumber(newNumerator, newDenominator);
        }

        public static RationalNumber operator %(RationalNumber rational1, RationalNumber rational2)
        {
            int newNumerator = (rational1.numerator * rational2.denominator) % (rational2.numerator * rational1.denominator);
            int newDenominator = rational1.denominator * rational2.denominator;
            return new RationalNumber(newNumerator, newDenominator);
        }
    }
}
