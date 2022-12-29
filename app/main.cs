// Where all programs are called 

TrainingStuff.ProgramA program_A_test = new TrainingStuff.ProgramA ();
//program_A_test.MainProcess();

TrainingStuffB.ProgramB program_B_test = new TrainingStuffB.ProgramB ();
//program_B_test.MainProcess();

TrainingStuffC.ProgramC program_C_test = new TrainingStuffC.ProgramC ();
//program_C_test.MainProcess();
//program_C_test.CreateSomeProductsObjects();

TrainingStuffD.ProgramD program_D_test = new TrainingStuffD.ProgramD ();
//program_D_test.MainProcess();
// program_D_test.StatefulIteration();
// Following method are called without any instance, but from its Type, since they are static methods!!:
// TrainingStuffD.ProgramD.StatefulIteration();
// TrainingStuffD.ProgramD.SecondMain(); //(*11)

// We create a delegate and associate the method
// TrainingStuffE.ProgramE.Del handler = TrainingStuffE.ProgramE.DelegateMethod;
//handler("hello!");
//TrainingStuffE.ProgramE.Main();
// TrainingStuffE.ProgramE_V2.Main();

// TrainingStuffF.ProgramF.MainProcess();

// TrainingStuffG.ProgramG.MainProcess();

//TrainingStuffH.ProgramH.MainProcess();

// EmpresaStuff.ControlEmpresasEmpleados ControlEmpresasEmpleados_test = new EmpresaStuff.ControlEmpresasEmpleados ();
// ControlEmpresasEmpleados_test.displayCEO();
// // gente de google:
// Console.WriteLine("People from Google: ");
// ControlEmpresasEmpleados_test.displayGoogleEmployees();
// // gente de Pildoras
// Console.WriteLine("People from Pildoras: ");
// ControlEmpresasEmpleados_test.displayPildorasEmployees();

// // gente de salario Alto
// Console.WriteLine("People with high Salary: ");
// ControlEmpresasEmpleados_test.displayEmployeesHighSalary();

// // gente de ordenada
// Console.WriteLine("People ordered by name: ");
// ControlEmpresasEmpleados_test.DisplayEmployeesOrderedByName();

// // gente de ordenada reversed
// Console.WriteLine("People ordered by name reversed: ");
// ControlEmpresasEmpleados_test.DisplayEmployeesOrderedByNameReverse();

// // gente que trabaja en Pildorasinformaticas
// Console.WriteLine("People working in PildorasInformaticas: ");
// ControlEmpresasEmpleados_test.DisplayEmpleadosPildoras();

// ask to the user for a company to introduce
// remove /**/ commment to use it s 
/*
Console.WriteLine("Please, introduce Id from the company which Employees will be displayed: ");
int idCompanyUser = 1;
try
{
    // Use of a try block in case the User introduces a variables that is not a int , so an exception can be raised
    idCompanyUser = int.Parse(Console.ReadLine()); // user introduces Id of the company through the terminal and we transform it from "string" to "int"
    ControlEmpresasEmpleados_test.DisplayEmployeesFromCompany(idCompanyUser); // if any execption is raised, the corresponding code will be executed
}
catch
{
    Console.Write("User introduced a non int variable \n"); 
}
finally
{
}
*/

// TrainingStuffG.ProgramG.ConvertExample();

TrainingStuffI.ProgramI.MainProcess();

Console.Write("\nFILTERS\n"); 

Console.Write("While() on list: \n"); 
TrainingStuffI.ProgramI.Execute_Where_OnList();
Console.Write("While() on array: \n"); 
TrainingStuffI.ProgramI.Execute_Where_OnArray();
Console.Write("First() on list: \n"); 

int lessThan = 3;
TrainingStuffI.ProgramI.Execute_First_OnList(lessThan);
Console.Write("First() on array: \n"); 
int lessThan2 = 3;
TrainingStuffI.ProgramI.Execute_First_OnArray(lessThan2);

Console.Write("Last() on list: \n"); 
int lessThan3 = 10;
TrainingStuffI.ProgramI.Execute_Last_OnList(lessThan3);
Console.Write("Last() on array: \n"); 
int lessThan4 = 10;

