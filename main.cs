using System;

class Program {
  public static void Main (string[] args) {
    
   Console.WriteLine ("Enter salesperson initial");
    
      var Initial = Console.ReadLine();

   Console.WriteLine ("Enter sale total");
    
      int Sale;
      int Sale2;
      int Sale3;
      int Sale4;
         Sale = int.Parse(Console.ReadLine());
  while(Initial !="Z" || Initial != "z"){
     
   if( Initial == "D" || Initial == "d" ||
       Initial == "E" || Initial == "e" ||
       Initial == "F" || Initial == "F") {
      
    Console.WriteLine("Input the next salesperson initial");
           var Initial2 = Console.ReadLine();

   Console.WriteLine("Input the next sale total");
          Sale2 = int.Parse(Console.ReadLine());
      break;
   }
     if( Initial == "Z" || Initial == "z"){
        Console.WriteLine(Sale + 150);
   break;
     }
     }
     Console.WriteLine("Hey");
  
    }

       
    }
  
