using System;
using System.Collections.Generic;
using System.Text;

namespace lab
{
    class laba5
    {
        public void menu()
        {
            laba5 back = new laba5();
            menyu menyu = new menyu();
            Console.WriteLine("Вы находитесь в пятом разделе");
            Console.WriteLine("Введите номер лабы, которую хотите открыть(для выхода из раздела нажмите 0)");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    lab51();
                    break;
                case 2:
                    lab52();
                    break;
                case 3:
                    lab53();
                    break;
                case 4:
                    lab54();
                    break;
                default:
                    Console.WriteLine("Ошибка!!!");
                    break;
                case 0:
                    menyu.menu123();
                    break;
                    

            }

        }
        static void lab51()
        {
            laba5 back = new laba5();
            Random rnd = new Random();
            Console.WriteLine("Введите размер матрицы M x N: ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите число K(1<=K<=N): ");
        checkpoint:
            int k = int.Parse(Console.ReadLine());
            if (k >= 1 & k <= n)
            {
                int[,] mas = new int[m, n];
                for (int i = 0;i<m;i++)
                {
                    for (int j = 0;j<n;j++)
                    {
                        mas[i,j] = rnd.Next(1, 101);
                        Console.Write(mas[i,j] + "\t");
                    }
                    Console.WriteLine("");
                }
                Console.WriteLine("Элементы K-го столбца массива: ");
                for (int i = 0; i < m;i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (k-1 == j)
                        {
                            Console.Write(mas[i,j]+ "\t");
                        }
                    }
                }

            }
            else
            {
                Console.WriteLine("Число K не подходит по условию, введите его снова: ");
                goto checkpoint;
            }
            back.menu();
        }
        static void lab52()
        {
            laba5 back = new laba5();
            Random rnd = new Random();
            Console.WriteLine("Введите размер матрицы M x N: ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int nomer = 0;
            int otvet = 0;
            int a = 0;
            int[,] mas = new int[m, n];
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    mas[i, j] = rnd.Next(0, 2);
                    Console.Write(mas[i,j]+ "\t");
                }
                Console.WriteLine("");
            }
            for (int j = 0; j < n; ++j)
            {
                a = 0;
                for ( int i = 0; i < m--; ++i )
                {
                    int k = i++;
                    if ( mas [i,j] == mas[i,k])
                    {
                        a++;
                        if (a>=otvet)
                        {
                            nomer = i;
                            otvet = a;
                        }
                    }
                }
            }
            Console.WriteLine("Номер последней строки с наибольшим колличеством одинаковых элементов: " + nomer);
            back.menu();

        }
        static void lab53()
        {
            laba5 back = new laba5();
            Random rnd = new Random();
            Console.WriteLine("Введите размер матрицы M x N: ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int maxi = 0;
            int[,] mas = new int[m, n];
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    mas[i, j] = rnd.Next(0, 101);
                    Console.Write(mas[i,j] + "\t");
                }
                Console.WriteLine("");
            }
            int max = mas[0, 0];
            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (mas[i,j] > max)
                    {
                        max = mas[i, j];
                        maxi = i;
                    }
                }
            }
            Console.WriteLine("Матрица с продублированой строкой");
            for (int i = 0; i <=maxi; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{mas[i,j]}\t");
                }
                Console.WriteLine();
            }
            for (int i = maxi; i < m; ++i)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{mas[i, j]}\t");
                }
                Console.WriteLine();
            }
            back.menu();
        }
        static void lab54()
        {
            laba5 back = new laba5();
            Random rnd = new Random();
            Console.WriteLine("Введите размер матрицы M x N: ");
            int m = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            int[,] mas = new int[m, n];
            int a = 0;
            int b = 0;
            for ( int i = 0; i < m; ++i)
            {
                for ( int j = 0; j < n; ++j)
                {
                    mas[i, j] = rnd.Next(0, 11);
                    Console.Write(mas[i,j] + " ");
                    if (j <= i)
                    {
                        a += mas[i, j];
                        b++;
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Число элементов под главной диагональю и на ней: " + b + "\nСумма этих элементов :" + a);
            back.menu();
        }
    }
}
