using System;

class Program {
  public static void Main (string[] args) {
    int sale1;
    int sale2;
    int sale3;
    var Initial1 = "E";
    var Initial2 = "E";
    var Initial3 = "E";
    
  do 
   {
      Console.WriteLine("Enter the first salesperson's initial");
      Initial1 = Console.ReadLine();
     
      if(Initial1 != "E"|| Initial1 != "e"|| Initial1 != "F"|| Initial1 != "F"|| Initial1 != "D"|| Initial1 != "d")
     {
       Console.WriteLine("Invalid initial, please re-enter");
       continue;
     }
      Console.WriteLine("Enter sale total");
      sale1 = int.Parse(Console.ReadLine());

      Console.WriteLine("Enter the second salesperson's initial");
      Initial2 = Console.ReadLine();
     
     if(Initial2 != "E"|| Initial2 != "e"|| Initial2 != "F"|| Initial2 != "F"|| Initial2 != "D"|| Initial2 != "d"|| Initial2 != "Z" || Initial2 != "z")
      {
        Console.WriteLine("Invalid initial, please re-enter");
        continue;
      }
     
     if(Initial2 == "Z" || Initial2 == "z")
     {
       sale2 = 0;
       sale3 = 0;
       break;
     }
       Console.WriteLine("Enter the next sale total");
       sale2 = int.Parse(Console.ReadLine());
      
       Console.WriteLine("Enter the third salesperson's initial");
        Initial3 = Console.ReadLine();

     if(Initial3 != "E"|| Initial3 != "e"|| Initial3 != "F"|| Initial3 != "F"|| Initial3 != "D"|| Initial3 != "d"|| Initial3 != "Z" || Initial3 != "z")
     {
       Console.WriteLine("Invalid initial, please re-enter");
       continue;
     }
     
     if(Initial3 == "Z" || Initial3 == "z")
      {
        sale3 = 0;
        break;
      }
       Console.WriteLine("Enter the next sale total");
       sale3 = int.Parse(Console.ReadLine());
     break;
     
   }while(true);
    Console.WriteLine("Grand Total: " + (sale1 + sale2 + sale3));

    if(sale1 > sale2 && sale1 > sale3)
    {
      Console.WriteLine("Highest Sale:" +Initial1 );
    }
    else if (sale2 > sale1 && sale2 > sale3) {
       Console.WriteLine("Highest Sale:" +Initial2 );
    }
    else {
       Console.WriteLine("Highest Sale:" +Initial3 );
    }
    }
   }
  
