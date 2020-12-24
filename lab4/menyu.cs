using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class menyu
    {
        public void menu123()
        {
            Console.WriteLine("Введите раздел лаб, который хотите открыть(начиная с 4) :");
            int raz = int.Parse(Console.ReadLine());
            switch (raz)
            {
                case 4:
                    laba4 lab4 = new laba4();
                    lab4.menu();
                    break;
                case 5:
                    laba5 lab5 = new laba5();
                    lab5.menu();
                    break;
                case 6:
                    laba6 lab6 = new laba6();
                    lab6.menu();
                    break;
                case 7:
                    laba7 lab7 = new laba7();
                    lab7.menyu();
                    break;
                default:
                    Console.WriteLine("не подходит");
                    break;
            }
        }
    }
}
