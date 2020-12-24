using System;

namespace lab
{
    class laba6
    {
        public void menu()
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
            int a = 0;
            if (n > 0)
            {
                string otvet = "";
                Console.WriteLine("Введите строку: ");
                string str = Console.ReadLine();
                char[] T = str.ToCharArray();
                for (int i = 0; i < T.Length-1; i++)
                {
                    a++;
                    otvet += T[i].ToString();
                    for (int k = 0; k < n; k++)
                    {
                        otvet += '*'.ToString();
                    }
                }
                Console.WriteLine(otvet+T[T.Length-1]);
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
            string primer = Console.ReadLine();

            string[] mass = primer.Split('+', '-');

            double result = Convert.ToDouble(mass[0]);

            foreach (var item in mass)
            {
                Console.WriteLine(item);
            }

            for (int i = 0, m = 1; i < primer.Length && m < mass.Length; i++)
            {
                switch (primer[i])
                {
                    case '+':
                        result += Convert.ToDouble(mass[m++]);
                        break;
                    case '-':
                        result -= Convert.ToDouble(mass[m++]);
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine($"Результат: {result}");
            back.menu();
        }
        static void lab63()
        {
            laba6 back = new laba6();




            Console.WriteLine("Введите строку S");
            string s = Console.ReadLine();
            Console.WriteLine("Введите строку s0");
            string s0 = Console.ReadLine();
            s = s.Replace(s0, "");
            Console.WriteLine(s);


            back.menu();
        }
        static void lab64()
        {
            laba6 back = new laba6();


            Console.WriteLine("Введите строку : ");
            string s = Console.ReadLine();
            string b = "";
            string[] otvet = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string a in otvet)
            {
                b += a+".";
            }
            int ind = b.Length - 1;
            b = b.Remove(ind);
            Console.WriteLine(b);


            back.menu();
        }
        static void lab65()
        {
            laba6 back = new laba6();



            Console.WriteLine("Введите строку : ");
            string s = Console.ReadLine();
            string[] abc = s.Split(new char[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine($"Результат : {abc[1]}"); 



            back.menu();
        }
    }
}
