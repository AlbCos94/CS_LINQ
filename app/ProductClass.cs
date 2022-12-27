// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Collections;
using System.Collections.Generic;

// Anounymous Types Training. 

namespace Product_stuff{


    public class Product
    {    


        public string Name { get; set; }
        public string Color { get; set; }
        public string Type { get; set; }
        public decimal Price { get; set; }

        // the constructors are defined
        public Product()
        {
            Name = "Pepito";
            Color = "white";
            Type = "Person";
            Price = 0; 

        }
        public Product(string name)
        {
            Name = name;
            Color = "white";
            Type = "Person";
            Price = 0; 

        }
        public Product(string name, string color, string person, decimal price)
        {
            Name = name;
            Color = color;
            Type = person;
            Price = price; 

        }
     
    }





}

