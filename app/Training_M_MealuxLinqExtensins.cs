// To avoid using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// to create xml trees
using System.Xml.Linq; 



// Anounymous Types Training. 

namespace TrainingStuffM
{

    public class ProgramM
    {

        public static void MainProcess ()
        {
            Console.WriteLine(" !!I AM THE PROGRAM M - Training of Mecalux Linq Extensions of Aggregates ");   
            
       


            
        }  

        static List<string> fruits =  new List<string> { "apple", "passionfruit", "banana", "mango", "orange", "blueberry", "grape", "strawberry" };



        // Check if an element is inside a collection

        public static void Any_OnListString()
        {
            bool thereIsBanana = fruits.Any(fruit => fruit == "banana");
            if (thereIsBanana)
            {
                Console.WriteLine("wefoundbanana");
            }
            else{
                Console.WriteLine("WE DID NOT FOUND BANANA");
            }
        }
        

        // IsEmpty() --> does not Exist!! - Just in Mecalux
        // public static void IsEmpty_OnListString()
        // {
        //     bool thereIsBanana = fruits.IsEmpty(fruit => fruit == "banana");
        //     if (thereIsBanana)
        //     {
        //         Console.WriteLine("wefoundbanana");
        //     }
        //     else{
        //         Console.WriteLine("WE DID NOT FOUND BANANA");
        //     }
        // }
        




    }
}

