using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region README

// В этом решении
// реализваны некоторые методы
// для повтора информации 
// за курс С# Starter

#endregion


namespace Repeat
{
    class Program
    {

        static void Main(string[] args)
        {
            //Scanner();
            //SumNumber(5, 78);
            //GoTo();

            // Создание обычного массива
            int[] a = {4,7,1,47,98};
            //
            PrintArray(a);
        }


        #region МЕТОДЫ
        // Повтор методов
        #endregion

        // Метод для ввода информации в консоль
        static void Scanner()
        {
            // Вывод строки на екран
            Console.Write("Введите любую строку: ");

            // Считывание строки
            string str = Console.ReadLine();

            Console.Write("Вы ввели: " + str);

            // Ожидание ввода ключа
            Console.ReadKey();
        }
        // Метод суммы
        static void SumNumber(int a, int b)
        {
            // Так можно назыать переменную
            int @int = a + b;

            // Один из способов вывода информации в консоль
            Console.Write("Сумма чисел {0} и {1} = ", a, b);
            Console.WriteLine(@int);
            Console.ReadKey();
        }
        // Метод для демонстрации GOTO
        static void GoTo()
        {
            int a = 5;

        Label:
            a++;
            Console.WriteLine(a);

            // Отправная точка на метку Label
            if (a < 10) goto Label;

            Console.WriteLine("Method GoTo end.");
            Console.ReadKey();
        }
        // Вывод обычного массива в консоль
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.ReadKey();
        }
    }

}
