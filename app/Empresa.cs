// to avoind using the namespace "System.Collection" for all the items of the collections we define:
using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

// Anounymous Types Training. 

namespace EmpresaStuff{

    public class Empresa
    {    
        public int numId {get; set;}
        public string Nombre {get; set;}

        public void PrintDatosEmpresa()
        {
            Console.Write("Empresa {0} con Id {1} ", Nombre, numId);

        }
        
    }


    public class Empleado
    {    
        public int numId {get; set;}
        public string Nombre {get; set;}

        public string Cargo {get; set;}

        public double Salario {get; set;}

        // Clave foraneo
        public int EmpresaId { get; set;}

        public void PrintDatosEmpleado()
        {
            Console.Write("Empleado {0} con Id {1}, cargo {2} con salario {3}" + 
            " y perteneciente a la emperesa {4} \n", Nombre, numId, Cargo, Salario, EmpresaId);

        }
        
    }


    // Clase para almacenar las empresas y sus empleados

    class ControlEmpresasEmpleados
    {

        public List<Empresa> listaDeEmpresas;
        public List<Empleado> listaDeEmpleados;

        //constructor
        public ControlEmpresasEmpleados()
        {
            listaDeEmpresas = new List<Empresa>(); 
            listaDeEmpleados = new List<Empleado>(); 

            listaDeEmpresas.Add(new Empresa { numId = 1, Nombre = "Google"});
            listaDeEmpresas.Add(new Empresa { numId = 2, Nombre = "PildorasInformaticas"});

            listaDeEmpleados.Add(new Empleado { numId = 1, Nombre = "Sergey", Cargo = "CEO", EmpresaId = 1, Salario = 150000}); // pertenece a Google
            listaDeEmpleados.Add(new Empleado { numId = 2, Nombre = "Juan", Cargo = "CEO", EmpresaId = 2, Salario = 1500000}); // pertenece a Pildoras
            listaDeEmpleados.Add(new Empleado { numId = 3, Nombre = "Larry", Cargo = "Co-CEO", EmpresaId = 1, Salario = 35000}); // pertenece a Google
            listaDeEmpleados.Add(new Empleado { numId = 4, Nombre = "Irina", Cargo = "Developer", EmpresaId = 2, Salario = 45000}); // pertenece a Pildoras

        }

        public void displayCEO()
        {
            IEnumerable<Empleado> ceos = from empleado in listaDeEmpleados where empleado.Cargo == "CEO" select empleado;

            foreach (var empleado_i in ceos)
            {
                empleado_i.PrintDatosEmpleado();
            }
        }


        public void displayGoogleEmployees()
        {
            IEnumerable<Empleado> GoogleEmployees = from empleado in listaDeEmpleados where empleado.EmpresaId == 1 select empleado;

            foreach (var empleado_i in GoogleEmployees)
            {
                empleado_i.PrintDatosEmpleado();
            }
        }

        public void displayPildorasEmployees()
        {
            IEnumerable<Empleado> PildorasEmployees = from empleado in listaDeEmpleados where empleado.EmpresaId == 2 select empleado;

            foreach (var empleado_i in PildorasEmployees)
            {
                empleado_i.PrintDatosEmpleado();
            }
        }
    
        public void displayEmployeesHighSalary()
        {
            IEnumerable<Empleado> highSalariesEmployees = from empleado in listaDeEmpleados where empleado.Salario > 60000 select empleado;

            foreach (var empleado_i in highSalariesEmployees)
            {
                empleado_i.PrintDatosEmpleado();
            }
        }

    
    }

}

