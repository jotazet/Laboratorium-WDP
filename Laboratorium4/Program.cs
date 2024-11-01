namespace Laboratorium4
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
            //Zadanie8();
            Zadanie9();
        }
        public static void Zadanie1()
        {
            double[] factors = { 2.4, 1.9, -0.5};
            double x = 2.3;
            if (factors.Length != 3)
            {
                Console.WriteLine("Nie można obliczyć równania");
            }
            else
            {
                Console.WriteLine(factors[0] * x * x + factors[1] * x + factors[2]);
            }
        }
        public static void Zadanie2()
        {
            double[] arr = { 12.5, 6.7, 2.89, 10.1, 2.45 };
            for (int i = arr.Length - 1; i >= 0; --i)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public static void Zadanie3()
        {
            int sum = 0;

            Console.WriteLine("Wprowadź pierwszą liczbę: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    Console.WriteLine($"Wpisałeś poprawnie liczbę: {value}");
                    sum += value;
                }
                else
                {
                    Console.WriteLine("Nie wpisałeś liczby całkowitej!");
                    Console.WriteLine($"Suma: {sum}");
                    break;
                }
            }
        }
        public static void Zadanie4()
        {
            double[,] arr = { 
                { 1.1, 3.5, 2.56 }, 
                { 1.4, 34, 7 }, 
                { 1.5, 56, 2.6 } 
            };
            double b = 4.1;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (arr[i, j] > b)
                    {
                        Console.WriteLine(arr[i, j]);
                    }
                }
            }
        }
        public static void Zadanie5()
        {
            int row = 1;
            while (true)
            {
                Console.Write("Podaj liczbę: ");
                if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write(new string('#', row));
                        row += 1;
                        Console.WriteLine();
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Liczba powinna być większa od 0!");
                }
            }
        }
        public static void Zadanie6()
        {
            Console.Write("Podaj wielkość tabeli: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                double[] values = new double[n];

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{i + 1}: ");
                    if (double.TryParse(Console.ReadLine(), out double temp))
                    {
                        values[i] = temp;
                    }
                    else
                    {
                        Console.WriteLine("Niepoprawna wartość!");
                        i--;
                    }
                }

                Console.WriteLine("Co druga w odwrotnej kolejności: ");
                for (int i = n - 1; i >= 0; i -= 2)
                {
                    Console.WriteLine(values[i]);
                }
            }
            else
            {
                Console.WriteLine("Wielkość powinna być większa od 0!");
            }
        }
        public static void Zadanie7()
        {
            int n, m;
            try
            {
                Console.Write("Podaj liczbę wierszy (n): ");
                n = int.Parse(Console.ReadLine() ?? string.Empty);
                Console.Write("Podaj liczbę kolumn (m): ");
                m = int.Parse(Console.ReadLine() ?? string.Empty);

                if (n < 1 || m < 1)
                {
                    Console.WriteLine("Liczby n i m muszą być większe od 0.");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Błędna wartość!");
                return;
            }

            char[,] tablica = new char[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == 0 || i == n - 1 || j == 0 || j == m - 1)
                    {
                        tablica[i, j] = '#'; 
                    }
                    else
                    {
                        tablica[i, j] = ' ';
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(tablica[i, j]);
                }
                Console.WriteLine();
            }
        }
        public static void Zadanie8()
        {
            long n = 564454425037897435L;
            Console.WriteLine(n.ToString().Length);
        }
        public static void Zadanie9()
        {
            Console.Write("Podaj liczbę: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write(new string(' ', i));
            
                    Console.WriteLine(new string('#', (2 * (n - i) - 1)));
                }
            }
            else
            {
                Console.WriteLine("Liczba powinna być większa od 0!");
            }
        }
    }
}