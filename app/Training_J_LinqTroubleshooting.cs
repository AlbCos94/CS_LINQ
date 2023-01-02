// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;


// namespaces from my own classes;
 using StudentStuff;

// Anounymous Types Training. 

namespace TrainingStuffJ
{

    public class ProgramJ
    {

        public static void MainProcess ()
        {
            Console.WriteLine(" !!I AM THE PROGRAM J - Training of LINQ Trouble Shooting!! ");   
    
        
        }
        

        static IList <Student> allStudents = new List <Student>
        {
            new Student ("Svetlana", "Omhlenko", 10, 1, 2, 3, "Maths"),
            new Student ("Claire", "O'Donnell", 6, 4, 5, 6, "Science"),
            new Student ("Sven", "Mortensen", 3, 7, 8, 9, "Chemistry"),
            new Student ("Cesar","Garcia", 6, 5, 3, 9, "Maths"),
            new Student ("Debra", "Garcia", 10, 5, 3, 9, "Science"),
            new Student ("Monica", "Garcia", 10, 5, 3, 9, "Maths"),
            new Student ("Yessica", "Omhlenko", 10, 5, 3, 9, "Physics"),
            new Student ("Federica","Mortensen", 3, 5, 3, 9, "Chemistry"),
        };

        public static void TryGetCollectionStudents_usingWhere_ConditionNotFound ()
        {

            IEnumerable<Student> CollectionOfStudents = allStudents.Where(s => s.Score > 11).Select(s=>s);

            // Where( ) returns an empty sequence, because no student meets the indicated condition. 
            // Select on an empty sequence also returns an empty sequence.

        
        }


        public static void TryGetStudents_usingFirst_ConditionNotFound ()
        {

            Student CollectionOfStudents = allStudents.First(s => s.Score > 11);

            // First( ) does not find any student that meets the indicated conditions, so an exception (InvalidOperationException) is thrown !! :-/
            /*
            Unhandled exception. System.InvalidOperationException: Sequence contains no matching element
                at System.Linq.ThrowHelper.ThrowNoMatchException()
                at System.Linq.Enumerable.First[TSource](IEnumerable`1 source, Func`2 predicate)
                at TrainingStuffJ.ProgramJ.TryGetStudents_usingFirst_ConditionNotFound() in D:\Archivos\Albert\MAP_Sistemas_etc\LINQ_Training\LINQ_test_project\app\Training_J_LinqTroubleshooting.cs:line 54
                at Program.<Main>$(String[] args) in D:\Archivos\Albert\MAP_Sistemas_etc\LINQ_Training\LINQ_test_project\app\main.cs:line 232 
            */

        
        }

        public static void TryGetStudents_usingFirstOrDefault_ConditionNotFound ()
        {

            var CollectionOfStudents = allStudents.FirstOrDefault(s => s.Score > 11);

            // FirstOrDefault( ) does not find any student that meets the indicated conditions, so it returns a null. 
            // If we try to access a property of a null value, a NullReferenceException will be thrown. --> better than throwing an Exception :-)

       
        }


        // How do we treat invalid states?

        /*
        Not all invalid states are unexpected. As a rule, 
        we should not throw an exception when we are dealing with predictable cases that do not mean an unrecoverable state of the system. 
        Managing an exception (try - catch) has an extra cost with respect to managing, for example, a check with an if. !!

        !!!!! This means that, when we can expect a sequence to be empty, we will prefer to use methods that return a null 
        (for example, FirstOrDefault( )) before methods that throw an exception (such as First( )). !!!!!

        */

        // Past Examples well implemented
        public static void TryGetStudents_usingFirst_ConditionNotFound_GoodImplementation ()
        {
            // First( ) does not find any student that meets the indicated conditions, so an exception (InvalidOperationException) is thrown !! :-/
            /*
            Unhandled exception. System.InvalidOperationException: Sequence contains no matching element
                at System.Linq.ThrowHelper.ThrowNoMatchException()
                at System.Linq.Enumerable.First[TSource](IEnumerable`1 source, Func`2 predicate)
                at TrainingStuffJ.ProgramJ.TryGetStudents_usingFirst_ConditionNotFound() in D:\Archivos\Albert\MAP_Sistemas_etc\LINQ_Training\LINQ_test_project\app\Training_J_LinqTroubleshooting.cs:line 54
                at Program.<Main>$(String[] args) in D:\Archivos\Albert\MAP_Sistemas_etc\LINQ_Training\LINQ_test_project\app\main.cs:line 232 
            */
            // since First() returs an exception, we will handle it, with a try-catch block:
            try{
                Student CollectionOfStudents = allStudents.First(s => s.Score > 11);
                Console.WriteLine("We found a Student with the introduced conditions!!");
            }
            catch (Exception)
            {
                Console.WriteLine("We DIDNT FIND A STUDENT with the introduced conditions!!");
            }
        
        }

        // BEST IMPLEMENTATION!!!
        public static void TryGetStudents_usingFirstOrDefault_ConditionNotFound_BestImplementation ()
        {
            // FirstOrDefault( ) does not find any student that meets the indicated conditions, so it returns a null. 
            // If we try to access a property of a null value, a NullReferenceException will be thrown. --> better than throwing an Exception :-)

            var CollectionOfStudents = allStudents.FirstOrDefault(s => s.Score > 11);
            if (CollectionOfStudents == null)
            {
                Console.WriteLine("We DIDNT FIND A STUDENT with the introduced conditions!!");
            }
            else{
                Console.WriteLine("We found a Student with the introduced conditions!!");
            }


       
        }
    }
}

