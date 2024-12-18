﻿namespace Laboratorium3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie1();
            //Zadanie2();
            //Zadanie3();
            //Zadanie4();
            //Zadanie5();
            //Zadanie6();
            //Zadanie7();
            Zadanie8();
        }
        public static void Zadanie1(){
            decimal balans = 56;
            bool isCreditCardValid = true;
            decimal price = 45;
            bool canPay = balans >= price && isCreditCardValid;

            Console.WriteLine(canPay);
        }
        public static void Zadanie2(){
            double a = 5;
            double b = 5;
            double c = 5;
            bool isTriangle = true;

            isTriangle = a + b > c && a + c > b && b + c > a; 
            isTriangle = true;
            Console.WriteLine(isTriangle);
        }
        public static void Zadanie3()
        {
            double cx = 2.56;
            double cy = 4.6;
            double cradius = 5;
            double x = 6.4;
            double y = 2.234;

            bool isOutside = Math.Pow(x - cx, 2) + Math.Pow(y - cy, 2) <= Math.Pow(cradius, 2);

            Console.WriteLine(isOutside);
        }
        public static void Zadanie4(){
            int rx = 10;
            int ry = 10;
            int width = 10;
            int height = 10;
            int x = 20;
            int y = 2;
            bool isOnBorder = ry >= y && ry - height <= y && rx <= x && rx + width >= x && (y == ry || y == ry - height || x == rx || x == rx + width);
            Console.WriteLine(isOnBorder);
        }
        public static void Zadanie5()
        {
            //double x = 1.34;
            double a = 2.5;
            double b = -0.5;
            double c = 1.5;
            double delta = b * b - 4 * a * c;
            Console.WriteLine(delta);
            if(delta >= 0)
            {
                double sqrtDelta = Math.Sqrt(delta);
                if(delta > 0)
                {
                    Console.WriteLine($"x1 = {(-b - sqrtDelta) / (2 * a)}");
                    Console.WriteLine($"x2 = {(-b + sqrtDelta) / (2 * a)}");
                }          
                else
                    Console.WriteLine($"x = {-b / (2 * a)}");
            }
            else
            {
                Console.WriteLine("Nie można otrzymać pierwiastków rzeczywistych!");
            }
        }
        public static void Zadanie6()
        {
            int code = 4;
            int quantity = 11;
            decimal price = 3.5m;
            decimal discountMultiplier = 1.00m;

            if (code >= 10 && code <= 15)
            {
                discountMultiplier = 0.95m;
            }
            else if (code >= 16)
            {
                if (quantity <= 10)
                {
                    discountMultiplier = 1.05m;
                }
                else if (quantity > 20 && quantity < 100)
                {
                    discountMultiplier -= Math.Floor((decimal)quantity / 10) / 100;
                }
                else if (quantity >= 100)
                {
                    discountMultiplier = 0.90m;
                }
            }

            decimal sellPrice = Math.Round(price * discountMultiplier, 2, MidpointRounding.AwayFromZero);
            Console.WriteLine($"Price: {sellPrice}");
        }

        public static void Zadanie7()
        {
            int decimalNumber = 11;

            switch (decimalNumber)
            {
                case 1:
                    Console.WriteLine("I");
                    break;
                case 2:
                    Console.WriteLine("II");
                    break;
                case 3:
                    Console.WriteLine("III");
                    break;
                case 4:
                    Console.WriteLine("IV");
                    break;
                case 5:
                    Console.WriteLine("V");
                    break;
                case 6:
                    Console.WriteLine("VI");
                    break;
                case 7:
                    Console.WriteLine("VII");
                    break;
                case 8:
                    Console.WriteLine("VIII");
                    break;
                case 9:
                    Console.WriteLine("IX");
                    break;
                case 10:
                    Console.WriteLine("X");
                    break;
                case 11:
                    Console.WriteLine("XI");
                    break;
                case 12:
                    Console.WriteLine("XII");
                    break;
                case 13:
                    Console.WriteLine("XIII");
                    break;
                case 14:
                    Console.WriteLine("XIV");
                    break;
                case 15:
                    Console.WriteLine("XV");
                    break;
                case 16:
                    Console.WriteLine("XVI");
                    break;
                case 17:
                    Console.WriteLine("XVII");
                    break;
                case 18:
                    Console.WriteLine("XVIII");
                    break;
                case 19:
                    Console.WriteLine("XIX");
                    break;
                case 20:
                    Console.WriteLine("XX");
                    break;
                case 0:
                    Console.WriteLine("Rzymianie nie znali zera!");
                    break;
                default:
                    Console.WriteLine("Nie obsługuję liczb spoza zakresu od 1 do 20!");
                    break;
            }
        }

        public static void Zadanie8()
        {
            char hex = '9';
            switch (hex)
            {
                case '0':
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                    Console.WriteLine(hex);
                    break;
                case 'a':
                case 'A':
                    Console.WriteLine("10");
                    break;
                case 'b':
                case 'B':
                    Console.WriteLine("11");
                    break; 
                case 'c':
                case 'C':
                    Console.WriteLine("12");
                    break;
                case 'd':
                case 'D':
                    Console.WriteLine("13");
                    break; 
                case 'e':
                case 'E':
                    Console.WriteLine("14");
                    break;
                case 'f':
                case 'F':
                    Console.WriteLine("15");
                    break;
                default:
                    Console.WriteLine("To nie jest cyfra szesnastkowa");
                    break;
            }
        }
    }
}