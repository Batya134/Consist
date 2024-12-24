// See https://aka.ms/new-console-template for more information
using Calculator2;

StartProrgam();

static void PrintMenu()
{
    Console.WriteLine("Доступные операции:" +
                       "\n (+) Сложение" +
                       "\n (-) Разность" +
                       "\n (*) Умножение" +
                       "\n (/) Деление" +
                       "\n (%) Процент от числа" +
                       "\n (p) Возведение в степень" +
                       "\n (s) Квадратный корень" +
                       "\n (c) Ввести стартовое значение заново" +
                       "\n (e) Выход из программы");
}

static void StartProrgam()
{
    PrintMenu();

    while (true)
    {
        Input.InputFirstValue();
        Calculator calc = new Calculator(Input._valueFirst);

        while (true)
        {
            Input.InputSymbol();

            if (Input._symbol != "+" &&
                Input._symbol != "-" &&
                Input._symbol != "*" &&
                Input._symbol != "/" &&
                Input._symbol != "%" &&
                Input._symbol != "p" &&
                Input._symbol != "s" &&
                Input._symbol != "c" &&
                Input._symbol != "e")
            {
                continue;
            }

            while (true)
            {
                if (Input._symbol == "s" ||
                    Input._symbol == "e" ||
                    Input._symbol == "c")
                {
                    var isCleared = Condition.CheckCondition(Input._symbol);

                    if (isCleared == true)
                    {
                        StartProrgam();
                    }

                    Console.WriteLine($"Результат: {Calculator.Result}");

                    break;
                }

                Input.InputSecondValue();

                var isCheckedDivision = Condition.CheckCondition(Input._symbol, Input._valueSecond);

                if (isCheckedDivision == false)
                {
                    Console.WriteLine("Делитель не должен равняться нулю");
                    continue;
                }

                Console.WriteLine($"Результат: {Calculator.Result}");

                break;
            }
        }
    } 
}