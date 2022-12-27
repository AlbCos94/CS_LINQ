// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Collections;
using System.Collections.Generic;



namespace TrainingStuff{

    public class ProgramA
    {
        
        public void MainProcess ()
        {
      
            Console.WriteLine("Some C sharp trainning: ");

            // COMPOSE DATA TYPES

            // ArrayList - fix matrix
            // 3x2 Data set defined with an array:

            int [,] nums = new int [3,2]
            {
                {1, 11},
                {2, 22},
                {3, 33}
            };

            //Console.WriteLine("ee: " );
            //Console.WriteLine(nums.Length ); // it takes the whole amount of elements -> 6
            // normal for to go through the colleciont of the array

            /*
            for ( int i=0; i<3; ++i)
            {
                for ( int j =0; j<2; ++j)
                {
                    Console.WriteLine(nums[i,j]);
                }
            }
            */

            // Use of the "Forearch" to iterate among collections

            // the variable used to iterate though the colleciont is an "IEnumerator" which is an iterator that allows to keet
            // the reference to the current position, move it and reset it
            // in the following example:
            foreach (var item in nums)
            {
                Console.WriteLine( item );                

            }


            // List - matrix can grow dynamically
            ArrayList myArrayList = new ArrayList();
            myArrayList.Add("Hello");
            myArrayList.Add("Albert");
            myArrayList.Add("mecalux");




            // normal "for" to iterate among a collection of objects
            /*
            for ( int i=0; i< myArrayList.Count; ++i)
            {
                Console.WriteLine(myArrayList[i]);

            }
            */

            // Use of the "Forearch" to iterate among collections
            foreach (var i in myArrayList)
            {
                Console.WriteLine( i );                

            }

            // "i" is actually an iterator of the type "IEnumertator<T>"
            // the methods that are being used to move through are:
                // current
                // MoveNext()
                // Reset()  

            // the compiler generates the following code equivalent to "foreach"

            var enumerator_i = myArrayList.GetEnumerator();

            // print type of the enumerator
            Console.WriteLine("Type of the enumerator is: ");
            Console.WriteLine(enumerator_i.GetType()); // prints System.String


            try
            {
                while (enumerator_i.MoveNext())
                {
                    var item = enumerator_i.Current;
                    // what we do with each element:
                    Console.WriteLine(item.ToString());

                }

            }
            finally
            {
                //dispose if required
            }
            

        }


    }

}

