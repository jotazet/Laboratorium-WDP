namespace Laboratorium5
{
    class Program
    {
        static string[] menuItems = new string[6];
        
        const int Add = 0;
        const int Remove = 1;
        const int Find = 2;
        const  int totalCost = 3;
        const int printAll = 4;
        const int exit = 5;
        static string[] Names = new String[100];
        static decimal[] Prices = new decimal[Names.Length];
        private static int LastIndex = -1;
        
        static void Main(string[] args)
        {
            SetupMenu();
            int option = 0;
            do
            {
                PrintMenu(Find);
                option = SelectOptionFromKeyboard();
                Process(option);
            } while (option != exit);
            
        }


        static void Process(int option)
        {
            switch (option)
            {
                case Add:
                {
                    Console.Clear();
                    Console.Write("Input product name: ");
                    string name = Console.ReadLine();
                    LastIndex++;
                    Names[LastIndex] = name;
                    Console.WriteLine("Input produc price: ");
                    string priceStr = Console.ReadLine();
                    if (decimal.TryParse(priceStr, out decimal price))
                    {
                        Prices[LastIndex] = price;
                    }
                    else
                    {
                        Console.WriteLine("Invalid price!");
                        Console.WriteLine("Product not added!");
                        LastIndex--;
                    }
                    
                    break;
                }
                case Remove:
                    Console.WriteLine("Remove");
                    break;
                case Find:
                    Console.WriteLine("Find");
                    break;
                case totalCost:
                    Console.WriteLine("totalCost");
                    break;
                case printAll:
                    Console.WriteLine("totalCost");
                    break;
                case exit:
                    Environment.Exit(0);
                    break;
            }
        }
        static void SetupMenu()
        {
            menuItems[Add] = "1. Add";
            menuItems[Remove] = "2. Remove last";
            menuItems[Find] = "3. Find";
            menuItems[totalCost] = "4. Total cost";
            menuItems[printAll] = "5. Print all";
            menuItems[exit] = "6. Exit";
        }

        static int SelectOptionFromKeyboard()
        {
            int selectedOptionIndex = 0;

            do
            {
                PrintMenu(selectedOptionIndex);

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.UpArrow:
                        selectedOptionIndex--;

                        if (selectedOptionIndex < 0)
                        {
                            selectedOptionIndex = menuItems.Length - Remove;
                        }

                        break;
                    case ConsoleKey.DownArrow:
                        selectedOptionIndex++;

                        if (selectedOptionIndex >= menuItems.Length)
                        {
                            selectedOptionIndex = 0;
                        }

                        break;
                    case ConsoleKey.Enter:
                        return selectedOptionIndex;
                    default:
                        break;
                }
            } while (true);
        }

        static void PrintMenu(int selectedOptionIndex = 0)
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == selectedOptionIndex)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.ForegroundColor = ConsoleColor.White;
                }

                Console.WriteLine(menuItems[i]);
            }

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

}
