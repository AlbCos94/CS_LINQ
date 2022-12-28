// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Anounymous Types Training. 

namespace TrainingStuffE{

    public class ProgramE
    {    


        public void MainProcess ()
        {
            Console.WriteLine(" !!I AM THE PROGRAM E - Training of Delegates !! ");   
         
        }
       

        // DELEGATES
        // A Delegate is a type that securely encapsulates a method, similar to a function pointer in C or C++
        // The type of a delegate is defined by the name of the delegate
        // Definition of a delegate: [type method] [return value] [name of the delegate] [parameters it takes]
        public delegate void Del (string message);

        // Creation of a method to represent the type:
        public static void DelegateMethod (string message)
        {
            System.Console.WriteLine (message);
        }
        
        /*********************/

        // What are they used for?
            // They are the basis of the events.
            // Callbacks.
            // In general, they allow us to define the type of method we expect in order to execute it later.

        /*********************/

        // Step by step example:
        // Delegate Definition:
        public delegate int Operation (int a, int b);
        // Where:
        //  public: key modifier
        //  delegate: key word to define a delegate
        //  int: is the kind of return - what it does return
        //  Operation: is the name of the delegate
        //  int a / int b: are the input parameters 

        /*********************/

        // Methods definition
        // we are going to define three different methods for executing different operations: sum, subtraction and multiplication.
        // three of them will be static, so we will not need to instantiate the class to use them. just use them through the Type
        // methods need to have the same: "key modifier", "kind of return" and "input parameters"

        public static int Sum(int a, int b)
        {
            Console.WriteLine("Executing a sum");
            return a+b;
        }

        public static int Sub(int r, int t)
        {
            Console.WriteLine("Executing a subtraction");
            return r-t;
        }

        public static int Mul(int x, int y)
        {
            Console.WriteLine("Executing a multiplication");
            return x*y;
        }

        // Finally, in the main method of our code (static and can be called from the type), we create the instances of the delegates we want. 
        // Use of the operator "new" and the name of the delegate
        // As input parameter we indicate the name of the method

        public static void Main()
        {
            //INSTANTIATION
            Operation sumOperation = new Operation(Sum);
            Operation subOperation = new Operation(Sub);
            Operation mulOperation = new Operation(Mul);

            // EXECUTION
            int sumResult = sumOperation(4,5);
            int subResult = subOperation(8,3);
            int mulResult = mulOperation(7,2);

            //PRINTING THE RESULT
            Console.WriteLine("Result of the sum: "+ sumResult);
            Console.WriteLine("Result of the subtraction: "+ subResult);
            Console.WriteLine("Result of the multiplication: "+ mulResult);


        }

        // GENERIC DELEGATES
        // Several predefined delegates allow us to create delegates without including all information 
        // such as parameters, types, kind of return...

        // Predicate: it is used in methods which filter collections.

        // Action: it is a predefined delegate which help us to define actions -> methods without return (void). We can specify only parameters needed as entrance.
        // Action<double> // same as "delegate void PrintResult (double num)"
        
        // Func: it is similar to action, but differing in we must indicate the kind of return.
        // Func is a mold which helps us to create delegates without all the requirements of delegates definition each time we need one. 
        // Func uses generic methods to indicate input parameters and the kind of return of the delegate. 
        // Data must be included in the order indicated, therefore, LAST PARAMETER INCLUDED WILL BE THE KIND OF RETURN. 
        /* 
        Func <int, int, int> // same as: delegate int Operation (int numA, int numB) --> returns an int
        Func <char> // same as: delegate char MyWord() --> returns just a char character
        Func <char, int, string, double, float> // same as: delegate float Example (char a, int b, string c, double d)  --> reutrns a float
        */



    }


    // YOUTUBE VIDEO - Delegates - BETTER EXPAINED THAN IN EXPLANATION
    // https://www.youtube.com/watch?v=EyR2AfLkwcA
    // --> Delegates: a function is passed as a parameter
    //                : it is a type safe function pointer
    //                : placeholder for one or more methods
    //                : something that gives a name to a method signature
    //      Use for: callback functions and Event handlers

    // definition of a delegate: [public] [delegate] [signature methods it can point to] :

    public delegate void TipoStringDelegate(string text); // defined outside the class!!
    
    // in that example the Delegate is gonna point to methods with a signature that returns nothing (void) and 
    // gets as an input parameter an string 

    // We are gonna create methodes that have the same signature as our delegate:
    // (( we are gonna use the operator lambda expression: " => " which is used as a labda operator and as a separator of a name member 
    // and the implementation of the member in a body expression definition. ))  

    class ProgramE_V2
    {

        static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
        static void ToLowerCase(string text) => Console.WriteLine(text.ToLower());


        public static void Main()
        {
            
            // el "tipo" StringDelegate hara referencia a funciones con las signatura descrita en la parte superior
            TipoStringDelegate stringDelegate = ToUpperCase; // using the delegate, I have created a reference to the ToUpperCase method

            // We are gonna make pointing the Delegate to different funcions which share the same signature

            // Invoke the delegate:
            stringDelegate("hi! i am gonna be uppercasted");
            stringDelegate.Invoke("hi! i am gonna be uppercasted again");

            // como ya hemos definido que tipo tiene "stringDelegate" (TipoStringDelegate)
            // si queremos instanciar este tipo a otro tipo de funciones, solo deberemos hacer:
            stringDelegate = ToLowerCase; // sin necediad de indicar el tipo de este Delegate
            // y ejecutarlo como en el caso anterior
            stringDelegate.Invoke("HI I HAVE BEEN LOWERCASTED");
            stringDelegate("HI! I HAVE BEEN LOWERCASTED AGAIN");


            // Example Function take a Delegate as a parameter (*22)
            WriteOutput("i Am GoNnA bE cONvERTeD", stringDelegate);  // this one will be transformed to lowercase

        }

        //(*22)  Function that takes as a parameter a Delegate ( type of the Delegate was defined in the upper part (TipoStringDelegate)):
        // this "Delegate Paragemeter" means that this function will take as an input parameted a function with the signature defined by the Delegate
        // The following function can take whatever function you want that accomplished an specific signature defined by a Delegate ( output and input parameters ).
        // Such function will execute tha delegated function. 
        static void WriteOutput(string text, TipoStringDelegate stringDelegate)
        {
            Console.WriteLine($"Before: {text}");
            stringDelegate(text);

        }



    }




}

