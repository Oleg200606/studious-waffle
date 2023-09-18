class Program
{
    static void Main()
    {
        int choice;
        string di = "-------------------------";
        double num1, num2, result;

        do
        {
            Console.WriteLine("Выберите операцию:");
            Console.WriteLine("1. Сложение");
            Console.WriteLine("2. Вычитание");
            Console.WriteLine("3. Умножение");
            Console.WriteLine("4. Деление");
            Console.WriteLine("5. Возведение в степень");
            Console.WriteLine("6. Квадратный корень");
            Console.WriteLine("7. Найти 1% числа");
            Console.WriteLine("8. Факториал");
            Console.WriteLine("9. Выход");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine(di);
                Console.WriteLine("Не Не Не, так не пойдет, надо от 1 до 9");
                Console.WriteLine(di);
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 + num2;
                    Console.WriteLine(di);
                    Console.WriteLine($"Результат: {result}");
                    Console.WriteLine(di);
                    break;

                case 2:
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 - num2;
                    Console.WriteLine(di);
                    Console.WriteLine($"Результат: {result}");
                    Console.WriteLine(di);
                    break;

                case 3:
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    result = num1 * num2;
                    Console.WriteLine(di);
                    Console.WriteLine($"Результат: {result}");
                    Console.WriteLine(di);
                    break;

                case 4:
                    Console.Write("Введите первое число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine(di);
                        Console.WriteLine($"Результат: {result}");
                        Console.WriteLine(di);
                    }
                    else
                    {
                        Console.WriteLine(di);
                        Console.WriteLine("Вась, делить на нуль нельзя");
                        Console.WriteLine(di);
                    }
                    break;

                case 5:
                    Console.Write("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите степень: ");
                    int exponent = Convert.ToInt32(Console.ReadLine());
                    result = Math.Pow(num1, exponent);
                    Console.WriteLine(di);
                    Console.WriteLine($"Результат: {result}");
                    Console.WriteLine(di);
                    break;

                case 6:
                    Console.Write("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    if (num1 >= 0)
                    {
                        result = Math.Sqrt(num1);
                        Console.WriteLine(di);
                        Console.WriteLine($"Результат: {result}");
                        Console.WriteLine(di);
                    }
                    else
                    {
                        Console.WriteLine(di);
                        Console.WriteLine("Андрюха ты что, какое отрицательное число?");
                        Console.WriteLine(di);
                    }
                    break;

                case 7:
                    Console.Write("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = num1 / 100;
                    Console.WriteLine(di);
                    Console.WriteLine($"1% числа: {result}");
                    Console.WriteLine(di);
                    break;

                case 8:
                    Console.Write("Введите число: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    result = CalculateFactorial((int)num1);
                    Console.WriteLine(di);
                    Console.WriteLine($"Факториал числа: {result}");
                    Console.WriteLine(di);
                    break;

                case 9:
                    Console.WriteLine(di);
                    Console.WriteLine("Программа завершена.");
                    Console.WriteLine(di);
                    break;
                default:
                    Console.WriteLine(di);
                    Console.WriteLine("Не Не Не, так не пойдет, надо от 1 до 9");
                    Console.WriteLine(di);
                    break;
            }
        } while (choice != 9);
    }

    static double CalculateFactorial(int n)
    {
        if (n == 0)
            return 1;
        else

            return n * CalculateFactorial(n - 1);
    }
}
