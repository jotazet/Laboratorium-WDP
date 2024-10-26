namespace Laboratorium2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zadanie1();
            //Zadanie2();
            //Zadanie3();
            //Zadanie4();
            //Zadanie5();
            //Zadanie6();
        }
        public static void Zadanie1()
        {
            int number = 56;
            int cyfraSetek = number / 100;
            int cyfraDziesiatek = number / 10 % 10;
            int cyfraJednosci = number % 10;
            Console.WriteLine($"Cyfra setek: {cyfraSetek}");
            Console.WriteLine($"Cyfra dziesiątek: {cyfraDziesiatek}");
            Console.WriteLine($"Cyfra jedności: {cyfraJednosci}");
        }
        public static void Zadanie2()
        {
            double degree = 45;
            double radians = degree * (Math.PI / 180);
            double sinValue = Math.Sin(radians);

            Console.WriteLine(sinValue);
        }
        public static void Zadanie3() 
        {
            double area = 189;

            if(area <= 0)
                Console.WriteLine(0);

            double radius = Math.Sqrt(area / Math.PI);

            Console.WriteLine(radius);
        }
        public static void Zadanie4()
        {
            double x = 0.45;
            double a = 1.5;
            double b = 3.2;
            double c = 4;
            double y = a * x * x + b * x + c;
            Console.WriteLine(y);
        }
        public static void Zadanie5()
        {
            int a = 9;
            int b = 6;
            int c = 2;
            int max = Math.Max(Math.Max(a, b), c);
            int min = Math.Min(Math.Min(a, b), c);
            Console.WriteLine($"Max = {max}");
            Console.WriteLine($"Min = {min}");
        }
        public static void Zadanie6()
        {
            double time = 1234.45; // czas w minutach
            int totalSeconds = (int)(time * 60);

            int hours = totalSeconds / 3600;
            int minutes = totalSeconds % 3600 / 60;
            int seconds = totalSeconds % 60;
            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}