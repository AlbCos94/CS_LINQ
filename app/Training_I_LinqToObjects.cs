// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace TrainingStuffI
{

    public class ProgramI
    {


        public static void MainProcess ()
        {
            Console.WriteLine(" !!I AM THE PROGRAM I - Training of LinqToObject!! ");   

            // LINQ To Object --> THE ONE USED WHEN ACCESS TO THE WRITTING MODEL


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


            // SUMMARY

            /*
            LINQ to objects
            Allow us to create in-memory queries over objects.
            We can work with collections without using a hard way of developing by loops.
            Building queries using:
            - Query Syntax: variables, ranges, standard query operators, …
            - Method Sintax: variables, extension methods, lambda expression, … --> THE ONE SHOWN HERE
            Queries execution:
            - Deffered execution: query is not executed when declared. It is executed when the query object is iterated over a loop.
            - Immediate execution: query is executed when it is declared.


            OPERATORS
            -Filtering Operators: restrict the result set such that it has only selected elements satisfying a particular condition.
            -Join Operators: Joining refers to an operation in which data sources with difficult to follow relationships with each 
                other in a direct way are targeted.
            -Projection Operations: Projection is an operation in which an object is transformed into an altogether new form with 
                only specific properties.
            - Sorting Operators: A sorting operation allows ordering the elements of a sequence on basis of a single or more attributes.
            - Grouping Operators: The operators put data into some groups based on a common shared attribute.
            - Conversions: The operators change the type of input objects and are used in a diverse range of applications.
            - Concatenation: Performs concatenation of two sequences and is quite similar to the Union operator in terms of 
                its operation except of the fact that this does not remove duplicates.
            - Aggregation: Performs any type of desired aggregation and allows creating custom aggregations in LINQ.
            - Quantifier Operations: These operators return a Boolean value i.e. True or False when some or all elements
                within a sequence satisfy a specific condition.
            - Partition Operations: Divide an input sequence into two separate sections without rearranging t
                he elements of the sequence and then returning one of them.
            - Generation Operations: A new sequence of values is created by generational operators.
            - Set Operations: There are four operators for the set operations, each yielding a result based on different criteria.
            - Equality: Compares two sentences (enumerable ) and determine if they are an exact match or not.
            */
        }


        static void printIntCollection(IEnumerable<int> collection)
        {
            foreach (int element in collection)
                Console.WriteLine(element);
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


        // *FIRST FILTER* --> finds and returns the first element (NOT AN  IEnumerable<T> (ITERATOR) - DIRECTLY THE ELEMENT) of the sequence that meets the indicated condition. 
        //Throws an exception (InvalidOperationException) when the item is not found..
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
            // we create group of student regarding the criteria of s.Score ( Students that have the same score )
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
        // it returns elements of CollectionA and elements in CollectionB as a form of a IEnumerable<T>  without duplications ( another Collection )
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
        // so that it has the format we want.
        static public void Execute_Select_IntArrayx2()
        {
            IEnumerable<int> res = IntArrayToTest4.Select(n=>n*2); // each element of the collection is gonna be multiplied by two

            Console.WriteLine("Original collection: ");
            printIntCollection(IntArrayToTest4);// THE ORIGINAL COLLECTION IS NOT MODIFIED!!
 
            Console.WriteLine("Collection multiplied by 2: ");
            printIntCollection(res);

        }

        // From an object collection we create an other collection of instances of a new object
        static public void Execute_Select_IntArrayToSurfacesCircunference()
        {
            var res = IntArrayToTest4.Select(r=> new {Radius = r, Surface = 2*3.14*r, Area = r*r*3.14}); // each element of the collection is gonna be transformed to an anonymopus type that has radius, surface and area
 
            Console.WriteLine("Display of a new collection object: ");
            foreach ( var element in res )
                PrintCircunferenceData(element.Radius, element.Surface, element.Area); 
        }

        static public void PrintCircunferenceData( double radius, double surface, double area )
        {
            Console.WriteLine("Circunference of radius {0}, surface {1} and area {2}", radius, surface, area);
        }


        // *SELECTMANY*
        /*
        We use it to create a single sequence from internal sequences of our objects. 
        The resulting sequence contains "n" concatenated subcollections, coming from the "n" values ​​of origin. 
        Therefore, the transformation function that we pass as a parameter to SelectMany( ) must return 
        an enumerable sequence that we can subsequently concatenate
        
        --> Select Collections that are inside an other collection (encapsulated)
        */
        static IList <StudentStuff.Student> allStudentsV3 = new List <StudentStuff.Student>
        {
            new StudentStuff.Student ("Svetlana", "Omhlenko", 10, 1, 2, 3),
            new StudentStuff.Student ("Claire", "O'Donnell", 6, 4, 5, 6),
            new StudentStuff.Student ("Sven", "Mortensen", 3, 7, 8, 9),
            new StudentStuff.Student ("Cesar","Garcia", 6, 5, 3, 9),
            new StudentStuff.Student ("Debra", "Garcia", 10, 5, 3, 9),
            new StudentStuff.Student ("Monica", "Garcia", 10, 5, 3, 9),
            new StudentStuff.Student ("Yessica", "Omhlenko", 10, 5, 3, 9),
            new StudentStuff.Student ("Federica","Mortensen", 3, 5, 3, 9),

        };

        static public void Execute_SelectMany_fromStudentsCollectionSelectScores()
        {
            IEnumerable<int> res = allStudentsV3.SelectMany(s => s.scores); // we get all the scores of all the students and join them together into a collection
 
            Console.WriteLine("Display all the scores of all the students: ");
            foreach ( int score_number in res )
                 Console.WriteLine(score_number);
        }

        // Example "SelectMany()"
        /*

        If we have to count the number of times that the letter 'g' appears in this sequence of strings we have to do:

        string[ ] first = new string[ ] {"hello", "hi", "good evening", "good day"};

        first.SelectMany(p=> p.ToCharArray( )).Where(p=>p.Equals('g')).Count( );

        */ 

        // ** PARTITION** //
        static int [] IntArrayToTest5 = new int[] {1,2,3,4,5,6,7,3,1};
        
        // *SKIP*
        /*
            Process an IEnumerable<T> and return a new IEnumerable<T> without the first "n" elements of the list, 
            with "n" being a number received as a parameter. -> It returns --> IEnumerable<T>
        */

        static public void Execute_Skip_NfirstIntSkipped(int n_skip)
        {
            IEnumerable<int> res = IntArrayToTest5.Skip(n_skip); // we skip the first n elements of a collection
            printIntCollection(res);

        }

        // *SKIP WHILE*
        /*
            Process an IEnumerable<T> by applying a filter to discard the first elements 
            of a collection that fulfill the predicate received as a parameter.

            SkipWhile( ) stops the first time it finds an element that does not meet the condition we have indicated
        */
        static public void Execute_SkipWhile_LessThan(int num)
        {
            IEnumerable<int> res = IntArrayToTest5.SkipWhile(n => n<=num); // we skip the first n elements of a collection
            printIntCollection(res);

        }

        // *TAKE*
        /*
            Process an IEnumerable<T> and return a new IEnumerable<T> with the first n elements of the list, 
            n being a number received as a parameter. -> It returns --> IEnumerable<T>
        */
        static public void Execute_Take_NfirstIntTaken(int num)
        {
            IEnumerable<int> res = IntArrayToTest5.Take(num); // we skip the first n elements of a collection
            printIntCollection(res);
        }

        // *TAKE WHILE*
        /*
            Process an IEnumerable<T> by applying a filter to return the first elements of 
            a collection that fulfill the received predicate as a parameter. -> It returns --> IEnumerable<T>
        */
        static public void Execute_TakeWhile_NfirstLowerThan(int num)
        {
            IEnumerable<int> res = IntArrayToTest5.TakeWhile(n => n<=num); // we take all the elements lower than num starting from beggining
            printIntCollection(res);
        }

        // **JOINS** //
        /*
            We use the combination clauses (Join ( ) and GroupJoin ( )) when we want to combine two collections, 
            so that we generate a result in which the elements of a collection A appear related to the elements 
            of a collection B to which a property binds common.
        */

        // *Join()*
        /*
            Combines the results of two sequences that share one or more properties.  -> It returns --> IEnumerable<T>


            var res = left.Join (
                right,
                l => l.PropertyValue,
                r => r.PropertyValue,
                (l, r) => new {l.Property1, r.Property1, ...}
            )

            Where:

                left: is the first collection (left), of type IEnumerable<L>.
                right: it is the second collection (right), of type IEnumerable<R>.
                l => exp: is the expression that selects the value of the left join.
                    - l is of type L.
                r => exp: is the expression that selects the value of the right join.
                    - r is of type R.
                (l, r) => exp: is the expression that creates the new objects (projection) from the left and right objects:
                    - l is an object of type L.
                    - r is an object of type R.

                In LINQ, the result of a combination is an IEnumerable<T>, 
                where T is the type that defines the properties of the two initial objects. 
                Usually it will be an anonymous type, but it can also be a type that we have created to represent the combined information. 
                On this sequence we can, afterwards, do other filtering operations, projection ...
        */

        static IList <StudentStuff.Student> allStudentsV4 = new List <StudentStuff.Student>
        {
            new StudentStuff.Student ("Svetlana", "Omhlenko", 10, 1, 2, 3, "Maths"),
            new StudentStuff.Student ("Claire", "O'Donnell", 6, 4, 5, 6, "Science"),
            new StudentStuff.Student ("Sven", "Mortensen", 3, 7, 8, 9, "Chemistry"),
            new StudentStuff.Student ("Cesar","Garcia", 6, 5, 3, 9, "Maths"),
            new StudentStuff.Student ("Debra", "Garcia", 10, 5, 3, 9, "Science"),
            new StudentStuff.Student ("Monica", "Garcia", 10, 5, 3, 9, "Maths"),
            new StudentStuff.Student ("Yessica", "Omhlenko", 10, 5, 3, 9, "Physics"),
            new StudentStuff.Student ("Federica","Mortensen", 3, 5, 3, 9, "Chemistry"),
        };

        static IList <CourseStuff.Course> CoursesAvailable = new List <CourseStuff.Course>
        {
            new CourseStuff.Course ("Maths", "mathematics course of fancy stuff", "Ramirez", 9),
            new CourseStuff.Course ("Science", "science course of fancy stuff", "Cuevas", 10),
            new CourseStuff.Course ("Chemistry", "Chemistry course of fancy stuff", "Begonia", 8),
            new CourseStuff.Course ("Physics", "Physics course of fancy stuff", "ElDeZaragoza", 6)
        };

        
        static public void Execute_Join_StundentsAndCourses()
        {
            var res = allStudentsV4.Join(
                CoursesAvailable,
                Collection_Students => Collection_Students.Course, // expression to join values of first collection
                Collection_Courses => Collection_Courses.Name, // expression to join values of second collection
                (Collection_Students, Collection_Courses) => new { Name_Student = Collection_Students.Name, Name_Teacher = Collection_Courses.Teacher }
                
                // We just want to know with which student goes with which teacher. 

            ); 
 
            Console.WriteLine("Display all the scores of all the students: ");
            foreach ( var Combo_Stundent_teacher in res )
                 Console.WriteLine("the student {0} is gonna be with the teacher {1}", Combo_Stundent_teacher.Name_Student, Combo_Stundent_teacher.Name_Teacher );
        }

        // *Group Join()*
        /*
        Sometimes we do not want to generate a new object for each result of the combination of the left and right collections, 
        but for each result of the left part ("l" in the example below) we want to create a collection of results on the right 
        side ("listOfR" in the example below). 
        In this way we can use a Join to generate a hierarchical data structure, where each element m of the left sequence 
        has assigned 1..n elements of the right sequence.

        All the elements of the first collection appear in the result set of a grouped combination, regardless of whether correlated elements have
        been found on the right side. 
        In the case that no correlated elements are found, the sequence of correlated elements for that element would be empty.
        */

        /*
        Next example is about students and courses and shows the result of doing a GroupJoin( ) of Course (left side) 
        and Student (right side), to obtain a list of all the students pointed to each course. Courses without students also appear in the group, 
        but their list of students is empty.
        We will check for each Course all the students

        The syntax of the query is similar to that used by the Join( ) method, 
        but it changes the selection function of the result which, on the right side, is no longer R, but IEnumerable<R>.

        var res = left.GroupJoin (
            right,
            l => l.PropertyValue,
            r => r.PropertyValue,
            (l, listOfR) => new {l.Property1, listOfR, ...} 
            )
        //--> listOfR are the elements of the second collection that share that "r => r.PropertyValue" with the elements of the first collection 

        */

        static public void Execute_GroupJoin_StundentsAndCourses()
        {
            var res = CoursesAvailable.GroupJoin ( allStudentsV4,
                Courses_collect => Courses_collect.Name, // variable from CoursesAvailable used to join
                Students_collect => Students_collect.Course,  // variable from allStudentsV4 used to join
                (Courses_collect, listOf_Students_collect) => new // for each element of the collection of Courses we will have a new anonymous Object type made out of some properties of the collection of Courses and a collection of Students that match the "joint value"
                {                                           
                    CourseName = Courses_collect.Name,
                    CourseDescript = Courses_collect.Description,
                    StudentsFromCourse =listOf_Students_collect // collection of the students of the course
                }
            );
                       
            Console.WriteLine("Display for each course all the students: ");

            foreach ( var Course_element in res)
            {
                Console.WriteLine("For the course {0} with the description --> {1} <-- we have the following students: ", Course_element.CourseName, Course_element.CourseDescript );
                var result_studentList = Course_element.StudentsFromCourse;

                foreach ( var Student_element in result_studentList)
                {
                    Student_element.PrintDataStudent();


                }    
            }

        }


    }
}

