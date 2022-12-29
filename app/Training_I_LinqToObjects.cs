// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Anounymous Types Training. 

namespace TrainingStuffI
{

    public class ProgramI
    {


        public static void MainProcess ()
        {
            Console.WriteLine(" !!I AM THE PROGRAM I - Training of LinqToObject!! ");   

            // LINQ for Objects allows us to create queries on data sequences of type IEnumerable or IEnumerable <T> without the need 
            // to use intermediaries (Provider of the UN, or an API) to translate the query into another language. 
            // In this case, collections of objects are in memory.
  
            /*
            Thus:

            - We can work with data data using a declarative language instead of imperative, and we make the code more readable.
            - We do not have to worry about writing efficient algorithms for known operations that are already in the API.
                For example, we do not have to develop an efficient algorithm to look for an element in the collection.
                BEWARE: that does not mean that we do not have to think about the cost of the operation that the API is doing.
            - It facilitates migrations to other data structures, because you do not need to modify all our filtering, sorting, etc. algorithms.
            The implementation of the LINQ methods for IEnumerable and IEnumerable <T> does not depend on the collection that implements said interface, but belongs to the own interface.

            Internally, LINQ for objects is implemented as a serie of extension methods for the IEnumerable interface.
            */

            // System.Linq namespace provides several classes, enumerations and interfaces which admit queries that use Language-Integrated Query (LINQ).
            /*
            - Classes
                -See: https://docs.microsoft.com/en-us/dotnet/api/system.linq?view=net-5.0#classes
            - Interfaces
                See: https://docs.microsoft.com/en-us/dotnet/api/system.linq?view=net-5.0#interfaces
            - Enums
                See: https://docs.microsoft.com/en-us/dotnet/api/system.linq?view=net-5.0#enums         
            
            */
        }


        // Our data bases:
         static List<int> ListToTest = new List<int> {12,2,33,4,5,6,34,23,10,21};   
         static int [] ArrayToTest = new int[] {1,2,3,14,53,6,7,80,9,10};

        // OPERATORS
        // ** FILTERS ** //
        // *WHERE FILTER* --> filters the data for one or more conditions and returns an IEnumerable<T>, where T is the type of the original collection.
        static public void Execute_Where_OnList()
        {
            Func <int, bool> lambdaFIlter = n => n<10;
            IEnumerable<int> res = ListToTest.Where(lambdaFIlter); // what we introduce is a lamda expression that gets as input an int and returns a boolean; ,
            // posible already to write: IEnumerable <int> res = numbers.Where(n => n <10);

            foreach (int element in res)
                Console.WriteLine(element);
        }

        static public void Execute_Where_OnArray()
        {
            Func <int, bool> lambdaFIlter = n => n<10;
            IEnumerable<int> res = ArrayToTest.Where(lambdaFIlter); // what we introduce is a lamda expression that gets as input an int and returns a boolean; ,
            // posible already to write: IEnumerable <int> res = numbers.Where(n => n <10);

            foreach (int element in res)
                Console.WriteLine(element);
        }


        // *FIRST FILTER* --> finds and returns the first element (NOT AN  IEnumerable<T> (ITERATOR) - DIRECTLY THE ELEMENT) of the sequence that meets the indicated condition. Throws an exception (InvalidOperationException) when the item is not found..
        static public void Execute_First_OnList(int lessThan)
        {
            int res = ListToTest.First(n => n<lessThan); // what we introduce is a lamda expression that gets as input an int and returns a boolean; ,

            Console.WriteLine(res);
        }

        static public void Execute_First_OnArray(int lessThan)
        {
            int res = ArrayToTest.First(n => n<lessThan); // what we introduce is a lamda expression that gets as input an int and returns a boolean; ,

            Console.WriteLine(res);
        }



        // *LAST FILTER* --> finds and returns the last item in the collection that satisfies the indicated condition. If it can not find it, throws an exception (InvalidOperationException).
        static public void Execute_Last_OnList(int lessThan)
        {
            int res = ListToTest.Last(n => n<lessThan); // what we introduce is a lamda expression that gets as input an int and returns a boolean; ,

            Console.WriteLine(res);
        }

        static public void Execute_Last_OnArray(int lessThan)
        {
            int res = ArrayToTest.Last(n => n<lessThan); // what we introduce is a lamda expression that gets as input an int and returns a boolean; ,

            Console.WriteLine(res);
        }




