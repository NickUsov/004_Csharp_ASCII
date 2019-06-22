using System;
using static System.Console;

namespace _004_Csharp_ASCII
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Числовые значения символов нижнего регистра в коде ASCII отличаются от значений символов верхнего регистра на величину
            //32. Используя эту информацию, написать программу, которая считывает с клавиатуры и конвертирует все символы нижнего
            //регистра в символы верхнего регистра и наоборот.


            Console.WriteLine("1. задание");
            int ch = 0;
            string msg = "";
            do
            {
                ch = Read();
                if (ch >= 97 && ch <= 122)
                    ch -= 32;
                else if (ch >= 65 && ch <= 90)
                    ch += 32;
                msg += (char)ch;
            } while (ch != 13);
            WriteLine(msg);


            //2. Написать программу, которая считывает символы с клавиатуры, пока не будет введена точка. Программа должна
            //сосчитать количество введенных пользователем пробелов.


            Console.WriteLine("2. задание");
            int space = 0;
            char symb = '\0';
            while (symb != '.')
            {
                symb = ReadKey().KeyChar;
                if (symb == ' ')
                    space++;
            }
            WriteLine($"Number of spaces is {space}");


            //3. Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; каждое число 
            //должно выводиться на новой строке; при этом каждое число должно выводиться количество раз, равное его значению. 
            //Например: если А = 3, а В = 7, то программа должна сформировать в консоли следующий вывод:
            //3 3 3
            //4 4 4 4
            //5 5 5 5 5
            //6 6 6 6 6 6
            //7 7 7 7 7 7 7

            WriteLine("3. задание");
            WriteLine("Enter first number");
            int first = 0;
            if (int.TryParse(ReadLine(), out first))
                WriteLine("uups");
            else
                first = int.Parse(ReadLine());
            WriteLine("Enter second number");
            int second = int.Parse(ReadLine());
            if(first>second)
            {
                int tmp = first;
                first = second;
                second = tmp;
            }
            for(int i=first;i<second+1;i++)
            {
                for (int j = 0; j < i; j++)
                    Write(i + " ");
                WriteLine();
            }
        }
    }
}
