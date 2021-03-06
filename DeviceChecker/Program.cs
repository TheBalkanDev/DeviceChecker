using System;

public class App
{
    public static void Main()
    {
        double wert = 0;
        Console.WriteLine("----------------------------");
        Console.WriteLine("Willkommen zu DeviceChecker!");
        Console.WriteLine("----------------------------");
        Console.WriteLine("                            ");
        Console.WriteLine("Welches Smartphone wollen Sie verkaufen?");
        Console.WriteLine("Zum Beispiel: iPhone 6");
        Console.WriteLine("Eine Liste aller Geräte findest du hier: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden !");
        string handy = Console.ReadLine();
        
        switch(handy)
        {
                
            case "iPhone 3G":
            case "iPhone 3g":
            case "iphone 3g":
            case "iphone 3G":
               
                wert = 15;
                Console.Clear();
                break;
                
            case "iPhone 3GS":
            case "iPhone 3gs":
            case "iPhone 3G S":
            case "iphone 3GS":
            case "iphone 3gs":
               
                wert = 15;
                Console.Clear();
                break;
                
            case "iPhone 4":
            case "iPhone4":
            case "iphone 4":
            case "iphone4":
             
             wert = 15;
             Console.Clear();
             break;
                
            case "iPhone 4s":
            case "iPhone 4S":
            case "iPhone4s":
            case "iPhone4S":
            case "iphone 4s":
            case "iphone 4S":
               
                wert = 20;
                Console.Clear();
                break;
                
            case "iPhone 5":
            case "iPhone5":
            case "iphone 5":
         
                wert = 33;
                Console.Clear();
                break;
                
            case "iPhone 5c":
            case "iPhone 5C":
            case "iPhone5c":
            case "iPhone5C":
            case "iphone 5c":
            case "iphone 5C":
                
                wert = 37; 
                Console.Clear();
                // Der exakte wert wird später hinzugefügt, bin dabei ihn zu berechnen
                break;
                
            case "iPhone 5s":
            case "iPhone 5S":
            case "iphone 5s":
            case "iphone 5S":
                
                wert = 37;
                Console.Clear();
                break;
                
            case "iPhone 6":
            case "iPhone6":
            case "iphone 6":
            case "iphone6":
                
                wert = 47;
                Console.Clear();
                break;
                
            case "iPhone 6S":
            case "iPhone 6s":
            case "iphone 6s":
            case "iphone 6S":
                
                wert = 85;
                Console.Clear();
                break;
                
            case "iPhone se":
            case "iPhone SE (2016)":
            case "iPhone se 2016":
            case "iPhone SE":
            case "iPhone SE 1":
            case "iphone se 1":
            case "iPhone SE (1th Generation)":
                
                wert = 65;
                Console.Clear();
                break;
               
            case "iPhone 7":
            case "iPhone7":
            case "iphone7":
                
                wert = 90;
                Console.Clear();
                break;
                
            case "iPhone 8":
            case "iPhone8":
            case "iphone 8":
                
                wert = 143;
                Console.Clear();
                break;
               
            case "iPhone X":
            case "iPhone 10":
            case "iPhone x":
            case "iphone x":
            case "iphoneX":
            case "iphone 10":
                
                wert = 187;
                Console.Clear();
                break;
                
            case "iPhone XS":
            case "iPhone xs":
            case "iPhone X S":
            case "iPhone 10S":
            case "iPhone 10s":
                
                wert = 280;
                Console.Clear();
                break;
                
            case "iPhone XR":
            case "iPhone xr":
            case "iPhone 10R":
            case "iPhoneXR":
                
                wert = 230;
                Console.Clear();
                break;
                
            case "iPhone XS Max":
                
                wert = 355;
                Console.Clear();
                break;
                
            case "iPhone 11":
                
                wert = 349;
                Console.Clear();
                break;
                
            case "iPhone 11 Pro":
                
                wert = 450;
                Console.Clear();
                break;
                
             case "iPhone 11 Pro Max":
                
                wert = 529;
                Console.Clear();
                break;
                
            case "iPhone 12 Mini":
                
                wert = 495;
                break;
                
            case "iPhone 12":
                
                wert = 620;
                break;
                
            case "iPhone 12 Pro":
                
                wert = 770;
                break;
                
            case "iPhone 12 Pro Max":
                
                wert = 870;
                break;
                
            default:
                Console.WriteLine("Syntax Error!");
                Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
                break;
                
                // Samsung
                
                case "Galaxy Mini 2":
                case "Samsung Galaxy Mini 2":
                case "Samsung Mini 2":
                
                wert = 12;
                break;
                
                case "Galaxy S2":
                case "Galaxy S 2":
                case "Samsung Galaxy S2":
                
                wert = 15;
                break;
                
                case "Galaxy S2 Plus":
                case "Samsung Galaxy S2 Plus":
                case "Galaxy s2 Plus":
                
                wert = 16;
                break;
                
            case "Samsung S3":
            case "Samsung Galaxy S3":
            case "Galaxy S3":
            
                wert = 20;
                break;
                
            case "Galaxy S3 Mini":
            case "Samsung Galaxy S3 Mini":
            case "Samsung S3 Mini":
                
                wert = 15;
                break;
                
            case "Samsung Galaxy S3 Neo":
            case "Galaxy S3 Neo":
            case "Samsung S3 Neo":
                
                wert = 20;
                break;
                
            case "Samsung Galaxy S3 Mini VE":
            case "Galaxy Galaxy S3 Mini ve":
            case "Samsung S3 Mini VE":
            case "Galaxy S3 Mini VE":
                
                wert = 20;
                break;
        }
        
        Console.WriteLine("Wie viel Speicherplatz hat das Gerät?");
        Console.WriteLine("Zum Beispiel 16, 32, 64, etc.");
         string speicher = Console.ReadLine();
        
        switch(speicher)
        {
         
        case "8GB":
        case "8":
                
        Console.Clear();
        break;

        case "16":
        case "16GB":
                
       Console.Clear();
       break;
              
        case "32":
        case "32GB":
        
        Console.Clear();
        break;
                
        case "64":
        case "64GB":
                
        wert = wert + 4;
        Console.Clear();
        break;
                
        case "128":
        case "128GB":
                
        wert = wert + 9;
        Console.Clear();
        break;
        
       case "256":
       case "256GB":
                
        wert = wert + 25;
        Console.Clear();
        break;
                
       default:
       Console.WriteLine("Syntax Error");
       Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
       break;         
     }
    
     Console.WriteLine("Lässt sich das Gerät einwandfrei nutzen?");
     Console.WriteLine("Optionen: Ja, Nein");
     Console.WriteLine("Oder: 1, 2");
     string funktion = Console.ReadLine();

       switch(funktion)
       {    
           case "Ja":
           case "ja":
           case "1":
           
           Console.Clear();
           break;
           
           case "Nein":
           case "nein":
           case "2":
           
           Console.WriteLine("Was für ein defekt hat es?");
           Console.WriteLine("Optionen: Wasserschaden, Sturzschaden, Andere");
           Console.WriteLine("Oder: 1, 2, 3");
           string defekt = Console.ReadLine();
               
           switch(defekt)
           {
               case "Wasserschaden":
               case "wasserschaden":
               case "Wasser schaden":
               case "Wasser Schaden":
               case "1":
                   
                   wert = 0.4 * wert;
                   Console.Clear();
                   break;
                   
               case "Sturzschaden":
               case "sturzschaden":
               case "2":
                   
                   wert = 0.7 * wert;
                   Console.Clear();
                   break;
                   
               case "Andere":
               case "andere":
               case "3":
                 
               wert = 0.5 * wert;
               Console.Clear();
               break;
                   
               default:
                   
              Console.WriteLine("Syntax Error!");
              Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
              break;
           }
           break;
           
           default: 
           Console.WriteLine("Syntax Error!");
           Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
           break;
       }
       
         Console.WriteLine("Ist der Bildschirm heil und ohne Schäden?");
         Console.WriteLine("Option: Ja oder nein");
         Console.WriteLine("Oder: 1, 2");
         string display = Console.ReadLine();
             
          switch(display)
          {
              case "Ja":
              case "ja":
              case "1":
                  
              Console.Clear();
              break;
                  
              case "Nein":
              case "nein":
              case "2":
              
             wert = 0.75 * wert;
             Console.Clear();
             break;  
                  
            default:
            Console.WriteLine("Syntax Error!");
            Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
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
                
          Console.Clear();
          break;
                
            case "Schwer zu erkennen":
            case "schwer zu erkennen":
            case "2":
            
            wert = 0.9 * wert;
            Console.Clear();
            break;
                
            case "Klar zu erkennen":
            case "klar zu erkennen":
            case "3":
            
           wert = 0.78 * wert;
           Console.Clear();
           break;
           
            default:
            Console.WriteLine("Syntax Error!");
            Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
            break;
        }
           Console.WriteLine("Ist ihre Akkukapazität unter oder über 500 Ladekyklen bzw. 80%?");
           Console.WriteLine("Optionen: über, unter");
           Console.WriteLine("Oder: 1, 2");
           string akku = Console.ReadLine();
                
            switch(akku)
          {
                case "über":
                case "1":
                    
               wert = wert + 3;
               Console.Clear();
               break;
                    
                case "unter":
                case "2":
                    
                Console.Clear();
                break;
                
                default:
                Console.WriteLine("Syntax Error!");
                Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
                break;
          }
        
        Console.WriteLine("Weisen die Glasteile Risse auf? (Hinteres Glas, Kameraobjektiv)");
        Console.WriteLine("Optionen: Ja, nein");
        Console.WriteLine("Oder: 1, 2");
        string glas = Console.ReadLine();
        
        switch(glas)
        {
            case "Ja":
            case "ja":
            case "1":
            
            Console.WriteLine("Ist das Hintere Glas oder das Kameraobjektiv beschädigt?");
            Console.WriteLine("Optionen: Hinteres Glas, Kameraobjektiv");
            Console.WriteLine("Oder: 1, 2");
                
           string glas2 = Console.ReadLine();
                
             switch(glas2)
             {
                case "Hinteres Glas":
                case "1":
                     
                 wert = 0.7 * wert;
                 Console.WriteLine("Wiki:");
                 break;
                     
             case "Kameraobjektiv":
             case "2":
                     
             Console.Clear();
             wert = 0.6 * wert;
             break;
                     
            default:
            Console.WriteLine("Syntax Error!");
            Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
            break; 
          }
           break;
   
            case "Nein":
            case "nein":
            case "2":
                
            Console.Clear();
            break;
                
            default:
                
                Console.WriteLine("Syntax Error!");
                Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
                break;
        }
           Console.WriteLine("Funktioniert der Fingerabdrucksensor oder die Gesichtserkennung?");
           Console.WriteLine("Optionen: Ja, nein");
           Console.WriteLine("Oder: 1, 2");
        
           string sensor = Console.ReadLine();
                
           switch(sensor)
           {
               case "Ja":
               case "ja":
               case "1":
                   
               Console.Clear();
               break;
                   
               case "Nein": 
               case "nein":
               case "2":
                   
               wert = 0.68 * wert;
               Console.Clear();
               break;
                   
               default:
               Console.WriteLine("Syntax Error!");
               Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
               break;
           }
        
       Console.WriteLine("Ist Zuberhör enthalten? (Ladekabel, Netzteil, Hüllen etc.");
       Console.WriteLine("Optionen: Ja, Nein");
       Console.WriteLine("Oder: 1, 2");
        
       string zuberhoer = Console.ReadLine();
        
        switch(zuberhoer)
        {
            case "Ja":
            case "ja":
            case "1":
                
                wert = wert + 3;
                Console.Clear();
                break;
                
            case "Nein":
            case "nein":
            case "2":
            
            Console.Clear();
            break;
                
            default:
                Console.WriteLine("Syntax Error!");
                Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
                break;
        }
        
        Console.WriteLine("Ist die Originalverpackung (OVP) noch vorhanden?");
        Console.WriteLine("Optionen: Ja, nein");
        Console.WriteLine("Oder: 1, 2");
        
        string ovp = Console.ReadLine();
        
        switch(ovp)
        {
            case "Ja":
            case "ja":
            case "1":
                
            wert = wert + 3;
            Console.Clear();
            break;
                
            case "Nein":
            case "nein":
            case "2":
                
                Console.Clear();
                break;
                
            default:
                Console.WriteLine("Syntax Error!");
                Console.WriteLine("Wiki: https://github.com/TheBalkanDev/DeviceChecker/wiki/Syntax-Errors-vermeiden");
                break;
        }
        
       Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
       Console.WriteLine("Analyse für " + handy + " !");
       Console.WriteLine("Der wert beträgt " + wert + " Euro");
       Console.WriteLine("Stand Jan. 2022, werte können stark schwanken, wir versuchen immer mit den neusten Preisen Up to Date zu sein!");
       Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
    }
    
    static void P(string print)
    {
      Console.WriteLine(print);
    }
        }
