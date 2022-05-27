using System;
using System.Collections.Generic;

namespace Dynamic_array_advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTheSumArrayFunction();
        }
        static void CreateTheSumArrayFunction()
        {
            List<byte> arraySum = new List<byte>();
            bool WhetheToStartACycle = true;

            while (WhetheToStartACycle)
            {
                Console.Write($"Введите число, exit или sum: ");
                string str = Console.ReadLine();

                if (str != "sum" && str != "exit")
                {
                    byte namberArray = byte.Parse(str);
                    arraySum.Add(namberArray);
                }

                else if (str == "sum")
                {
                    byte sum = 0;

                    for (int i = 0; i < arraySum.Count; i++)
                    {
                        sum += arraySum[i];
                    }
                    Console.WriteLine($"Сумма равна {sum}");
                }

                else if (str == "exit")
                {
                    Console.Clear();
                    Console.WriteLine("Всего доброго!");
                    Console.ReadLine();
                    WhetheToStartACycle = false;
                }

                else Console.WriteLine("Не верно указанна команда!");
            }
        }
    }
}
/*Задача:
В массивах вы выполняли задание "Динамический массив"
Используя всё изученное напишите улучшенную версию динамического массива(не обязательно брать своё старое решение)
Задание нужно чтобы вы освоились с List и прощупали его преимущество.
Проверка на ввод числа обязательна.

Пользователь вводит числа, и программа их запоминает.
Как только пользователь введёт команду sum, программа выведет сумму всех веденных чисел.

Выход из программы должен происходить только в том случае, если пользователь введет команду exit.*/