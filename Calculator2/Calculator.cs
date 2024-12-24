using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    internal class Calculator
    {
        private static double _result;

        public static double Result
        {
            get { return _result; }
            set { _result = value; }
        }

        public Calculator(double startVAlue)
        {
            _result = startVAlue;
        }

        public static double Summary(double valueSecond)
        {
            _result = _result + valueSecond;
            return _result;
        }

        public static double Difference(double valueSecond)
        {
            _result = _result - valueSecond;
            return _result;
        }

        public static double Multiplication(double valueSecond)
        {
            _result = _result * valueSecond;
            return _result;
        }

        public static double Division(double valueSecond)
        {
            _result = _result / valueSecond;
            return _result;
        }

        public static double Percent(double valueSecond)
        {
            _result = (_result / 100) * valueSecond;
            return _result;
        }

        public static double Power(double valueSecond)
        {
            _result = Math.Pow(_result, valueSecond);
            return _result;
        }

        public static double Sqrt()
        {
            _result = Math.Sqrt(_result);
            return _result;
        }

    }
}
   
