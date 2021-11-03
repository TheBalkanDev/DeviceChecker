using System;

public class Program
{
    public static void Main()
    {
        double wert;
        Console.WriteLine("Welches Smartphone wollen Sie verkaufen?");
        string handy = Console.ReadLine();
        
        switch(handy)
        {
            case "iPhone4s":
             Console.WriteLine("iPhone 4s!");
             wert = 25;
             break;
                
            case "iPhone6s":
                Console.WriteLine("iPhone 6s!");
                wert = 80;
                break;
                
            case "SamsungS4":
                Console.WriteLine("Samsung S4!");
                wert = 25;
                break;
                
             case "SamsungS6":
                Console.WriteLine("Samsung S6!");
                wert = 75;
                break;
                
            default:
                Console.WriteLine("Syntax Error");
                break;
        }
        
        Console.WriteLine("Wie viel Speicherplatz hat das Gerät?");
        int speicher = Console.ReadLine();
        
        double zwischenergebniss;
        
        switch(speicher)
        {
        case 16:
           Console.WriteLine("16 GB");
           zwischenergebniss = wert;
           break;
              
         case 32:
             Console.WriteLine("32 GB");
             zwischenergebniss = wert;
                break;
                
            case 64:
             Console.WriteLine("64 GB");
             zwischenergebniss = wert + 5;
             break;
                
           case 128:
               Console.WriteLine("128 GB");
               zwischenergebniss = wert + 10;
               break;
                
            default:
                Console.WriteLine("Error";
                break;
        }
                                  
     Console.WriteLine("Lässt sich das Gerät einwandfrei nutzen?");
     string funktion = Console.ReadLine();
     bool funktion;
                                  
       switch(funktion)
       {    
           case "Ja":
           Console.WtiteLine("Ja");
           funktion2 = true;
           break;
           
           case "Nein";
           Console.WriteLine("Nein");
           funktion2 = false;
           break;
           
        Console.WriteLine("Analyse: Ihr Smartphone ist das " + iphone + " und es hat " + speicher + " Gigabyte. Der wert beträgt" + zwischenergebnis + " Euro!");
        }
    }
