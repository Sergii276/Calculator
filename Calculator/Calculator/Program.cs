using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.Clear();

                double valueOne, valueFirst;

                string action;

                Console.WriteLine();

                try
                {
                    Console.WriteLine("Введите число 1");

                    valueFirst = double.Parse(Console.ReadLine());

                    Console.WriteLine();

                    Console.WriteLine("Введите число 2");

                    valueOne = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Виберите другое действие");

                    Console.ReadLine();

                    continue;
                }

                Console.WriteLine("Виберите операцию + , - , * , / ");

                action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        Console.WriteLine(valueOne + valueFirst);
                        break;
                    case "-":
                        Console.WriteLine(valueOne - valueFirst);
                        break;
                    case "*":
                        Console.WriteLine(valueOne * valueFirst);
                        break;
                    case "/":
                        Console.WriteLine(valueOne / valueFirst);
                        if (valueFirst == 0)

                            Console.WriteLine(0);

                        else Console.WriteLine(valueOne / valueFirst);
                        break;
                    default:

                        Console.WriteLine("неизвесное действие");
                        break;
                }
                Console.ReadLine();
            }

        }
    }
}
