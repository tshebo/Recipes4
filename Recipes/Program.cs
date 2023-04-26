internal class Program
{
    static bool loop = true;
    
    private static void Main(string[] args)
    {
       while(loop)
        {
            Menu();
        } 
    }

    static string Menu()
    {
        string choice = "";

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("=============================Welcome to the recipe app choose between the provided options==============================");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\nWhat would you like to do?");
        Console.WriteLine("1. Add ingredients");
        Console.WriteLine("2. Add steps");
        Console.WriteLine("3. Display recipe ");
        Console.WriteLine("4. Scaling Options ");
        Console.WriteLine("5. Clear Data ");
        Console.WriteLine("Any key to Exit");

        Console.ForegroundColor = ConsoleColor.Blue;
        choice =Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Blue;
        return choice;
    }

    static void validateChoice(string menu)
    {
        if (menu.Equals("1"))
        {
            Console.WriteLine("===== Add Ingredients =====");
        }
        else if(menu.Equals("2"))
        {
            Console.WriteLine("===== Add Steps =====");
        }
        else if (menu.Equals("3"))
        {
            Console.WriteLine("===== Display Recipe =====");
        }
        else if (menu.Equals("4"))
        {
            Console.WriteLine("===== Scaling Options =====");
        }
        else if (menu.Equals("5"))
        {
            Console.WriteLine("===== Clear Data =====");
        }
        else  
        {
            Console.WriteLine("===== Exit App =====");
        }
    }

    
}