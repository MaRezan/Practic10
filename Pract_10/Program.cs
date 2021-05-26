using System;
using System.Collections.Generic;
using System.Linq;

namespace Pract_10
{
    class Program
    {
        static void Main(string[] args)
        {   //TASK_1
            Console.WriteLine("Введите число");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Палиндром:" + IsPalindrom(num));
            Console.ReadKey(true);

            //TASK_2
            Console.WriteLine("Введите римские цифры, чтобы конвертировать их в арабские");
            String str = Console.ReadLine();
            int a = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (ch == 'M')
                    a += 1000;
                else if (ch == 'D')
                    a += 500;
                else if (ch == 'C')
                    a += 100;
                else if (ch == 'L')
                    a += 50;
                else if (ch == 'X')
                    a += 10;
                else if (ch == 'V')
                    a += 5;
                else if (ch == 'I')
                    a += 1;
            }
            Console.WriteLine("{0}", a);


        }

        static bool IsPalindrom(int num)
        {
            if (num >= 0 && num < 10)
                return true;
            int numLength = GetLength(num);
            int[] digits = new int[numLength];
            for (int i = numLength - 1; i >= 0; i--)
            {
                digits[i] = num % 10;
                num /= 10;
            }
            for (int i = 0; i < numLength / 2; i++)
            {
                if (digits[i] != digits[numLength - i - 1])
                    return false;
            }
            return true;
        }

        static int GetLength(int num)
        {
            int n = 0;
            while (num > 0)
            {
                num /= 10;
                n++;
            }
            return n;
        }
    }
}