        // *SINGLE FILTER* --> searchs for an item that meets the indicated condition and verifies that it is unique in the collection. Throws an exception otherwise (InvalidOperationException).
        // Miramos que haya SOLO un numeros entre Min y Max
        static public void Execute_Single_OnList(int numMin, int numMax)
        {
            int res = ListToTest.Single(n => n<numMax && n>numMin); 

            Console.WriteLine(res);
        }

        static public void Execute_Single_OnArray(int numMin, int numMax)
        {
            int res = ArrayToTest.Single(n => n<numMax && n>numMin); 

            Console.WriteLine(res);
        }


       // *ElementAt FILTER* --> returns the element of the sequence with the index that we indicate.
       // If the index it receives is outside the range of the collection, throws an exception (ArgumentOutOfRangeException).
        static public void Execute_ElementAt_OnList(int ind)
        {
            int res = ListToTest.ElementAt(ind); 

            Console.WriteLine(res);
        }

        static public void Execute_ElementAt_OnArray(int ind)
        {
            int res = ArrayToTest.ElementAt(ind); 

            Console.WriteLine(res);
        }

        /*
            FirstOrDefault( ), LastOrDefault( ), SingleOrDefault( ), ElementAtOrDefault( ): if the element is not found in the input sequence, 
            they return the default object for the collection base-type instead of throwing an exception.
            If a collection contains objects of a reference type, the default object is usually null, 
            but be aware that this is not true for non-referenced types (int, for example, may return 0).
            These alternative functions are useful when not finding the element in the collection is not an erroneous application state. 
            That is, we do not need to rise and handle an exception because not finding the element in the collection is one of the allowed results of our query.
        */


        // ** QUANTIFYERS ** //
        // Indicate if any or all the elements of a sequence meet the conditions indicated in the predicate. The quantifier methods return true or false.
        
        // *ANY QUANTIFYER* 
        // Any( ): checks if any of the elements of the sequence meets the indicated condition. --> returns bool
        static public void Execute_Any_OnList(int Maximum)
        {
            bool res = ListToTest.Any(n => n <Maximum); 

            Console.WriteLine(res);
        }

        static public void Execute_Any_OnArray(int Maximum)
        {
            bool res = ArrayToTest.Any(n => n <Maximum); 

            Console.WriteLine(res);
        }


        // *ALL QUANTIFYER* 
        // All( ): checks if all elements of the sequence meet the indicated condition.
        static public void Execute_All_OnList(int num)
        {
            bool res = ListToTest.All(n => n <num); 

            Console.WriteLine(res);
        }

        static public void Execute_All_OnArray(int num)
        {
            bool res = ArrayToTest.All(n => n <num); 

            Console.WriteLine(res);
        }



        // *CONTAINS QUANTIFYER* 
        // Contains( ): indicates if the sequence contains the indicated element, one or more times.

        static public void Execute_Contains_OnList(int num)
        {
            bool res = ListToTest.Contains(num); 

            Console.WriteLine(res);
        }

        static public void Execute_Contains_OnArray(int num)
        {
            bool res = ArrayToTest.Contains(num); 

            Console.WriteLine(res);
        }

        // ** QUANTIFYERS ** //
        // To order a list of data, its elements must implement IComparable. This interface provides us a method for comparing two objects of a specific type.
        // Be aware that Sort() is not, technically speaking, a real LinQ method, but a very specific method of the List<T> class 
        // (not available in other generic collections).
        
        // *ORDER BY* 
        // Sorts the elements of a sequence in ascending order. --> returns -> IEnumerable<T>
        static public void Execute_OrderBy_OnList()
        {
            IEnumerable<int> res = ListToTest.OrderBy(n=>n);  // just orer by the number itself

            foreach (int element in res)
                Console.WriteLine(element);
        }

        /**/
        static public void Execute_OrderBy_OnArray()
        {
            IEnumerable<int> res = ArrayToTest.OrderBy(n=>n);  // just orer by the number itself


            foreach (int element in res)
                Console.WriteLine(element);

        }

        // *REVERSE* 
        // Turns the elements of a sequence. --> returns -> IEnumerable<T>
        static public void Execute_Reverse_OnList()
        {
            ListToTest.Reverse();  // works directly on the list trasformit the list

            foreach (int element in ListToTest)
                Console.WriteLine(element);
        }

        /**/
        static public void Execute_Reverse_OnArray()
        {
            IEnumerable<int> res = ArrayToTest.Reverse();  // just orer by the number itself


            foreach (int element in res)
                Console.WriteLine(element);

        }

