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


        // EXAMPLE 1
        public static void StatefulIteration()
        {
            foreach (char ch in GetAToZ())
                Console.WriteLine(ch+" ");          
            //Console.ReadLine();

        }

        static IEnumerable<char> GetAToZ() // it is gonna return an IEnumerable
        {
            char ch = 'A'; // whe yield return executed "ch" will have the value of the last interation
            for (int i=0; i<26; ++i)
            {
                ch++;
                yield return (char)(ch);
            }

        }

        // STATIC METHODS 
        // A static method in C# is a method that keeps only one copy of the method at the Type level, not the object level. 
        // That means, all instances of the class share the same copy of the method and its data. The last updated value of the method is shared among all objects of that Type. 
        // Static methods are called by using the class name, not the instance of the class. 
        // The Console class and its Read and Write methods are an example of static methods. The following code example calls Console.WriteLine and Console.
        // ReadKey methods without creating an instance of the Console class. --> https://www.c-sharpcorner.com/UploadFile/abhikumarvatsa/static-methods-in-C-Sharp/

        // --> No se puede acceder al miembro estático 'SecondMain' con una referencia de instancia; califíquelo con un nombre de tipo en su lugar.
        // --> Este miembro al ser estatic se deberá llamar a través de su tipo y no creando una instancia (un Objeto) de tal tipo !!!!
        // --> ver main.cs (*11) para ver como se ha llamado dicho método
        
        // EXAMPLE 2
        public static void SecondMain() 
        {
            FillValues();
            foreach (int i in RunningTotal())
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }

        static IEnumerable<int> RunningTotal()
        {
            int runningTotal = 0;
            foreach (int i in MyListOfInt)
            {
                runningTotal += i;
                yield return (runningTotal);
            }
        }
    }
}

