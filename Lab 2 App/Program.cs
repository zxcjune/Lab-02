using System;
using ClassLibrary1;

namespace Lab_2_App
{
    class Program
    {
       public static void Main(string[] args)
        {
            TV[] arrTVs;
            Console.Write("Enter quantity of TVs: ");
            int TVsCount = Convert.ToInt32(Console.ReadLine());
            arrTVs = new TV[TVsCount];
            for(int i = 0; i < TVsCount; i++)
            {
                Console.WriteLine("Enter the model:");
                string model = Console.ReadLine();

                Console.WriteLine("Enter the diagonal:");
                string diagonal = Console.ReadLine();

                Console.WriteLine("Enter the display:");
                string display = Console.ReadLine();

                Console.WriteLine("Enter the resolution:");
                string resolution = Console.ReadLine();

                Console.WriteLine("Enter the platform:");
                string platform = Console.ReadLine();

                Console.WriteLine("Enter the tuner:");
                string tuner = Console.ReadLine();

                Console.WriteLine("Enter the AI:");
                ConsoleKeyInfo KeyHasAI = Console.ReadKey();
                Console.WriteLine();

                TV tv = new TV
                {
                    Model = model,
                    Diagonal = diagonal,
                    Display = display,
                    Resolution = resolution,
                    Platform = platform,
                    Tuner = tuner,
                    HasAI = KeyHasAI.Key == ConsoleKey.Y ? true : false
                };
                arrTVs[i] = tv;
            }
            int counter = 1;
            foreach(TV tv in arrTVs)
            {
                Console.WriteLine("-------------");
                Console.WriteLine($"TV[{counter++}] Details:");
                Console.WriteLine("-------------");
                Console.WriteLine($"Model: {tv.Model}");
                Console.WriteLine($"Diagonal: {tv.Diagonal}");
                Console.WriteLine($"Display: {tv.Display}");
                Console.WriteLine($"Resolution: {tv.Resolution}");
                Console.WriteLine($"Platform: {tv.Platform}");
                Console.WriteLine($"Tuner: {tv.Tuner}");
                Console.WriteLine($"AI: {(tv.HasAI ? "Have AI" : "Doesnt have AI") }");
                Console.WriteLine($"4k = {tv.TV4k}");
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
