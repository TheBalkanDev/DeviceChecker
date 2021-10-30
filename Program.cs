using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welches iPhone wollen Sie verkaufen?");
        string iphone = Console.ReadLine();
        
        Console.WriteLine("Wie viel Speicherplatz hat das iPhone?");
        string speicher = Console.ReadLine();
        
        Console.WriteLine("Ihr iPhone ist das " + iphone + " und es hat " + speicher + " Gigabyte");
        }
    }
}
