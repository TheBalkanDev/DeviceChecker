using System;

public class Programj
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
            case "iPhone 4S":
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
            case "iPhone 6S":
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
            case "Galaxy s4":
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
         string speicher = Console.ReadLine();
        
        switch(speicher)
        {
        case "16":
        case "16GB":
        case "16gb":
        case "16 GB":
        case "16 gb":
                
       Console.WriteLine("Ihr Speicher: 16 GB");
       break;
              
        case "32":
        case "32GB":
        case "32gb":
        case "32 GB":
        case "32 gb":
                
        Console.WriteLine("Ihr Speicher: 32 GB");
        break;
                
        case "64":
        case "64GB":
        case "64gb":
        case "64 GB":
        case "64 gb":
                
        Console.WriteLine("Ihr Speicher: 64 GB");
        wert = + 5;
        break;
                
        case "128":
        case "128GB":
        case "128gb":
        case "128 GB":
        case "128 gb":
                
        Console.WriteLine("Ihr Speicher: 128 GB");
        wert = wert + 10;
        break;
                
       default:
       Console.WriteLine("Error";
       break;         
     }
                                  
     Console.WriteLine("Lässt sich das Gerät einwandfrei nutzen?");
     string funktion = Console.ReadLine();
                                  
       switch(funktion)
       {    
           case "Ja":
           case "ja":
           
           Console.WriteLine("Alles klar");
           break;
           
           case "Nein":
           case "nein":
           
           Console.WriteLine("Alles klar");
           break;
           
         Console.WriteLine("Sind Kratzer/Gebrauchsspuren am Gerät oder am Display zu erkennen?");
         string kratzer = Console.ReadLine()
             
          switch(kratzer)
          {
              case "Viele":
              case "viele":
                  
              Console.WriteLine();
              break;
                  
              default:
              Console.WriteLine("Error")
          }
           
        Console.WriteLine("Analyse: Ihr Smartphone ist das " + handy + " und es hat " + speicher + " Gigabyte. Der wert beträgt" + wert + " Euro!");
          }
        }
