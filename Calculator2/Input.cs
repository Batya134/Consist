using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2
{
    internal class Input
    {
        public static double _valueFirst;
        public static double _valueSecond;
        public static string _symbol;

        public static void InputFirstValue()
        {
            while (true)
            {

                Console.WriteLine("Введите числовое значение:");
                var isCorrect = Double.TryParse(Console.ReadLine(), out _valueFirst);

                if (isCorrect == false)
                    Console.WriteLine("Введённое значение не является числом!");
                else break;
            }
        }
        public static void InputSecondValue()
        {
            while (true)
            {
                Console.WriteLine("Введите числовое значение:");
                var isCorrect = Double.TryParse(Console.ReadLine(), out _valueSecond);

                if (isCorrect == false)
                    Console.WriteLine("Введённое значение не является числом!");
                else break;
            }
        }
        public static void InputSymbol()
        {
            Console.WriteLine("Введите знак арифметического действия:");
            _symbol = Console.ReadLine();
        }
    }
}
