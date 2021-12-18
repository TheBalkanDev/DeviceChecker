using System;

public class App
{
    public static void Main()
    {
        double wert = 0;
        Console.WriteLine("----------------------------");
        Console.WriteLine("Willkommen zu DeviceChecker, Version 0.0.1!");
        Console.WriteLine("----------------------------");
        Console.WriteLine("                            ");
        Console.WriteLine("Welches Smartphone wollen Sie verkaufen?");
        Console.WriteLine("Zum Beispiel: iPhone 6");
        string handy = Console.ReadLine();
        
        switch(handy)
        {
            case "iPhone 4":
            case "iPhone4":
             
             wert = 15;
             break;
                
            case "iPhone 4s":
            case "iPhone 4S":
            case "iPhone4s":
            case "iPhone4S":
               
                handy = "iPhone 4s";
                wert = 23;
                break;
                
            case "iPhone 5":
            case "iPhone5":
         
                wert = 33;
                break;
                
            case "iPhone 5c":
            case "iPhone 5C":
            case "iPhone5c":
            case "iPhone5C":
                
                wert = 37; // Der exakte wert wird später hinzugefügt, bin dabei ihn zu berechnen
                break;
                
            case "iPhone 5s":
            case "iPhone 5S":
                
                wert = 35;
                break;
                
            case "iPhone 6":
            case "iPhone6":
                
                wert = 45;
                break;
               
            default:
                Console.WriteLine("Syntax Error!");
                break;
        }
        
        Console.Clear();
        Console.WriteLine("Wie viel Speicherplatz hat das Gerät?");
        Console.WriteLine("Zum Beispiel 16, 32, 64, etc.");
         string speicher = Console.ReadLine();
        
        switch(speicher)
        {
        case "16":
        case "16GB":
                
       Console.WriteLine();
       break;
              
        case "32":
        case "32GB":
        
        Console.WriteLine();
        break;
                
        case "64":
        case "64GB":
                
        wert = wert + 4;
        break;
                
        case "128":
        case "128GB":
                
        wert = wert + 8;
        break;
                
       default:
       Console.WriteLine("Syntax Error");
       break;         
     }
     
     Console.Clear();
     Console.WriteLine("Lässt sich das Gerät einwandfrei nutzen?");
     Console.WriteLine("Optionen: Ja, Nein");
     string funktion = Console.ReadLine();

       switch(funktion)
       {    
           case "Ja":
           case "ja":
           
           Console.WriteLine();
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
                   break;
                   
               case "Sturzschaden":
               case "sturzschaden":
                   
                   wert = 0.7 * wert;
                   break;
                   
               case "Andere":
               case "andere":
                 
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
        
         Console.Clear();
         Console.WriteLine("Ist der Bildschirm heil und ohne Schäden?");
         Console.WriteLine("Option: Ja oder nein");
         string display = Console.ReadLine();
             
          switch(display)
          {
              case "Ja":
              case "ja":
                  
              Console.WriteLine();
              break;
                  
              case "Nein":
              case "nein":
              
             Console.WriteLine();
             wert = 0.75 * wert;
             break;  
                  
            default:
            Console.WriteLine("Syntax Error!");
            break;
          }
        
        Console.Clear();
        Console.WriteLine("Sind Kratzer/Gebrauchsspuren am Gerät oder am Display zu erkennen?");
        Console.WriteLine("Optionen: Nein, Schwer zu erkennen, Klar zu erkennen");
        Console.WriteLine("Oder 1, 2 oder 3");
        string gebrauchsspuren = Console.ReadLine();
        
        switch(gebrauchsspuren)
        {
            case "Nein":
            case "nein":
            case "1":
                
          Console.WriteLine();
          break;
                
            case "Schwer zu erkennen":
            case "schwer zu erkennen":
            case "2":
            
            wert = 0.85 * wert;
            Console.WriteLine();
            break;
                
            case "Klar zu erkennen":
            case "klar zu erkennen":
            case "3":
            
           wert = 0.73 * wert;
           Console.WriteLine();
           break;
           
            default:
            Console.WriteLine("Syntax Error!");
            break;
        }
           Console.Clear();
           Console.WriteLine("Ist ihre Akkukapazität unter oder über 500 Ladekyklen bzw. 80%?");
           Console.WriteLine("Optionen: über, unter");
           string akku = Console.ReadLine();
                
            switch(akku)
          {
                case "über":
                    
               wert = wert + 3;
               Console.WriteLine();
               break;
                    
                case "unter":
                    
                Console.WriteLine();
                break;
                
                default:
                Console.WriteLine("Syntax Error!");
                break;
          }
        
        Console.Clear();
        Console.WriteLine("Weisen die Glasteile Risse auf? (Hinteres Glas, Kameraobjektiv)");
        string glas = Console.ReadLine();
        
        switch(glas)
        {
            case "Ja":
            case "ja":
            
            Console.WriteLine("Ist das Hintere Glas oder das Kameraobjektiv beschädigt?");
            Console.WriteLine("Optionen: Hinteres Glas, Kameraobjektiv");
            Console.WriteLine("Oder: 1, 2);
                
           string glas2 = Console.ReadLine();
                
             switch(glas2)
             {
                case "Hinteres Glas":
                case "1":
                     
                 wert = 0.7 * wert; // Wert Ungenau!
                 break;
                     
             case "Kameraobjektiv":
             case "2":
                     
             Console.WriteLine();
             wert = 0.8 * wert;
             break;
                     
            default:
            Console.WriteLine("Syntax Error!");
            break; 
          }
           break;
   
            case "Nein":
            case "nein":
                
            Console.WriteLine("");
            break;
                
            default:
                
                Console.WriteLine("Syntax Error!");
                break;
        }
           Console.Clear();
           Console.WriteLine("Funktioniert der Fingerabdrucksensor oder die Gesichtserkennung?");
           Console.WriteLine("Optionen: Ja, nein");
           string sensor = Console.ReadLine();
                
           switch(sensor)
           {
               case "Ja":
               case "ja":
               Console.WriteLine();
               break;
                   
               case "Nein": 
               case "nein":
                   
               wert = 0.65 * wert;
               Console.WriteLine();
               break;
                   
               default:
               Console.WriteLine("Syntax Error!");
               break;
           }
        
       Console.Clear();
       Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
       Console.WriteLine("Analyse für " + handy + " !");
       Console.WriteLine("Der wert beträgt " + wert + " Euro");
       Console.WriteLine("Stand Dez. 2021, werte können stark schwanken, wir versuchen immer mit den neusten Preisen Up to Date zu sein!");
       Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
          }
        }
