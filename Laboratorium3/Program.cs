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
            Zadanie6();
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
            int code = 16;
            int quantity = 21;
            decimal price = 3.5m;
            decimal sellPrice;

            sellPrice = 0m;

            if (code < 10)
                sellPrice = price;
            else if (code <= 15)
                sellPrice = price * 0.95m;
            else
            {
                if (quantity <= 20)
                    sellPrice = price;
                else if (quantity < 100)
                {
                    decimal discountMultiplier = (decimal)quantity / 10 / 100 + 1;
                    sellPrice = Math.Round(price * discountMultiplier, 2);
                }
                else
                    sellPrice = price * 0.90m;
            }

            Console.WriteLine($"Price: {sellPrice}");
        }

    }
}