// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Anounymous Types Training. 

namespace TrainingStuffD{

    public class ProgramD
    {    
        static List<int> MyListOfInt = new List<int>();
        static void FillValues()
        {
            MyListOfInt.Add(1);
            MyListOfInt.Add(2);
            MyListOfInt.Add(3);
            MyListOfInt.Add(4);
            MyListOfInt.Add(5);
        } 



        public void MainProcess ()
        {
            Console.WriteLine(" !!I AM THE PROGRAM D - Training of Yield!! ");
            
            // YIELD
            //"Yield Keyword helps to do custom stateful iteration over a collection"
            // tutorial based on: https://www.youtube.com/watch?v=4fju3xcm21M


            // CUSTOM ITERATION
            // WE DO SOMETHING TO A COLLECTIN AND FOR SOME ELEMENTS WE PASS THEM TO A FUNCTION USING "YIELD RETURN" IN SUCH A WAY THAT WHEN 
            // WE GO BACK TO THAT COLLECTION THE POSITION OF THE LAST ELEMENT IS REMEMBERED AND WE START FROM IT.

            /*
            When a yield return statement is reached in the iterator method, expression is returned, and the current location in code is retained. 
            Execution is restarted from that location the next time that the iterator function is called. 
            The return type must be IEnumerable, IEnumerable<T>, IEnumerator, or IEnumerator<T>.
            */

            Console.WriteLine("FIRST LIST: ");
            FillValues();
            foreach (int i in MyListOfInt)
            {
                Console.WriteLine(i);
            }
            //Console.ReadLine();

            Console.WriteLine("NEXT LIST: ");

            // WHAT IF WE WANT TO PLOT ELEMENTS IN POSITION GREATER THAT 3 (??¿¿)
            static IEnumerable<int> Filter()
            {
                List<int> temp = new List<int>();
                foreach (int i in MyListOfInt)
                {
                    if (i>3)
                    {
                        temp.Add(i);
                    }
                }
                return temp;
            }

            foreach (int i in Filter())
            {
                Console.WriteLine(i);
            }

            // HOW TO WRITE A FUNCTION THAT ITERATES AMONG A COLLECTIN WITHOUT HAVING TO CREATE A COPY OF THAT ITERATOR
            // --> WE ARE GONNA CREATE A FUNCTION THAT RETURNS AN ITERATOR OF THE COLLECTION AND NOT A TEMPORARY LIST
            static IEnumerable<int> Filter2()
            {
                foreach (int i in MyListOfInt)
                {
                    if (i>3)
                    {
                        yield return i; // it remembers last position of the collection when the yield return is called to come back to it ( IT WILL COME BACK WITH I = 4)
                        // WE MOVE FROM THE SOURCE FUNCTION TO THE COLLECTION REMEMBERING THE LAST ELEMENT OF THE COLLECTION
                    }
                }
            }   

            Console.WriteLine("NEXT LIST USING YIELD: ");

            foreach (int i in Filter2())
            {
                Console.WriteLine(i);
            }
        }

        
            // STATEFUL ITERATION
            // --> SE INTERUMPE FUNCION PARA DEVOLVER ALGO ESPECIFIO CON EL "YELD RETURN" Y LUEGO SE VUELVE A ELLA PARA CONTINUAR DONDE LO HABIAMOS DEJADO
            //When a yield return statement is reached in the iterator method, expression is returned, and the current location in code is retained. Execution is restarted from 
            //that location the next time that the iterator function is called. //
            //The return type must be IEnumerable, IEnumerable<T>, IEnumerator, or IEnumerator<T>.


        public void StatefulIterationRun()
        {
            StatefulIteration();

        }



        static IEnumerable<char> GetAToZ() // it is gonna return an IEnumerable
        {
            char ch = 'A'; // whe yield return executed "ch" will have the value of the last interation
            for (int i=0; i<26; ++i)
            {
                yield return ((char)(ch+1));
            }

        }
        public void StatefulIteration()
        {
            foreach (char ch in GetAToZ())
                Console.WriteLine(ch+" ");
            

            //Console.ReadLine();

        }


    }


}

