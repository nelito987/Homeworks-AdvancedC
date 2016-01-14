using System;
using System.Collections.Generic;
using System.Linq;


    class stringLenght
    {
        static void Main()
        {
            Console.WriteLine("Please enter text:");
            string text = Console.ReadLine();
            
            if(text.Length > 20)
            {                
                Console.WriteLine(text.Substring(0, 20));
            }
            else  
            {
                Console.WriteLine(text.PadRight(20, '*'));
            }
        }
    }

