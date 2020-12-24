using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime;

namespace lab
{
    class laba7
    {
        static bool lab71(string s)
        {
            laba7 stri = new laba7();
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (count == 5)
                {
                    Console.WriteLine($"Строка : \n{s}");
                    return true;
                }
                else if ((Convert.ToInt32(s[i]) >= 65 && Convert.ToInt32(s[i]) <= 90) | (Convert.ToInt32(s[i]) >= 97 && Convert.ToInt32(s[i]) <= 122))
                {
                    count++;
                }
                else if (((Convert.ToInt32(s[i]) <= 65 && Convert.ToInt32(s[i]) >= 90) | (Convert.ToInt32(s[i]) <= 97 && Convert.ToInt32(s[i]) >= 122)))
                {
                    count = 0;
                }
            }
            return false;
        }
        public void menyu()

        {
            menyu menyshka = new menyu();
            Console.WriteLine("Вы находитесь на 7 пункте лабораторных, введите номер лабы, которую хотите открыть(0 для выхода назад)");
            int number = int.Parse(Console.ReadLine());
            switch (number)
            {
                case 0:
                    menyshka.menu123();
                    break;
                case 1:
                    lab1();
                    break;
                case 2:
                    lab2();
                    break;
                default:
                    Console.WriteLine("Такой лабы нет");
                    break;

            }

        }
        static void lab1()
        {
            laba7 back = new laba7();
        checkpoint:
            Console.WriteLine("Введите строчку(введите пустую строку, если хотите выйти): ");
            string a = Console.ReadLine();
            if (a != "")
            {
                bool res = lab71(a);
                if (res == false)
                {
                    Console.WriteLine("в строке нет 5 подряд латинскиъ букв");
                    goto checkpoint;
                }
                else
                {
                    goto checkpoint;
                }
            }
            else
                back.menyu();
        }
        static int AddLeftDigit(int d,  int k)
        {

            if (d <= 0 || d > 9 || k <= 0)
            {
                Console.WriteLine("Неверные значения, введите заново");
                
            }
            int n = k;
            while (n != 0)
            {
                n /= 10;
                d *= 10;
            }
            k += d;
            return k;
        }
        static void lab2()
        {
            laba7 back = new laba7();
            Console.WriteLine("Введите число K:");
            int K = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число D1:");
            int D1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат после первой операции");
            int res1 = AddLeftDigit(D1, K);
            Console.WriteLine(res1);
            Console.WriteLine("Введите число D2:");
            int D2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Результат после второй операции");
            int res2 = AddLeftDigit(D2, res1);
            Console.WriteLine(res2);
            back.menyu();
        }
    }
}
