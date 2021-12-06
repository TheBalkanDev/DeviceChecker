using System;

public class Program
{
    public static void Main()
    {
        double wert = 0;
        Console.WriteLine("Welches Smartphone wollen Sie verkaufen?");
        string handy = Console.ReadLine();
        
        switch(handy)
        {
            case "Iphone 4s":
            case "iPhone4s":
            case "iphone4s":
            case "iphone 4S":
            case "i phone 4s":
            case "iPhone 4s":
            case  "iPhone4S":
            case "iPhone 4S":
            case "i Phone 4S":
                
            Console.WriteLine("Ihr Gerät: iPhone 4s!");
             handy = "iPhone 4s";
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
                string handy = "iPhone 6s";
                wert = 85;
                break;
                
            case "SamsungS4":
            case "Galaxy s4":
            case "samsung s4":
            case "Samsung S4":
            case "Galaxy S4":
            case "GalaxyS4":
            case "Samsung Galaxy S4":
                
                Console.WriteLine("Ihr Gerät: Samsung Galaxy S4!");
                wert = 30;
                handy = "Samsung Galaxy S4";
                break;
                
            case "SamsungS6":
            case "Galaxy s6":
            case "samsung s6":
            case "Samsung S6":
            case "Galaxy S6":
            case "GalaxyS6":
            case "Galaxys6":
            case "Samsung Galaxy S6":
                
                Console.WriteLine("Samsung S6!");
                handy = "Samsung Galaxy S6";
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
        wert = wert + 5;
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
       Console.WriteLine("Error");
       break;         
     }
                                  
     Console.WriteLine("Lässt sich das Gerät einwandfrei nutzen?");
     string funktion = Console.ReadLine();

       switch(funktion)
       {    
           case "Ja":
           case "ja":
           
           Console.WriteLine("Das Gerät lasst sich einwandfrei nutzen!");
           break;
           
           case "Nein":
           case "nein":
           
           Console.WriteLine("Was für ein defekt hat es?");
           Console.WriteLine("Optionen: Wasserschaden, Sturzschaden, Andere");
           string defekt = Console.ReadLine();
               
           switch(defekt)
           {
               case "Wasserschaden":
               case "wasserschaden":
               case "Wasser schaden":
               case "Wasser Schaden":
                   
                   wert = 0.45 * wert;
                   Console.WriteLine("Defekt: Wasserschaden");
                   break;
                   
               case "Sturzschaden":
               case "sturzschaden":
                   
                   wert = 0.7 * wert;
                   Console.WriteLine("Defekt: Sturzschaden");
                   break;
                   
               case "Andere":
               case "andere":
                   
               Console.WriteLine("Defekt: Abdere");
               wert = 0.5 * wert;
               break;
                   
               default:
                   
              Console.WriteLine("Syntax Error!");
              break;
           }
           break;
           
           default: 
           Console.WriteLine("Syntax Error!");
           break;
       }
        
         Console.WriteLine("Ist der Bildschirm heil und ohne Schäden?");
         Console.WriteLine("Option: Ja oder nein");
         string display = Console.ReadLine();
             
          switch(display)
          {
              case "Ja":
              case "ja":
                  
              Console.WriteLine("Das Display ist in einem Top zustand!");
              break;
                  
              case "Nein":
              case "nein":
              
             Console.WriteLine("Der Bildschirm ist nicht heil und und/oder hat Schäden");
             wert = 0.8 * wert;
             break;  
                  
            default:
            Console.WriteLine("Syntax Error");
            break;
          }
        
        Console.WriteLine("Sind Kratzer/Gebrauchsspuren am Gerät oder am Display zu erkennen?");
        Console.WriteLine("Optionen: Nein, Schwer zu erkennen, Klar zu erkennen");
        Console.WriteLine("Oder 1, 2 oder 3");
        string gebrauchsspuren = Console.ReadLine();
        
        switch(gebrauchsspuren)
        {
            case "Nein":
            case "nein":
            case "1":
                
          Console.WriteLine("Es sind keine Kratzer/Gebrauchsspuren am Gerät oder am Display zu erkennen!");
          string zustand = "TOP";
          break;
                
            case "Schwer zu erkennen":
            case "schwer zu erkennen":
            case "2":
            
            wert = 0.8 * wert;
            Console.WriteLine("Kratzer/Gebrauchsspuren am Gerät oder am Display sind schwer zu erkennen!");
            break;
                
            case "Klar zu erkennen":
            case "klar zu erkennen":
            case "3":
            
           wert = 0.9 * wert;
           Console.WriteLine("Kratzer/Gebrauchsspuren am Gerät oder am Display sind klar zu erkennen!");
           break;
           
            default:
            Console.WriteLine("Syntax Error!");
            break;
        }
                
           Console.WriteLine("Ist ihre Akkukapazität unter oder über 80%?");
           Console.WriteLine("Optionen: über, unter");
           string akku = Console.ReadLine();
                
            switch(akku)
          {
                case "über":
                case "üüber":
                    
               wert = wert + 4;
               Console.WriteLine("Ihr Akku: Über 80%");
               break;
                    
                case "unter":
                case "Unter":
                    
                Console.WriteLine("Ihr Akku: Unter 80%!");
                break;
                
                default:
                Console.WriteLine("Syntax Error");
                break;
          }
        
        Console.WriteLine("Weisen die Glasteile Risse auf? (Hinteres Glas, Kameraobjektiv)");
        string glas = Console.ReadLine();
        
        switch(glas)
        {
            case "Ja":
            
            Console.WriteLine("Ist das Hintere Glas oder das Kameraobjektiv beschädigt?");
            string glas2 = Console.ReadLine();
            break;
                
             switch(glas2)
             {
                case "Hinteres Glas":
                     
                 wert =- 15;
                 break;
                     
             case "Kameraobjektiv":
                     
             Console.WriteLine("Ihr Kameraobjektiv ist beschädigt");
             wert =-3;
             break;
                     
            default:
            Console.WriteLine("Syntax Error");
            break; 
          }
            
            case "Nein":
                
            Console.WriteLine("");
            break;
            // Später
        }
        
       Console.WriteLine("Analyse für " + handy + " !");
       Console.WriteLine("Der wert beträgt " + wert + " Euro");
       Console.WriteLine("Stand Dez. 2021, werte können stark schwanken, wir versuchen immer mit den neusten Preisen Up to Date zu sein!");
          }
        }