        static string[] fruits = new string[] { "grape", "passionfruit", "banana", "mango", "orange", "raspberry", "apple", "blueberry" };

        // *THEN_BY* 
        // ThenBy( ) -> Ascending sort secondary operation. (Done AFTER aN OrderBy!!) returns -> IEnumerable<T>
        // The following functions orders a sequence of elements first by its string's lenght and after it in an alphabetical manner
        static public void Execute_ThenBy_OnArray()
        {
            IEnumerable<string> res = fruits.OrderBy(n=>n.Length).ThenBy(n=>n);  

            foreach (string element in res)
                Console.WriteLine(element);
        }


        // *THEN_BY_DESCENDING* 
        // ThenBy( ) -> Descending sort secondary operation. (Done AFTER aN OrderBy!!) returns -> IEnumerable<T>
        // The following functions orders a sequence of elements first by its string's lenght and after it in an DESCENDENT alphabetical manner
        static public void Execute_ThenByDescending_OnArray()
        {
            IEnumerable<string> res = fruits.OrderBy(n=>n.Length).ThenByDescending(n=>n);  

            foreach (string element in res)
                Console.WriteLine(element);
        }

        // ** GROUPING ** //
        // *GROUP_BY* 
        // GroupBy( ) --> Group the elements that meet the conditions indicated in the predicate of the clause. --> IEnumerable<IGrouping<TKey, TElement>>
        static IList <StudentStuff.Student> allStudents = new List <StudentStuff.Student>
        {
            new StudentStuff.Student ("Svetlana", "Omhlenko", 10),
            new StudentStuff.Student ("Claire", "O'Donnell", 6),
            new StudentStuff.Student ("Sven", "Mortensen", 3),
            new StudentStuff.Student ("Cesar","Garcia", 6),
            new StudentStuff.Student ("Debra", "Garcia", 10),
            new StudentStuff.Student ("Monica", "Garcia", 10),
            new StudentStuff.Student ("Yessica", "Omhlenko", 10),
            new StudentStuff.Student ("Federica","Mortensen", 3),

        };

        /*
        - GroupBy receives an expression that contains the element or elements for which we are going to group => key (key).
        - After the GroupBy we can concatenate other LINQ methods (projection, filter ...).
        
        What is the result? => An IEnumerable <IGrouping <TKey, TElement >>
            -IGrouping: is a structure that we use to store a collection of objects that share the key (list dictionary).
            -TKey: is the type of the key. In the previous example, the key is Score (of type int). --> criteria we use to create the groups
            -TElement: is the type of objects that share the key. In the example, Student. --> what there is inside the same group
        */
        
        static public void Execute_GroupBy_OnList()
        {
            // we create grpup pf student regardind the criteria of s.Score ( Students that have the same score )
            IEnumerable<IGrouping <int, StudentStuff.Student >> res = allStudents.GroupBy(s=>s.Score);  

            // To iterate over the results it returns, we can use a foreach nested inside another foreach:

            // first we iterate for each created group 
            foreach (IGrouping <int, StudentStuff.Student> group_of_students in res)
            {
                Console.WriteLine ("\n\nNEXT the group of students with a score of: {0}", group_of_students.Key);              

                // second we iterate among all the students of each created group 
                foreach (var student in group_of_students)
                {
                   student.PrintDataStudent();
                }
            }
        }

        static public void Execute_GroupBy2Criterias_OnList()
        {
            // We can also group by more than one characteristic by creating an anonymous object to make the comparison:
            // we create grpup pf student regardind the criteria of s.Score ( Students that have the same score ) and the same s.Surname 
            var res = allStudents.GroupBy(s => new {s.Surname, s.Score});  

            // To iterate over the results it returns, we can use a foreach nested inside another foreach:

            // first we iterate for each created group 
            foreach (var group_of_students in res)
            {
                Console.WriteLine ("\n\nNEXT the group of students with a score of {0} and the Surname {1}", group_of_students.Key.Score, group_of_students.Key.Surname);              

                // second we iterate among all the students of each created group 
                foreach (var student in group_of_students)
                {
                   student.PrintDataStudent();
                }
            }
        }


        // ** QUANTIFYERS ** //

        static int [] IntArrayToTest = new int[] {1,2,3,14,53,6,7,80,9,10};
        static double [] DoubleArrayToTest = new double[] {1.322,0.2,3.6,14.7,5322243,0.006,7,80,9.5,10.122,23.2};

