using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    public class laba4
    {
        public void menu()
        {
            
            menyu menushka = new menyu();
            Console.WriteLine("\nВыберите какую лабу из 4 раздела вы хотите открыть(от 1 до 6, если хотите выйти из 4 раздела, нажмите 0)");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    lab41();
                    break;
                case 2:
                    lab42();
                    break;
                case 3:
                    lab43();
                    break;
                case 4:
                    lab44();
                    break;
                case 5:
                    lab45();
                    break;
                case 6:
                    lab46();
                    break;
                case 0:
                    menushka.menu123();
                    
                    break;
                default:
                    Console.WriteLine("Ошибка!!!");
                    break;
            }
        }
        static void lab41()
        {
            laba4 back = new laba4();
            Console.WriteLine("Лаба №4.1");
            Console.WriteLine("Введите число N \nВАЖНО\nОно должно быть больше 0");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            Random rnd = new Random();
            int sum = 0;
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(0, 5);
                Console.Write(mas[i] + " ");
            }
            for (int i = 0; i < n; i++)
            {
                a += mas[i];
                if (mas[i] == 0)
                {
                    sum = a;
                    a = 0;
                }
            }
            Console.WriteLine("сумма = " + sum);
            back.menu();
        }
        static void lab42()
        {
            laba4 back = new laba4();
            Console.WriteLine("Ввдите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            n--;
            Random rnd = new Random();
            for (int i = 0; i <= n; i++)
            {
                mas[i] = rnd.Next(0, 101);
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine("\nМассив в обратном порядке:");
            for (int i = n; i >= 0; i--)
            {
                Console.Write(mas[i] + " ");
            }
            back.menu();
        }
        static void lab43()
        {
            laba4 back = new laba4();
            Console.WriteLine("Введите размерность массива:");
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = rnd.Next(0, 101);
                Console.Write(mas[i] + " ");
            }
            int sum = mas[0] + mas[1];
            int k = 1;
            for (int i = 1; i < n; i++)
            {
                if ((mas[i - 1] + mas[i]) > sum)
                {
                    sum = mas[i - 1] + mas[i];
                    k = i;
                }
            }
            Console.WriteLine("\n" + (k - 1) + " - " +
                mas[k - 1] + " " + k + " - " + mas[k]);
            back.menu();
        }
        static void lab44()
        {
            laba4 back = new laba4();
            Console.WriteLine("Введите размерность массива:");
            int sum;
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Random rnd = new Random();
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = rnd.Next(0, 11);
                Console.Write(a[i] + " ");
            }
            for (int i = 0; i < n; i++)
            {
                sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += a[j];
                    b[i] = sum;
                }

            }
            Console.WriteLine("\nВторой массив:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(b[i] + " ");
            }
            back.menu();

        }
        static void lab45()
        {
            laba4 back = new laba4();
            Console.WriteLine("Введите размерность массива :");
            int n = int.Parse(Console.ReadLine());
            int a = 1;
            int b = 0;
            Random rnd = new Random();
            int[] arr = new int[n];
            for (int i = 0; i < n - 1; ++i)
            {
                arr[i] = i + a;
                Console.Write(arr[i] + " ");
            }
            arr[n - 1] = rnd.Next(0, 15);
            Console.Write(arr[n - 1]);
            Console.WriteLine();
            for (int i = 0; i < n; ++i)
            {
                if (arr[n - 1] < arr[i])
                {
                    b = arr[n - 1];
                    arr[n - 1] = arr[i];
                    arr[i] = b;
                }
                Console.Write(arr[i] + " ");
            }
            back.menu();



        }
        static void lab46()
        {
            laba4 back = new laba4();
            Console.WriteLine("Введите размерность массива");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            int a = n;
            Random rnd = new Random();
            for (int i = 0; i < n; ++i)
            {
                arr[i] = rnd.Next(0, 15);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("\nМассив после корректировки: ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] % 2 == 1)
                {
                    a--;
                }
                else
                {
                    Console.Write(arr[i] + " ");
                }
            }
            Console.WriteLine("\nДлинна массива после корректировки : " + a);
            back.menu();
        }
    }
}
