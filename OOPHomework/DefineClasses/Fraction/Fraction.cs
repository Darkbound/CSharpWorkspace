namespace Fraction
{
    using System;

    public class Fraction
    {
        private string fractValue;
        private decimal deciValue;
        private int numerator = int.MinValue;
        private int denominator = int.MinValue;

        public int Numerator 
        { 
            get
            {
                return this.numerator;
            }

            set
            {
                this.numerator = value;

                if (this.denominator != int.MinValue)
                {
                    this.fractValue = this.numerator.ToString() + @"/" + this.denominator.ToString();
                    this.deciValue = (decimal)this.numerator / this.denominator;
                }
            }
        }

        public int Denominator
        {
            get
            {
                return this.denominator;
            }

            set
            {
                this.denominator = value;

                if (this.numerator != int.MinValue)
                {
                    this.fractValue = this.numerator.ToString() + @"/" + this.denominator.ToString();
                    this.deciValue = (decimal)this.numerator / this.denominator;
                }
            }
        }

        public string FractValue 
        { 
            get
            {
                return this.fractValue;
            }
        }

        public decimal DeciValue
        {
            get
            {
                return this.deciValue;
            }
        }

        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {
            Fraction fract = new Fraction();

            if (fraction1.denominator == fraction2.denominator)
            {
                fract.Numerator = fraction1.numerator + fraction2.numerator;
                fract.Denominator = fraction1.denominator;
            }
            else
            {
                fract.Denominator = fraction1.denominator * fraction2.denominator;
                fract.Numerator = ((fract.Denominator / fraction1.denominator) * fraction1.numerator) + ((fract.Denominator / fraction2.denominator) * fraction2.numerator);
            }

            return fract;
        }

        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {
            Fraction fract = new Fraction();

            if (fraction1.denominator == fraction2.denominator)
            {
                fract.Numerator = fraction1.numerator - fraction2.numerator;
                fract.Denominator = fraction1.denominator;
            }
            else
            {
                fract.Denominator = fraction1.denominator * fraction2.denominator;
                fract.Numerator = ((fract.Denominator / fraction1.denominator) * fraction1.numerator) - (fract.Denominator / fraction2.denominator) * fraction2.numerator;
            }

            return fract;
        }

        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            Fraction fract = new Fraction();

            fract.Numerator = fraction1.numerator * fraction2.numerator;
            fract.Denominator = fraction1.denominator * fraction2.denominator;

            return fract;
        }

        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            Fraction fract = new Fraction();

            fract.Numerator = fraction1.numerator * fraction2.denominator;
            fract.Denominator = fraction1.denominator * fraction2.numerator;

            return fract;
        }
    }
}
