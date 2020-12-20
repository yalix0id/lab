using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace lab
{
    class laba6
    {
        public void menu ()
        {
            menyu menu123 = new menyu();
            Console.WriteLine("вы на 6 разделе лаб, выберите номер лабы, которую хотите открыть(нажмите 0 для выхода)");
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 0:
                    menu123.menu123();
                    break;
                case 1:
                    lab61();
                    break;
                case 2:
                    lab62();
                    break;
                case 3:
                    lab63();
                    break;
                case 4:
                    lab64();
                    break;
                case 5:
                    lab65();
                    break;
                default:
                    Console.WriteLine("номер не верный!");
                    break;

            }
        }
        static void lab61()
        {
            laba6 back = new laba6();
            Console.WriteLine("Введите число N: ");
        checkpoint:
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                string otvet = "";
                Console.WriteLine("Введите строку: ");
                string str = Console.ReadLine();
                int b = str.Length;
                for (int i = 0; i<b-1;++i)
                {
                    otvet += str[i].ToString();
                        for (int k = 0; k < n; ++k)
                        {
                        otvet += "*";
                        }

                }
                otvet += str[b-1];
                Console.WriteLine(otvet);
            }
            else
            {
                Console.WriteLine("Число N не больше 0, введите его снова");
                goto checkpoint;
            }

            back.menu();
        }
        static void lab62()
        {
            laba6 back = new laba6();

            back.menu();
        }
        static void lab63()
        {
            laba6 back = new laba6();

            back.menu();
        }
        static void lab64()
        {
            laba6 back = new laba6();

            back.menu();
        }
        static void lab65()
        {
            laba6 back = new laba6();

            back.menu();
        }
    }
}
