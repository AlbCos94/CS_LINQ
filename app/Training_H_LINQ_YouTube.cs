// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Anounymous Types Training. 

namespace TrainingStuffH{

    public class ProgramH
    {    
        public static void MainProcess ()
        {
            Console.WriteLine(" !!I AM THE PROGRAM H - Training of LINQ from YouTube!! ");   
            
            //Link: https://www.youtube.com/watch?v=AqLNR_xhd0E
            
            // Languaje INtegrated Query -> LINQ -> API LINQ
            // -> Lenguaje de consulta integrado en C# y VB.NET (paltaforma)
            // -> Usage -> para guardar y consultar datos de diferentes origenes ( e.g. Acceder a datos de: Base de Dataps SQL, informacion almacenada en objectos,
            // , en ficheros XML, en Recordset, en Entidades,...)
            // Permite uniformidad en lenguajes de consulta, reduccion de codigo, mas legible, perfecta integracion en C#

            // API LINQ -> formada por dos clases que proporcionan los métodos para acceder a todos estos datos. 
                // Enumerable -> IEnumerable (interface) -> https://learn.microsoft.com/es-es/dotnet/api/system.collections.ienumerable?view=net-7.0
                // Queryable -> IQueryable  (interface) -> https://learn.microsoft.com/es-es/dotnet/api/system.linq.iqueryable?view=net-7.0 


            int [] valoresNumericos = new int[] {1,2,3,4,5,6,7,8,9, 10};

            // Forma convencional imprimir numeros pares:
            Console.WriteLine("Numeros pares: ");
            List<int> numerosPares = new List<int>();
            foreach (int numero in valoresNumericos)
            {
                if (numero % 2 == 0 )
                {
                    numerosPares.Add(numero);
                }
            }
            foreach( int i in numerosPares)
            {

                Console.WriteLine(i);
            }

            //Forma con LINQ
            //IEnumerable -> objeto que almacena elementos de una coleccion
            // where --> filtrar , calcular operaciones con los elementos de la coleccion
            IEnumerable<int> numerosPares2 = from numero in valoresNumericos where numero % 2 == 0 select numero;
            foreach( int i in numerosPares2)
            {

                Console.WriteLine(i);
            }

        }
    }
}

