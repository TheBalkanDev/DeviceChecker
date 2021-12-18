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
            case "iPhone 4":
            case "iPhone4":
                
             Console.WriteLine("Ihr Gerät: iPhone 4!");
             handy = "iPhone 4";
             wert = 15;
             break;
                
            case "iPhone 4s":
            case "iPhone 4S":
            case "iPhone4s":
            case "iPhone4S":
                
                Console.WriteLine("Ihr Gerät: Phone 4s!");
                handy = "iPhone 4s";
                wert = 23;
                break;
                
            case "iPhone 5":
            case "iPhone5":
                
                Console.WriteLine("Ihr Gerät: iPhone 5!");
                wert = 33;
                handy = "iPhone 5";
                break;
                
            case "iPhone 5c":
            case "iPhone 5C":
            case "iPhone5c":
            case "iPhone5C":
                
                Console.WriteLine("Ihr Gerät: iPhone 5C!");
                handy = "iPhone 5C";
                wert = 37; // Der exakte wert wird später hinzugefügt, bin dabei ihn zu berechnen
                break;
                
            case "iPhone 5s":
            case "iPhone 5S":
                
                wert = 35;
                string handy = "iPhone 5s";
                Console.WriteLine("Ihr Gerät: iPhone 5s!");
                break;
                
            case "iPhone 6":
            case "iPhone6":
                
                wert = 45;
                string handy = "iPhone 6";
                Console.WriteLine("Ihr Gerät: iPhone 6!");
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
                
       speicher = "16 GB";
       Console.WriteLine("Ihr Speicher: 16 GB");
       break;
              
        case "32":
        case "32GB":
        case "32gb":
        case "32 GB":
        case "32 gb":
        
        speicher = "32 GB";
        Console.WriteLine("Ihr Speicher: 32 GB");
        break;
                
        case "64":
        case "64GB":
        case "64gb":
        case "64 GB":
        case "64 gb":
                
        speicher = "64 GB";
        Console.WriteLine("Ihr Speicher: 64 GB");
        wert = wert + 4;
        break;
                
        case "128":
        case "128GB":
        case "128gb":
        case "128 GB":
        case "128 gb":
                
        speicher = "128 GB";
        Console.WriteLine("Ihr Speicher: 128 GB");
        wert = wert + 8;
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
                   
                   wert = 0.4 * wert;
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
             wert = 0.75 * wert;
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
          string zustand = "Top Zustand";
          break;
                
            case "Schwer zu erkennen":
            case "schwer zu erkennen":
            case "2":
            
            wert = 0.85 * wert;
            Console.WriteLine("Kratzer/Gebrauchsspuren am Gerät oder am Display sind schwer zu erkennen!");
            break;
                
            case "Klar zu erkennen":
            case "klar zu erkennen":
            case "3":
            
           wert = 0.73 * wert;
           Console.WriteLine("Kratzer/Gebrauchsspuren am Gerät oder am Display sind klar zu erkennen!");
           break;
           
            default:
            Console.WriteLine("Syntax Error!");
            break;
        }
                
           Console.WriteLine("Ist ihre Akkukapazität unter oder über 500 Ladekyklen bzw. 80%?");
           Console.WriteLine("Optionen: über, unter");
           string akku = Console.ReadLine();
                
            switch(akku)
          {
                case "über":
                case "über":
                    
               wert = wert + 3;
               Console.WriteLine("Ihr Akku: ist in einen guten Zustand.");
               break;
                    
                case "unter":
                case "Unter":
                    
                Console.WriteLine();
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
                     
                 wert = 0.7 * wert; // Wert Ungenau!
                 break;
                     
             case "Kameraobjektiv":
                     
             Console.WriteLine("Ihr Kameraobjektiv ist beschädigt");
             wert = 0.8 * wert;
             break;
                     
            default:
            Console.WriteLine("Syntax Error");
            break; 
          }
            
            case "Nein":
                
            Console.WriteLine("");
            break;
        }
            
           Console.WriteLine("Funktioniert der Fingerabdrucksensor oder die Gesichtserkennung?");
           string sensor = Console.ReadLine();
                
           switch(sensor)
           {
               case "Ja":
               Console.WriteLine();
               break;
                   
               case "Nein": 
               wert = 0.65 * wert;
               Console.WriteLine();
               break;
                   
               default:
               ConsoleWriteLine("Syntax Error!");
               break:
           }
        
       Console.WriteLine("Analyse für " + handy + " !");
       Console.WriteLine("Der wert beträgt " + wert + " Euro");
       Console.WriteLine("Stand Dez. 2021, werte können stark schwanken, wir versuchen immer mit den neusten Preisen Up to Date zu sein!");
          }
        }
