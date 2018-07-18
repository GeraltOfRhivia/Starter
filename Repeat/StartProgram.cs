using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region README

/* 
 * В этом решении
 * реализваны некоторые методы
 * для повтора информации
 * за курс С# Starter
 */

#endregion

#region HOTKEY
// Ctrl + D             - дублирование строки 
// Ctrl + Shift + L     - удаление строки
// Alt + (стрелка)      - перемещение строки вверх или вниз
// Ctrl + M + М         - свернуть область
#endregion


namespace Repeat
{
    class StartProgram
    {

        static void Main(string[] args)
        {
            // Создание обычного массива
            int[] a = {4,7,1,47,98};

            // Так в консоле отобразится тип массива (неверно)
            Console.WriteLine(a);
            // "Нормальный" вывод массива любых обьектов через разделитель
            Console.WriteLine(String.Join(", ",a));



            // Ожидание
            Console.ReadKey();
        }


        #region МЕТОДЫ (повтор)

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

        // Для добавления XML-описания метода, нужно поставить перед ним "///"
        /// <summary>
        /// Метод для суммирования двух чисел
        /// </summary>
        /// <param name="a">Первое число для суммирования</param>
        /// <param name="b">Второе число для суммирования</param>
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

        #endregion
        
    }

}
