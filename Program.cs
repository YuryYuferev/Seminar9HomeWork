// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Введите натуральное число: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 1;
        ShowNumbers(number, count);

        void ShowNumbers(int n, int count)
        {
            if (count > n)
            {
                return;
            }
            else
            {
                ShowNumbers(n, count + 1);
                Console.Write(count + " ");
            }
        }
    }
}
*/
// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120   M = 4; N = 8. -> 30
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите натуральное число M:");
        int numberM = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите натуральное число M:");
        int numberN = Convert.ToInt32(Console.ReadLine());
        
        void NumberSum(int numberM, int numberN, int sum)
        {
            if (numberM > numberN)
            {
                Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна {sum}");
                return;
            }
            sum = sum + numberM++;
            NumberSum(numberM, numberN, sum);
        }
        NumberSum(numberM, numberN, 0);
    }
}
*/
// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9   m = 3, n = 2 -> A(m,n) = 29
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите неотрицательное число M:");
        int numberM = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите неотрицательное число N:");
        int numberN = Convert.ToInt32(Console.ReadLine());
        
        int AckermannFunction(int numberM, int numberN)
        {
            if (numberM == 0) 
            return numberN + 1;

            if (numberM != 0 && numberN == 0) 
            return AckermannFunction(numberM - 1, 1);

            if (numberM > 0 && numberN > 0) 
            return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));

            return AckermannFunction(numberM, numberN);
        }
        Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");
    }
}
*/
