using System;

namespace CalcLibrary
{
    interface IMathLibrary
    {
        double Addition(double a, double b);
        double Subtraction(double a, double b);
        double Multiplication(double a, double b);
        double Division(double a, double b);
    }

    public class SimpleCalculator : IMathLibrary
    {
        double result = 0;
        public double Addition(double a, double b)
        {
            result = a + b;
            return result;
        }

        public double Subtraction(double a, double b)
        {
            result = a - b;
            return result;
        }

        public double Multiplication(double a, double b)
        {
            result = a * b;
            return result;
        }

        public double Division(double a, double b)
        {
            if (b == 0)
                throw new ArgumentException("Second Parameter Can't be Zero");
            result = a / b;
            return result;
        }

        public void AllClear()
        {
            result = 0;
        }

        public double GetResult
        {
            get { return result; }            
        }
    }
}
