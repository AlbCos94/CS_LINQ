// To avoid using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// to create xml trees
using System.Xml.Linq; 



// Anounymous Types Training. 

namespace TrainingStuffL
{

    public class ProgramL
    {

        public static void MainProcess ()
        {
            Console.WriteLine(" !!I AM THE PROGRAM L - Training of Algorithm and Complexity!! ");   
            
            /*
            When we address the requirements of a solution we can differentiate between:

            Functional: what the system has to do.
                Issue stock picking, etc.
            Non-functional: other restrictions that the software must comply with.
                Security.
                Accessibility.
                Performance.

            In the case of performance, that one solution is more efficient than another, or that it improves the performance of the application, depends on what we are measuring. We talk about things like:
                - Scalability.
                - Resource occupation.
                - Time to complete the tasks.

            How do we measure performance?
                - Measuring directly (stopwatch, memory monitor, etc.)? Sometimes it is a good option, 
                    but it is a value dependent on the system on which we test (hardware, compiler, operating system,
                    punctual status of the equipment, etc.).
                - Counting the operations we execute? It allows us independence of the hardware, 
                    the operation and the state of the machine.


            *Big O notation*
            Represents the complexity of an algorithm (asymptotic complexity) based on the number of items we want to measure. 
            In the case of temporal complexity, we want to measure instructions.
            "Temporal complexity is the function T(n) that measures the number of instructions 
            made by the algorithm to process a problem of size n."

            In many algorithms, the number of instructions depends on the input of the problem and not just on its size. 
            When this happens, we say that we find a better scenario, in which the minimum of operations is executed, 
            a worse one, that executes the maximum of operations, and a medium scenario. 
            The O notation represents the worst.

            But actually several notations:
                Ω (n): best case => lower bound.
                O (n): worst case => upper bound.
                Θ (n): mean => average estimate.

            The three cases are a simplification of the complexity of the algorithm and represent its behavior when n → ∞.

            *An Instruction*
            Definition: -> Ideally each of the fundamental operations of the piece of code that we are measuring.
            
            If we count the instructions at processor level:

            They depend on the architecture.
            They require a very deep knowledge of the system:
                - Hardware.
                - Compiler.
                - Implementation of algorithms and API structures ...
            Alternative: we count the instructions of our language, at a high level.

            But almost always (except very specific environments) we are not interested in such a fine grain, 
            and we only want to know how fast a problem grows (in time, space, etc.), as the number of elements 
            that are processed grows.
            - We can ignore the exact number of operations that are performed and look only at the trend of the algorithm.

        What do we look at? What do we count?
            - Fragments that execute a variable number of operations (eg another for loop) => the more the
             size of the problem grows, the more it affects us => we are interested in measuring it. --> (n - input of elements)
            - Fragments that execute a constant number of operations => do not change when the problem grows =>
             we can usually ignore it --> constant computational cost not dependent of the input --> (k). --> f(n) = k --> 
             --> a constant number of operation to check the subproblem conditions


            * Algorithmic and complexity *
             It allows us to compare the temporal efficiency of two algorithms as the size of the problem grows. 
             This means that an algorithm with greater temporal complexity, that is, that performs more operations 
             to obtain the result, will be slower than one with less temporal complexity.




            */
        }  

        


    }
}

