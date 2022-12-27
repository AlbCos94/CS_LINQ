// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Anounymous Types Training. 

namespace TrainingStuffC{

    public class ProgramC
    {    


        public void MainProcess ()
        {
            Console.WriteLine(" !!I AM THE PROGRAM C - Training of Anonymous types!! ");
            
            // ** var **
            // To represent Entity with set of propertis to which we give a vallue at the time of the creation 
            // They are just "READ-ONLY" --> to represent temporal grouping of properties that have menaing for us in the local area without haven to formally define a class or a struct that reperesents them

            /*
            Other properties: 
                They are objects that inherit from Object.
                Can not be cast to anything (except Object).
                The values of its properties can not be modified once they have been assigned.
                There are restrictions on the values that can be stored:
                They do not allow to assign nulls.
                They do not allow assigning pointers.
                They can not define anonymous functions, events, methods ...
                You can not inherit from them.

            Uses:
                - Definition of local variables into a function.
                - Definition of an iterator into a for or foreach loop.
                - LINQ expressions.
                - Methods returns.
            */

            // Use due to there is no type to define a data struct
            var IamAnewDataStruct = new {
                Name = "Paul",
                Age = 43
            };
           
            Console.WriteLine(IamAnewDataStruct.Name);
            Console.WriteLine(IamAnewDataStruct.Age);

            // Use when using Queries:
            string[] words = { "apple", "strawberry", "grape", "peach", "banana" };
            // we take from "words" a data table with those words beginning with "g"
            var wordQuery = words.Where(w => w[0] == 'g');
            IEnumerable<String> wordQueryb = words.Where(w => w[0] == 'A');
            
            // this one is not an anonomus type:
            Console.WriteLine("Type of the iterator of the collection: ");
            Console.WriteLine(wordQuery.ElementAt(0).GetType()); // --> String
            Console.WriteLine(wordQuery.GetEnumerator().GetType()); // --> String
            Console.WriteLine(wordQuery.GetType()); // --> String

            Console.WriteLine(wordQuery);
            Console.WriteLine(wordQueryb);

        }

        public void CreateSomeProductsObjects ()
        {
            
            Product_stuff.Product ProductA = new Product_stuff.Product();
            ProductA.Name = "Albert";
            ProductA.Color = "Red";
            ProductA.Price = 45;
            Product_stuff.Product ProductB = new Product_stuff.Product(); // using default constructor
            Product_stuff.Product ProductC = new Product_stuff.Product("Albert", "blue","Animal",595);
            Product_stuff.Product ProductD = new Product_stuff.Product("Isra");
            Product_stuff.Product ProductE = new Product_stuff.Product("Albert");

            var myArrayOfProducts = new List<Product_stuff.Product>();
            myArrayOfProducts.Add(ProductA);
            myArrayOfProducts.Add(ProductB);
            myArrayOfProducts.Add(ProductC);
            myArrayOfProducts.Add(ProductD);
            myArrayOfProducts.Add(ProductE);

            // Cretion of properties inside an anonymous type without a name, and inherit them from the original object. 
            var productDetails = myArrayOfProducts.Where(p => p.Name == "Albert").Select( p => new 
            {
                p.Color,
                p.Price

            });


            // some testing...
            /*
            Console.WriteLine(productDetails.GetType());
            Console.WriteLine(productDetails.First().Color);
            Console.WriteLine(productDetails.First().Price); // first gets the first object of the collection
            */

            // Working with anonymous types:

            // Query that gets a data struc ( a list in the example ) and returns an enumerable 
            // IEnumerable<T>, where T is a "new" type of object taken/made out from the collection. 
            // sum up in the Example --> we get from the collection "myArrayOfProducts" a new struc/collection derived from the items
            // of the first collection
            // Example:
            var productQuery = from prod in myArrayOfProducts
                                where prod.Type == "Person"
                                select new {prod.Name, prod.Color, prod.Price};

            foreach (var item in productQuery)
            {
                Console.WriteLine("Name={0}, Price={1}, COLOR={2}", item.Name, item.Price, item.Color); // formating printing 
            }
            
            // When can an Anonymous type can be used -> "new"
            /*
                Always in the local scope of a method.
                When we return values in a Select( ) of a query.
                When we need to create temporary structures to group properties whose value we are not going to modify, but we do not want to define a structure for the data.

                We can work with the anonymous types in the projections (Select( ) and SelectMany( )) of the LINQ queries that we do.
                But only at the local level.
                    We can make a query and save the result as a var, but not return the var to other methods, nor pass it as a parameter.
                If we need to return or pass the values of the query we have to use other mechanisms:
                    In an own object.
                    In a struct.
                    In a tuple.
            */

            // Way to initialize a collection - Array
            // When the Add( ) method of the collection receives a single parameter (the object to be added), 
            // we can create the collection and add all the objects we want, separated by commas. 
            Product_stuff.Product[] myOtherArrayOfProducts = new Product_stuff.Product[4];
            Product_stuff.Product ProductF = new Product_stuff.Product("Pepito", "yellow","fish", 77); // using default constructor
            Product_stuff.Product ProductG = new Product_stuff.Product("Sasha", "pink", "tortoise" , 88);
            Product_stuff.Product ProductH = new Product_stuff.Product("Albert");
            Product_stuff.Product ProductI = new Product_stuff.Product("Sasha");
            
            myOtherArrayOfProducts.SetValue(ProductF,0);
            myOtherArrayOfProducts.SetValue(ProductG,1);
            myOtherArrayOfProducts.SetValue(ProductH,2);
            myOtherArrayOfProducts.SetValue(ProductI,3);

            // Array collection is ploted
            Console.WriteLine("New Array"); // formating printing 
            foreach (var item in myOtherArrayOfProducts)
            {
                Console.WriteLine("Name={0}, Price={1}, COLOR={2}", item.Name, item.Price, item.Color); // formating printing 
            }

        }
    }
}