TrainingStuffI.ProgramI.Execute_Last_OnArray(lessThan4);
Console.Write("Single() on list: \n"); 
// miramos que haya SOLO un numeros entre Min y Max
int Min1 = 11;
int Max1 = 15;
TrainingStuffI.ProgramI.Execute_Single_OnList(Min1, Max1);
Console.Write("Single() on array: \n"); 
int Min2 = 11;
int Max2 = 15;
TrainingStuffI.ProgramI.Execute_Single_OnArray(Min2, Max2);


Console.Write("ElementAt() on list: \n"); 
int index1 = 3;
TrainingStuffI.ProgramI.Execute_ElementAt_OnList(index1);
Console.Write("ElementAt() on array: \n"); 
int index2 = 3;
TrainingStuffI.ProgramI.Execute_ElementAt_OnArray(index2);


Console.Write("\nQUANTIFYERS\n"); 

Console.Write("Any() on list: \n"); 
int MAX1 = 3;
TrainingStuffI.ProgramI.Execute_Any_OnList(MAX1);
Console.Write("Any() on array: \n"); 
int MAX2 = 0;
TrainingStuffI.ProgramI.Execute_Any_OnArray(MAX2);

Console.Write("All() on list: \n"); 
int MAX3 = 30000;
TrainingStuffI.ProgramI.Execute_All_OnList(MAX3);
Console.Write("All() on array: \n"); 
int MAX4 = 0;
TrainingStuffI.ProgramI.Execute_All_OnArray(MAX4);

Console.Write("Contains() on list: \n"); 
int numA = 30000;
TrainingStuffI.ProgramI.Execute_Contains_OnList(numA);
Console.Write("Contains() on array: \n"); 
int numB = 2;
TrainingStuffI.ProgramI.Execute_Contains_OnArray(numB);

Console.Write("OrderBy() on list: \n"); 
TrainingStuffI.ProgramI.Execute_OrderBy_OnList();
Console.Write("OrderBy() on array: \n"); 
TrainingStuffI.ProgramI.Execute_OrderBy_OnArray();

Console.Write("Reverse() on list: \n"); 
TrainingStuffI.ProgramI.Execute_Reverse_OnList();
Console.Write("Reverse() on array: \n"); 
TrainingStuffI.ProgramI.Execute_Reverse_OnArray();

Console.Write("ThenBy() on array: \n"); 
TrainingStuffI.ProgramI.Execute_ThenBy_OnArray();

Console.Write("ThenByDescending() on array: \n"); 
TrainingStuffI.ProgramI.Execute_ThenByDescending_OnArray();

Console.Write("GroupByStudents on List Of Students: \n"); 
TrainingStuffI.ProgramI.Execute_GroupBy_OnList();

Console.Write("GroupByStudents using two criterias on List Of Students: \n"); 
TrainingStuffI.ProgramI.Execute_GroupBy2Criterias_OnList();

Console.Write("Average of an int numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Average_OnIntArray();
Console.Write("Average of an double numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Average_OnDoubleArray();

Console.Write("Numer of element of an int numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Count_OnIntArray();
Console.Write("Number of an double numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Count_OnDoubleArray();

Console.Write("Max element of an int numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Max_OnIntArray();
Console.Write("Min element of an double numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Min_OnDoubleArray();

Console.Write("Sum score of all the Students: \n"); 
TrainingStuffI.ProgramI.Execute_Sum_OnStudents();

Console.Write("Set of numbers with no repetitions: \n"); 
TrainingStuffI.ProgramI.Execute_Distinc_OnInt();

Console.Write("Set of numbers not appering in second collection: \n"); 
TrainingStuffI.ProgramI.Execute_Except_OnInt();

Console.Write("Set of numbers appering in second collection: \n"); 
TrainingStuffI.ProgramI.Execute_Intersect_OnInt();

Console.Write("Set of numbers appering in both collections: \n"); 
TrainingStuffI.ProgramI.Execute_Union_OnInt();

Console.Write("Set of numbers are all multiplied x 2: \n"); 
TrainingStuffI.ProgramI.Execute_Select_IntArrayx2();