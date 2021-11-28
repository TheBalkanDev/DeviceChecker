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
            case "iphone4s":
            case "iphone 4S":
            case "i phone 4s":
            case "iPhone 4s":
            case  "iPhone4S":
            caee "iPhone 4S":
            case "i Phone 4S":
                
            Console.WriteLine("Ihr Gerät: iPhone 4s!");
             wert = 25;
             break;
                
            case "iPhone6s":
            case "iphone6s":
            case "iphone 6s":
            case "i phone 6s":
            case "iPhone 6s":
            case "iPhone6S":
            caee "iPhone 6S":
            case "i Phone 6S":
                
                Console.WriteLine("Ihr Gerät: Phone 6s!");
                wert = 85;
                break;
                
            case "SamsungS4":
            case "Galaxy s4":
            case "samsung s4":
            case "Samsung S4":
            case "Galaxy S4":
            case "GalaxyS4":
            caee "Galaxy s4":
            case "Samsung Galaxy S4":
                
                Console.WriteLine("Ihr Gerät: Samsung Galaxy S4!");
                wert = 30;
                break;
                
            case "SamsungS6":
            case "Galaxy s6":
            case "samsung s6":
            case "Samsung S6":
            case "Galaxy S6":
            case "GalaxyS6":
            caee "Galaxy s6":
            case "Samsung Galaxy S6":
                
                Console.WriteLine("Samsung S6!");
                wert = 80;
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
           
         Console.WriteLine("Sind Kratzer/Gebrauchsspuren am Gerät oder am Display zu erkennen?");
         string kratzer = Console.ReadLine()
             
          switch(kratzer)
          {
              case "Viele":
               
         // Ende
        Console.WriteLine("Analyse: Ihr Smartphone ist das " + iphone + " und es hat " + speicher + " Gigabyte. Der wert beträgt" + zwischenergebnis + " Euro!");
          }
        }
     }
  }
