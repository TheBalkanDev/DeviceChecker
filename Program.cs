using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Welches Smartphone wollen Sie verkaufen?");
        string handy = Console.ReadLine();
        
        switch(handy)
        {
            case "iPhone4s":
             Console.WriteLine("iPhone 4s!");
                break;
                
            case "iPhone6s":
                Console.WriteLine("iPhone 6s!");
                break;
                
            case "SamsungS4":
                Console.WriteLine("Samsung S4!");
                break;
                
             case "SamsungS6":
                Console.WriteLine("Samsung S6!");
                break;
                
            default:
                Console.WriteLine("Syntax Error");
                break;
        }
        
        Console.WriteLine("Wie viel Speicherplatz hat das Gerät?");
        int speicher = Console.ReadLine();
        
        switch(speicher)
        {
        case 16:
           Console.WriteLine("16 GB");
           break;
              
         case 32:
             Console.WriteLine("32 GB");
                break;
                
          case 64
             Console.WriteLine("64 GB");
             break;
                
           case 128:
               Console.WriteLine("128 GB");
               break;
 
        Console.WriteLine("Analyse: Ihr Smartphone ist das " + iphone + " und es hat " + speicher + " Gigabyte");
        }
    }
}
