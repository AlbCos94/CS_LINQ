// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Anounymous Types Training. 

namespace TrainingStuffG{

    public class ProgramG
    {    
        public static void MainProcess ()
        {
            Console.WriteLine(" !!I AM THE PROGRAM G - Training of Query Operation!! ");   
            
            // With LINQ: all sources (ADO, BD, XML, Collections, FileShare) s BadImageFormatException ) share a syntax.

                // Syntax similar to C #: familiar.    
                // Everything is typed and shares the type of data (more or less).
                // Take advantage of C # features: use of lambda expressions, use of var, etc.
            
            // Notation
            // LINQ counts on two different ways of working, Query and Method Syntax. 
            // Compiler converts Query Syntax into Method Syntax in compilation time.

            // DataSet definition
            int [] numbers = {0, 30, 20, 15, 90, 85, 40, 75};

            // METHOD syntax
            var res = numbers.Where(n => n<30); // "Where" seems to be a lambda expresion that gets an element of a collection an returns a boolean regarding if that element has passed a filter condition of not ( if not, that element is dismissed)

            Action<int> print = (number) => Console.WriteLine(number);

            Action<int[]> printAllNumbers = (numbersToBePrint) =>
            {
                foreach (var number in numbersToBePrint)
                    print(number);

            } ;

            Action<IEnumerable<int>> printAllNumbers2 = (numbersToBePrint) =>
            {
                foreach (var number in numbersToBePrint)
                    Console.WriteLine(number);

            } ;
            printAllNumbers(numbers);
            print(77777777);
            printAllNumbers2(res);

            // QUERY syntax
            var res2 = from n in numbers
                where n <30
                select n;            

            print(7777777);
            printAllNumbers2(res);

            // Comparison Method VS Query Syntax
            //  There are no differences in performance between one and the other.
            //  Microsoft considers the query syntax to be more readable.
            //  Method syntax supports more functions than queries.




        }
    }
}

