// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Anounymous Types Training. 

namespace TrainingStuffF{

    public class ProgramF
    {    
        public static void MainProcess ()
        {
            Console.WriteLine(" !!I AM THE PROGRAM F - Training of Lamdbda Expresions!! ");   
         
            // Lambda expression -> block of code ( an expression of block of intructions ) that is treated as an object
            // (input parameters) => {statements;} 
            // "=>" means "Goes to"
            // Remeber "Func" is a standard Delegeta that defines a signature of inputs ( first parameter/s) and output (last parameter)
            Func<int, int, bool> testEquality = (x,y) => x==y;
            // First part of the expression:  means that we create a delegate with name "testEquality" that defines a type of Signature that takes 2 int as input and returns a boolean as output  
            // Second part of the expression: means that we point this delegate to a lambda expression (of course with the same signature of the aforementioned delegate) defined by two inputs and an expression 

            // lambda expressin can refer to external variables that are in the scope of the method and type
            int n = 1;
            Func <int> increment = () => n++; 
            // First part of the expression:  means that we create a delegate with name "increment" that defines a type of Signature that takes nothing as input and returns a int as output  
            // Second part of the expression: means that we point this delegate to a lambda expression (of course with the same signature of the aforementioned delegate) defined by 0 inputs and an expression using an int from the scope

            ExecuteIncrement(34,increment);

            /*
            A lambda expression:
                It is an anonymous function.
                It can be passed as an argument, 
                It can be returned and it can be assigned to delegates, Func<> and Action<>.
                LINQ queries.
            */

            // Types of Lambda expressions:
            // Expression --> a single expression that may or may not return a value. When it returns a value, it does NOT use return.
            Func <int, bool> isEven = x => x% 2 == 0; // gets as an input an int (x) and returns as output a boolean
            // Statement --> one or several expressions separated by ";" and between braces, that is, a code block. If you return a value, you have to use a return.
            Func <int, bool> isEven2 = x => { return x%2 == 0; }; // ?¿?¿?¿ more complex ?¿?¿?

            // In LINQ:
            // IEnumerable <TSource> Where <TSource> (IEnumerable <TSource>, Func <TSource, bool>);
            // IEnumerable <TSource>: is the collection on which we invoke our expression, and Tsource the type of that collection. It is also the type that we return.
            // Func <TSource, bool>: is the function or method that defines what we want to do with each of the elements of the collection. It must return a boolean.


            // YOUTUBE TUTORIAL Lambdas -> https://www.youtube.com/watch?v=UuCe9uwNAqQ
            // representacion con al palabra reservada Func
            // usando funcion anonima --> proceso interno que no se le asocia ningun nombre --> "a*2" 
            Func<int, int> b = (a) => a * 2;
            int resultado = b (2);
            Console.WriteLine($"Result lambda expression is: {resultado}");

            Func<int, int, int> suma = (a, b) => a + b;
            resultado = suma (56,78);
            Console.WriteLine($"Result lambda expression is: {resultado}");

            // si necesitmaos más funcionalidad tendremos que definir una sentencia Lambda --> Stamements splitted by ";"
            Func<int, int, int> mayorQue = (a, b) => 
            {
                if (a > b) return a;
                else return b;

            };
            resultado = mayorQue(4444,2);
            Console.WriteLine($"Result lambda expression with Logic is: {resultado}");


            // Usos más complejos --> FILTRADO
            var numbers = new List<int> {3,4,5,6,7,8,2,31};
            // use of Linq functions
            // I just want even numbers
            // function to do the filterin
            Func<int, bool> isEven3 = (number) => number%2 ==0;

            // use of Linq methode --> where -> function to filter given an anonymous function that checks a condition
            var pairs = numbers.Where(isEven3);
            // another way to define the Linq methode --> introduce just the expression
            var pairs2 = numbers.Where((number) => number%2 ==0); // we work on every element of the collection

            // lambda function that gets another lambda expression
            // use of the reserved word "Action" --> which defines a delegate which signature has no output
            Action<int> print = (number) => Console.WriteLine(number);
            print (5);
            // defined a lambda expresion that takes another one
            Action<List<int>> showNumbersList = (numbers) =>
            {
                foreach (var number in numbers) // numebrs is defined outside the scode!! IT CAN WORK WITH VARIABLES DEFINED OUTSIDE THE EXPRESSION!!!!!
                    print(number); // we are callint the other lambda expression already defined. 
            };
            showNumbersList(numbers); 

            // example of "Func" inside a "Func" ( as an input has an int and a "Func" function which at the same time gets an "int" and returns an "int")
            Func< int, Func<int, int>, int> frHigherOrder = (number, fn) =>
            {
                if (number > 100)
                    return fn(number);
                else    
                    return number;

            };

            var res = frHigherOrder(600, (n)=> n*n);
            print(res);

        }

        static void ExecuteIncrement(int Offset, Func<int> IntDelegate)
        {
            Console.WriteLine($"Offeset: {Offset}");
            int result = IntDelegate() +Offset;
            Console.WriteLine($"Result is: {result}");

        }

       
    }
}

