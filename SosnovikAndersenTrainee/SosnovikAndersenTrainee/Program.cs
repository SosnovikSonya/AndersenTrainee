using System;

namespace SosnovikAndersenTrainee
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("1. Первый алгоритм: если введенное число больше 7, то вывести “Привет”");
            FirstAlgorithm();

            Console.WriteLine("\n2. Второй алгоритм: если введенное имя совпадает с Вячеслав, то вывести" +
                " “Привет, Вячеслав”, если нет, то вывести 'Нет такого имени'");
            SecondAlgorithm();

            Console.WriteLine("\n3. Третий алгоритм:  на входе есть числовой массив, необходимо вывести " +
                "элементы массива кратные 3");          
            ThirdAlgorithm();

            Console.ReadKey();
        }

        public static void FirstAlgorithm()
        {
            do
            {
                Console.Write("Введите число: ");
                var inputNumber = Convert.ToInt32(Console.ReadLine());

                var numberForComparison = 7;

                if (inputNumber >= numberForComparison)
                {
                    Console.WriteLine("Привет");
                }

            } while (Exit());
        }

        public static void SecondAlgorithm()
        {
            do
            {
                Console.Write("Введите имя: ");
                var inputName = Console.ReadLine();

                var nameForComarison = "Вячеслав";

                if (inputName == nameForComarison)
                {
                    Console.WriteLine($"Привет, {nameForComarison}");
                }
                else
                {
                    Console.WriteLine("Нет такого имени");
                }
            } while (Exit());
           
        }

        public static void ThirdAlgorithm()
        {
            do
            {
                Console.Write("Введите размер массива: ");
                var arraySize = Convert.ToInt32(Console.ReadLine());

                int[] array = new int[arraySize];
                Console.WriteLine($"Заполните массив {arraySize} значениями: ");

                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }

                Console.Write("Результат: ");
                foreach (var element in array)
                {
                    if (element % 3 == 0)
                    {
                        Console.Write(element + " ");
                    }
                }
            } while (Exit());
            
        }

        public static bool Exit()
        {
            Console.Write("\nВвести еще раз? 0/1:  ");
            if (Convert.ToInt32(Console.ReadLine()) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
