using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welches iPhone wollen Sie verkaufen?");
        string iphone = Console.ReadLine();
        
        Console.WriteLine("Wie vieli Speicherplatz hat das iPhone?");
        string speicher = Console.ReadLine();
        
        Console.WriteLine("Ihr iPhone ist das " + iphone + " und es hat " + speicher + " Gigabyte");
        
        switch (iphone)
        {
         case iphone5s:
         Console.WriteLine("iPhone 5s");
                break;
                
          case iphone7:
                Console.WriteLine("iPhone 7!");
                break;
                
            default:
            Console.WriteLine("Error, Unbekanntes iPhone");
                break;
        }
    }
}