        // *Average()* -> Average of the numerical values of the sequence.
        static public void Execute_Average_OnIntArray()
        {
            double res = IntArrayToTest.Average(); 

            Console.WriteLine(res);
        }

        static public void Execute_Average_OnDoubleArray()
        {
            double res = DoubleArrayToTest.Average(); 

            Console.WriteLine(res);
        }


        // *Count()* -> Number of elements in a sequence.
        static public void Execute_Count_OnIntArray()
        {
            int res = IntArrayToTest.Count(); 

            Console.WriteLine(res);
        }

        static public void Execute_Count_OnDoubleArray()
        {
            int res = DoubleArrayToTest.Count(); 

            Console.WriteLine(res);
        }

        // *Max()* -> Maximum value in a sequence.
        static public void Execute_Max_OnIntArray()
        {
            int res = IntArrayToTest.Max(); 

            Console.WriteLine(res);
        }
        // *Min()* -> Minimum value in a sequence.
        static public void Execute_Min_OnDoubleArray()
        {
            double res = DoubleArrayToTest.Min(); 

            Console.WriteLine(res);
        }

        // *Sum()* -> Sum of the elements of the sequence.
        static public void Execute_Sum_OnStudents()
        {
            int res = allStudents.Sum(s=> s.Score); 

            Console.WriteLine(res);
        }

        // ** OPERATIONS IN SET ** //
        // To check if two elements of a sequence are the same, the LINQ methods require that these objects implement the IEquatable interface.
        // By default, Object.Equals( ) compares object references to determine equality, but we may want to do so by the values of some of its properties.

        static int [] IntArrayToTest2 = new int[] {1,211,2,3,14,53,6,6,6,6,6,7,80,80,9,9,9,10};
        static int [] IntArrayToTest3 = new int[] {1,7,2,3,8,90,6,6,6,6,6,7,80,80,9,9,9,10};


        // *Distinct( )* -> Removes duplicate values from a collection.
        static public void Execute_Distinc_OnInt()
        {
            IEnumerable<int> res = IntArrayToTest2.Distinct(); 

            foreach (int number in res)
                Console.WriteLine(number);
        }

        
        // *Except( )* -> Returns the elements of a collection that do not appear in the other.
        // CollectionA.Except(CollectionB);
        // it returns elements of CollectionA that dont appear in CollectionB  as a form of a IEnumerable<T> ( another Collection)
        static public void Execute_Except_OnInt()
        {
            IEnumerable<int> res = IntArrayToTest2.Except(IntArrayToTest3); 

            foreach (int number in res)
                Console.WriteLine(number);
        }

        // *Intersect( )* -> Returns the elements that appear in the two collections (!!without duplicates!!)
        // CollectionA.Intersect(CollectionB);
        // it returns elements of CollectionA that appear in CollectionB as a form of a IEnumerable<T> ( another Collection)
        static public void Execute_Intersect_OnInt()
        {
            IEnumerable<int> res = IntArrayToTest2.Intersect(IntArrayToTest3); 

            foreach (int number in res)
                Console.WriteLine(number);
        }

        // *Union( )* -> Returns the unique elements that appear in either of the two collections.(!!without duplicates!!)
        // CollectionA.Intersect(CollectionB);
        // it returns elements of CollectionA and elements in CollectionB as a form of a IEnumerable<T>  without duplications ( another Collection)
        static public void Execute_Union_OnInt()
        {
            IEnumerable<int> res = IntArrayToTest2.Union(IntArrayToTest3); 

            foreach (int number in res)
                Console.WriteLine(number);
        }

        // ** PROYECTION** //
        /*
        Projection operators allow us to modify the elements of a collection, 
        transforming the original elements into new objects (known or anonymous) that contain the information we want.
        Thus, for example, we can perform different operations using LINQ on our collections and then use the projection 
        to select only the most representative properties of the result we have obtained.
        */
        static int [] IntArrayToTest4 = new int[] {1,2,3,4,5};

        // *SELECT*
        // When a collection of objects is returned, the Select ( ) method allows us to transform the result of a query 
        //so that it has the format we want.
        static public void Execute_Select_IntArrayx2()
        {
            IEnumerable<int> res = IntArrayToTest4.Select(n=>n*2); 

            foreach (int number in res)
                Console.WriteLine(number);
        }


    }
}

