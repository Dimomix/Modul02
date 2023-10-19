using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Modul02
{
    internal class Program
    {
        static void zadanie01()
        {
            string text = Console.ReadLine();
            int whitespace = 0;
            for (int i = 0; i < text.Length || text[i] == '.'; i++)
            {
                if (text[i] == ' ') { whitespace++; }
                if (text[i] == '.') { break; }
            }
            Console.WriteLine(whitespace);
        }
        static void isHappyTicket(int Ticket)
        {
            int a = 0, b = 0;
            for (int i = 0; i < 3; i++)
            {
                a += (Ticket / Convert.ToInt32(Math.Pow(10, i + 3))) % 10;
                b += (Ticket / Convert.ToInt32(Math.Pow(10, i))) % 10;
            }

            if (a == b)
            {
                Console.WriteLine("Этот билет счастья");
            }
            else
            {
                Console.WriteLine("Этот билет обычный");
            }
            return;
        }
        static void zadanie02()
        {
            int ticket;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите номер билета:");
                    String text = Console.ReadLine();
                    if (text.Length == 6)
                    {
                        ticket = Convert.ToInt32(text);
                        isHappyTicket(ticket);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Введите 6ти значный номер билета");
                        continue;
                    }
                }
                catch
                {
                    Console.WriteLine("Введите номер коректно!!!");
                    continue;
                }
                break;
            }
        }
        static string ConvertASCII(string text)
        {
            char[] chattext = text.ToCharArray();

            for (int i = 0; i < chattext.Length; i++)
            {
                char a = chattext[i];
                if (char.IsLower(a))
                {
                    chattext[i] = (char)(a - 32);
                }
                else if (char.IsUpper(a))
                {
                    chattext[i] = (char)(a + 32);
                }
            }

            return new string(chattext);
        }
        static void zadanie03()
        {
            Console.WriteLine("Введите текст: ");
            string Text = Console.ReadLine();
            string convert_Text = ConvertASCII(Text);
            Console.WriteLine("Конвертирвонный текст: ");
            Console.WriteLine(convert_Text);
        }
        static void zadanie04()
        {
            Console.WriteLine("Введите A:");
            int A = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите B (B должно быть больше A):");
            int B = int.Parse(Console.ReadLine());

            if (A >= B)
            {
                Console.WriteLine("Ошибка: B должно быть больше A.");
                zadanie04();
            }

            for (int i = A; i <= B; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine();
            }
        }
        static int ReverseN(int N)
        {
            string NStr = N.ToString();
            char[] charN = NStr.ToCharArray();
            Array.Reverse(charN);
            string reversedStr = new string(charN);
            int reversedNumber = int.Parse(reversedStr);
            return reversedNumber;
        }
        static void zadanie05()
        {
            Console.WriteLine("Введите число N:");
            int N = int.Parse(Console.ReadLine());
            int reverse_N = ReverseN(N);
            Console.WriteLine("Число обратное:\n" + reverse_N);
        }
        static void zadanie06()
        {
            Random random = new Random();
            int number1 = random.Next(1, 101);
            int number2 = random.Next(1, 101);
            int number3 = random.Next(1, 101);
            Console.WriteLine($"{number1}  {number2}  {number3}");
        }
        static void zadanie07()
        {
            Console.WriteLine("5\n10\n21");
        }
        static void zadanie08()
        {
            Console.WriteLine("Введите расстояние в см:");
            int cm = int.Parse(Console.ReadLine());
            double m = Convert.ToDouble(cm) / 100.0;
            Console.WriteLine("Число полных метров: " + m + 'м');
        }
        static void zadanie09()
        {
            int past_days = 234;
            int past_weeks = past_days / 7;
            Console.WriteLine(past_days + " дней это " + past_weeks + "недель");
        }
        static void zadanie10()
        {
            Console.WriteLine("Введите двузначное число:");
            int number = int.Parse(Console.ReadLine());
            if (number >= 10 && number <= 99)
            {
                int decimals = number / 10;
                int units = number % 10;
                int sum = decimals + units;
                int product = decimals * units;
                Console.WriteLine("Число десятков: " + decimals);
                Console.WriteLine("Число единиц: " + units);
                Console.WriteLine("Сумма цифр: " + sum);
                Console.WriteLine("Произведение цифр: " + product);
            }
            else
            {
                Console.WriteLine("Ошибка: Введите двузначное число.");
                zadanie10();
            }
        }
        static void zadanie11()
        {
            bool A = true;
            bool B = false;
            bool C = false;
            bool resultA = A || B;
            Console.WriteLine("А или В: " + resultA);
            bool resultB = A && B;
            Console.WriteLine("А и В: " + resultB);
            bool resultC = B || C;
            Console.WriteLine("В или С: " + resultC);

        }
        static void zadanie12()
        {
            Console.WriteLine("Введите радиус круга:");
            double radius = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите длину стороны квадрата:");
            double sidesquare = double.Parse(Console.ReadLine());

            double circleArea = Math.PI * radius * radius;
            double squareArea = sidesquare * sidesquare;
            Console.WriteLine("Вывод:");
            if (circleArea > squareArea)
            {
                Console.WriteLine("Площадь круга больше.");
            }
            else if (circleArea < squareArea)
            {
                Console.WriteLine("Площадь квадрата больше.");
            }
            else
            {
                Console.WriteLine("Площади круга и квадрата равны.");
            }
        }
        static void zadanie13()
        {
            Console.WriteLine("Введите объем первого тела (в м^3):");
            double volume1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу первого тела (в кг):");
            double mass1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите объем второго тела (в м^3):");
            double volume2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите массу второго тела (в кг):");
            double mass2 = double.Parse(Console.ReadLine());
            double density1 = mass1 / volume1;
            double density2 = mass2 / volume2;
            Console.WriteLine("Вывод:");
            if (density1 > density2)
            {
                Console.WriteLine("Первое тело более плотная.");
            }
            else if (density1 < density2)
            {
                Console.WriteLine("Второе тело более плотная.");
            }
            else
            {
                Console.WriteLine("Плотности одинаковы.");
            }
        }
        static void zadanie14()
        {
            Console.WriteLine("Введите сопротивление первого участка (Ом):");
            double resistance1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите напряжение на первом участке (В):");
            double voltage1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите сопротивление второго участка (Ом):");
            double resistance2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите напряжение на втором участке (В):");
            double voltage2 = double.Parse(Console.ReadLine());
            double current1 = voltage1 / resistance1;
            double current2 = voltage2 / resistance2;
            Console.WriteLine("Вывод:");
            if (current1 < current2)
            {
                Console.WriteLine("Меньший ток в первом участку.");
            }
            else if (current1 > current2)
            {
                Console.WriteLine("Меньший ток во втором участку.");
            }
            else
            {
                Console.WriteLine("Токи на участках равны.");
            }
        }
        static void zadanie15a()
        {
            for (int i = 20; i <= 35; i++)
            {
                Console.WriteLine(i);
            }
            return;
        }
        static void zadanie15b()
        {
            Console.WriteLine("Введите значение b (больше 10):");
            int b = int.Parse(Console.ReadLine());
            if (b <= 10)
            {
                Console.WriteLine("b должно быть больше 10.");
                zadanie15b();
            }
            else
            {
                for (int i = 10; i <= b; i++)
                {
                    int square = i * i;
                    Console.WriteLine("Квадрат числа " + i + " равен " + square);
                }
            }
            return;
        }
        static void zadanie15c()
        {
            Console.WriteLine("Введите значение a (меньше 50):");
            int a = int.Parse(Console.ReadLine());
            if (a >= 50)
            {
                Console.WriteLine("a должно быть меньше 50.");
                zadanie15c();
            }
            else
            {
                for (int i = a; i <= 50; i++)
                {
                    int cube = i * i * i;
                    Console.WriteLine("Третья степень числа " + i + " равна " + cube);
                }
            }
        }
        static void zadanie15d()
        {
            Console.WriteLine("Введите значение a:");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите значение b (больше a):");
            int b = int.Parse(Console.ReadLine());

            if (b <= a)
            {
                Console.WriteLine("b должно быть больше a.");
                zadanie15d();
            }
            else
            {
                for (int i = a; i <= b; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
        static void zadanie15()
        {
            Console.WriteLine("a:");
            zadanie15a();
            Console.WriteLine("b:");
            zadanie15b();
            Console.WriteLine("c:");
            zadanie15c();
            Console.WriteLine("d:");
            zadanie15d();
        }
        static void zadanie16()
        {
            Console.WriteLine("Введите значение x:");
            double x = double.Parse(Console.ReadLine());
            double y = 7 * x * x - 3 * x + 6;
            Console.WriteLine("Ответ функции y=7x^2-3x+6 при x = " + x + " равно " + y);
        }
        static void zadanie17()
        {
            Console.WriteLine("Введите значение a:");
            double a = double.Parse(Console.ReadLine());
            double x = 12 * Math.Pow(a, 2) + 7 * a - 16;
            Console.WriteLine("Ответ функции x = 12a^2 +7x-16 при a = " + a + " равно " + x);
        }
        static void zadanie17_prak()
        {
            Console.WriteLine("Введите 3 значное число:");
            string s3 = Console.ReadLine();
            try
            {
                int a = int.Parse(s3);
                if (s3.Length != 3)
                {
                    zadanie17_prak();
                }
            }
            catch
            {
                zadanie17_prak();
            }
            char a2 = s3[1];
            s3 = s3.Remove(1, 1);
            s3 += a2;
            Console.WriteLine(s3);

        }
        static void zadanie18()
        {
            Console.WriteLine("Введите сторону квадрата:");
            double a = double.Parse(Console.ReadLine());
            double S = 4 * a;
            Console.WriteLine("Периметр квадрата: " + S);

        }
        static string istrue(int a){
            if (a == 0) return "False";
            return "True";
            }
        static bool is_true(int a){
            if (a == 0) return false;
            return true;
            }
        static void zadanie18_prak()
        {
            for(int x=0; x<2; ++x){
                for (int y=0; y < 2; ++y){
                    for (int z=0;z< 2; ++z){
                        Console.WriteLine("при х: "+ istrue (x)+ " при у: "+ istrue(y) + " при z: "+ istrue(z));
                        bool X =is_true(x), Y = is_true(y), Z = is_true(z);
                        Console.WriteLine("не X и не Y: "+ (!X&!Y));
                        Console.WriteLine("X или (не X и Y): "+(X ||(!X &Y)));
                        Console.WriteLine("не X и Y) или Y: "+((!X&Y)||Y));
                    }
                }
            }
        }


        static void zadanie19()
        {
            Console.WriteLine("Введите радиус:");
            double r = double.Parse(Console.ReadLine());
            double d = 2 * r;
            Console.WriteLine("Диаметр круга: " + d);
        }
        static void zadanie20()
        {
            double radiusEarth = 6350; 
            Console.WriteLine("Введите высоту (в км):");
            double heightEarth = double.Parse(Console.ReadLine());
            double hypotenuse = Math.Sqrt(Math.Pow(heightEarth, 2) + Math.Pow(radiusEarth, 2));
            double distanceHorizon = hypotenuse - radiusEarth;
            Console.WriteLine("Расстояние до горизонта: " + distanceHorizon + "км");
        }
        static void Main(string[] args)
        {
            //zadanie01();
            //zadanie02();
            //zadanie03();
            //zadanie04();
            //zadanie05();
            //zadanie06();
            //zadanie07();
            //zadanie08();
            //zadanie09();
            //zadanie10();
            //zadanie11();
            //zadanie12();
            //zadanie13();
            //zadanie14();
            //zadanie15();
            //zadanie16();
            //zadanie17();
            //zadanie17_prak();
            //zadanie18();
            //zadanie18_prak();
            //zadanie19();
            //zadanie20();

            Console.ReadKey();
        }
    }
}
