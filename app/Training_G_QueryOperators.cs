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

            // Languaje INtegrated Query -> LINQ -> API LINQ
            // -> Lenguaje de consulta integrado en C# y VB.NET (paltaforma)
            // -> Usage -> para guardar y consultar datos de diferentes origenes ( e.g. Acceder a datos de: Base de Dataps SQL, informacion almacenada en objectos,
            // , en ficheros XML, en Recordset, en Entidades,...)
            // Permite uniformidad en lenguajes de consulta, reduccion de codigo, mas legible, perfecta integracion en C#

            // The standard query operators are the methods that make up the Language-Integrated Query (LINQ) model

            // API LINQ -> formada por dos clases que proporcionan los métodos para acceder a todos estos datos. 
            // In order to use LINQ over a sequence, it must implement one of these two interfaces:
                // Enumerable -> IEnumerable (interface) -> https://learn.microsoft.com/es-es/dotnet/api/system.collections.ienumerable?view=net-7.0
                    // Expone un enumerador, que admite una iteración simple en una colección no genérica.
                // Queryable -> IQueryable  (interface) -> https://learn.microsoft.com/es-es/dotnet/api/system.linq.iqueryable?view=net-7.0 
                    // Proporciona características para evaluar consultas con respecto a un origen de datos concreto en el que 
                    // el tipo de datos no está especificado.

        }


        /********************************************************************************************************************************/

        // In order to use LINQ, the data sequence must be strongly typed (generic), because LINQ needs 
        // to know the type of the sequence object in order to perform the operations that define its methods.

        // Methods to Convert to a generic collection 
            // Cast<TResult>
                // It receives a non-generic collection and transforms it into a generic collection of type <TResult>, 
                // assuming that all its elements can be converted to TResult. --> ALL are transformed

            // OfType< TResult >
                // It receives a non-generic collection and returns a generic collection of type <TResult> 
                // that contains all the objects in the original collection that can be converted to TResult. --> Just the ones that can be transformed are transformed
        public static void ConvertExample ()
        {

            ArrayList times = new ArrayList ();
            times.Add (243.53d);
            times.Add (125.32d);
            times.Add (104.23d);


            // We want to calculate the average of the execution time, so we can use the Average( ) aggregation method.
            // To do this, we need to first convert the list, IEnumerable, to its generic version, IEnumerable<double>, 
            // so that the method knows the type of the elements of the sequence and can calculate its average:

            double avg = times.Cast<double>().Average(); 

            Console.Write("The average time is: {0}", avg); 


        }

    }
}

