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

        // Clave foranea
        // La clave foránea identifica una columna o grupo de columnas en una tabla (tabla hija o referendo) 
        // que se refiere a una columna o grupo de columnas en otra tabla (tabla maestra o referenciada). 
        // Esta clase tiene un metodo "join" que permite la relacion entre ambas tablas 
        public int EmpresaId { get; set;} // --> INDICE QUE VA A RELACIONAR LA ESTRUCTURA DE DATOS DE EMPRESAS (TABLA MAESTRA) CON LA ESTRUCTURA DE DATOS DE EMPRESARIOS (TABLA HIJA) -> "para relacionar dos tablas"


        public void PrintDatosEmpleado()
        {
            Console.Write("Empleado {0} con Id {1}, cargo {2} con salario {3}" + 
            " y perteneciente a la empresa {4} \n", Nombre, numId, Cargo, Salario, EmpresaId);

        }
        
    }


    // Clase para almacenar las empresas y sus empleados -> generar la "base de datos"

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
            listaDeEmpleados.Add(new Empleado { numId = 1, Nombre = "Alfonso", Cargo = "Employer", EmpresaId = 2, Salario = 75000}); // pertenece a Google

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

        public void DisplayEmployeesOrderedByName()
        {

            IEnumerable<Empleado> EmployeesSortedByName = from empleado in listaDeEmpleados orderby empleado.Nombre select empleado;

            foreach (var empleado_i in EmployeesSortedByName)
            {
                empleado_i.PrintDatosEmpleado();
            }
        }

        public void DisplayEmployeesOrderedByNameReverse()
        {

            IEnumerable<Empleado> EmployeesSortedByNameDescent = from empleado in listaDeEmpleados orderby empleado.Nombre descending select empleado;

            foreach (var empleado_i in EmployeesSortedByNameDescent)
            {
                empleado_i.PrintDatosEmpleado();
            }
        }

        //Metodo join para relacionar la tabla de datos de los empleados con la tabla de datos de las empresas
        // buscamos empleados que pertenezcan a la empresa "PildorasInformaticas"  a través el nombre propio de la empersa y no indicando el id
        // el idDeEmpresa sera la clave foranea para hacer la relacion puente
        public void DisplayEmpleadosPildoras()
        {
            IEnumerable<Empleado> empleadosPildora = from empleado in listaDeEmpleados join empresa in listaDeEmpresas 
            on empleado.EmpresaId equals empresa.numId where empresa.Nombre=="PildorasInformaticas" select empleado;
           
            foreach (var empleado_i in empleadosPildora)
            {
                empleado_i.PrintDatosEmpleado();
            }

        }

        // User will chose the Company and its employees will be displayed
        public void DisplayEmployeesFromCompany(int Id)
        {         

            IEnumerable<Empleado> empleadosPildora = from empleado in listaDeEmpleados join empresa in listaDeEmpresas 
            on empleado.EmpresaId equals empresa.numId where empresa.numId==Id select empleado;
           
            foreach (Empleado empleado_i in empleadosPildora)
            {
                empleado_i.PrintDatosEmpleado();
            }
        }
    }
}

