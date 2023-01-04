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

Console.Write("\nWhile() on list: \n"); 
TrainingStuffI.ProgramI.Execute_Where_OnList();
Console.Write("\nWhile() on array: \n"); 
TrainingStuffI.ProgramI.Execute_Where_OnArray();
Console.Write("\nFirst() on list: \n"); 

int lessThan = 3;
TrainingStuffI.ProgramI.Execute_First_OnList(lessThan);
Console.Write("\nFirst() on array: \n"); 
int lessThan2 = 3;
TrainingStuffI.ProgramI.Execute_First_OnArray(lessThan2);

Console.Write("\nLast() on list: \n"); 
int lessThan3 = 10;
TrainingStuffI.ProgramI.Execute_Last_OnList(lessThan3);
Console.Write("\nLast() on array: \n"); 
int lessThan4 = 10;

TrainingStuffI.ProgramI.Execute_Last_OnArray(lessThan4);
Console.Write("\nSingle() on list: \n"); 
// miramos que haya SOLO un numeros entre Min y Max
int Min1 = 11;
int Max1 = 15;
TrainingStuffI.ProgramI.Execute_Single_OnList(Min1, Max1);
Console.Write("\nSingle() on array: \n"); 
int Min2 = 11;
int Max2 = 15;
TrainingStuffI.ProgramI.Execute_Single_OnArray(Min2, Max2);


Console.Write("\nElementAt() on list: \n"); 
int index1 = 3;
TrainingStuffI.ProgramI.Execute_ElementAt_OnList(index1);
Console.Write("\nElementAt() on array: \n"); 
int index2 = 3;
TrainingStuffI.ProgramI.Execute_ElementAt_OnArray(index2);


Console.Write("\nQUANTIFYERS\n"); 

Console.Write("\nAny() on list: \n"); 
int MAX1 = 3;
TrainingStuffI.ProgramI.Execute_Any_OnList(MAX1);
Console.Write("\nAny() on array: \n"); 
int MAX2 = 0;
TrainingStuffI.ProgramI.Execute_Any_OnArray(MAX2);

Console.Write("\nAll() on list: \n"); 
int MAX3 = 30000;
TrainingStuffI.ProgramI.Execute_All_OnList(MAX3);
Console.Write("\nAll() on array: \n"); 
int MAX4 = 0;
TrainingStuffI.ProgramI.Execute_All_OnArray(MAX4);

Console.Write("\nContains() on list: \n"); 
int numA = 30000;
TrainingStuffI.ProgramI.Execute_Contains_OnList(numA);
Console.Write("\nContains() on array: \n"); 
int numB = 2;
TrainingStuffI.ProgramI.Execute_Contains_OnArray(numB);

Console.Write("\nOrderBy() on list: \n"); 
TrainingStuffI.ProgramI.Execute_OrderBy_OnList();
Console.Write("\nOrderBy() on array: \n"); 
TrainingStuffI.ProgramI.Execute_OrderBy_OnArray();

Console.Write("\nReverse() on list: \n"); 
TrainingStuffI.ProgramI.Execute_Reverse_OnList();
Console.Write("\nReverse() on array: \n"); 
TrainingStuffI.ProgramI.Execute_Reverse_OnArray();

Console.Write("\nThenBy() on array: \n"); 
TrainingStuffI.ProgramI.Execute_ThenBy_OnArray();

Console.Write("\nThenByDescending() on array: \n"); 
TrainingStuffI.ProgramI.Execute_ThenByDescending_OnArray();

Console.Write("\nGroupByStudents on List Of Students: \n"); 
TrainingStuffI.ProgramI.Execute_GroupBy_OnList();

Console.Write("\nGroupByStudents using two criterias on List Of Students: \n"); 
TrainingStuffI.ProgramI.Execute_GroupBy2Criterias_OnList();

Console.Write("\nAverage of an int numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Average_OnIntArray();
Console.Write("\nAverage of an double numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Average_OnDoubleArray();

Console.Write("\nNumer of element of an int numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Count_OnIntArray();
Console.Write("\nNumber of an double numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Count_OnDoubleArray();

Console.Write("\nMax element of an int numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Max_OnIntArray();
Console.Write("\nMin element of an double numerical sequence: \n"); 
TrainingStuffI.ProgramI.Execute_Min_OnDoubleArray();

Console.Write("\nSum score of all the Students: \n"); 
TrainingStuffI.ProgramI.Execute_Sum_OnStudents();

Console.Write("\nSet of numbers with no repetitions: \n"); 
TrainingStuffI.ProgramI.Execute_Distinc_OnInt();

Console.Write("\nSet of numbers not appering in second collection: \n"); 
TrainingStuffI.ProgramI.Execute_Except_OnInt();

Console.Write("\nSet of numbers appering in second collection: \n"); 
TrainingStuffI.ProgramI.Execute_Intersect_OnInt();

Console.Write("\nSet of numbers appering in both collections: \n"); 
TrainingStuffI.ProgramI.Execute_Union_OnInt();

Console.Write("Set of numbers are all multiplied x 2: \n"); 
TrainingStuffI.ProgramI.Execute_Select_IntArrayx2();

Console.WriteLine("\nInt collection transformed to an anonymous type collection of circles ");
TrainingStuffI.ProgramI.Execute_Select_IntArrayToSurfacesCircunference();

Console.WriteLine("\nFrom a Student collection a new collection is gotten formed by the students scores: ");
TrainingStuffI.ProgramI.Execute_SelectMany_fromStudentsCollectionSelectScores();

Console.WriteLine("\nN first elements of a collection will be skipped: ");
TrainingStuffI.ProgramI.Execute_Skip_NfirstIntSkipped(2);

int numberA = 2;
Console.WriteLine("\nElements of a collection with value less than {0} will be skipped: ", numberA);
TrainingStuffI.ProgramI.Execute_SkipWhile_LessThan(numberA);

int numberB = 3;
Console.WriteLine("\n{0} first elements of a collection will be taken: ", numberB);
TrainingStuffI.ProgramI.Execute_Take_NfirstIntTaken(numberB);

int numberC = 3;
Console.WriteLine("\nFirst elements of a collection with value less thant {0} will be taken: ", numberC);
TrainingStuffI.ProgramI.Execute_TakeWhile_NfirstLowerThan(numberC);

Console.WriteLine("\nUse of join, combination of Students going with an specific teache");
TrainingStuffI.ProgramI.Execute_Join_StundentsAndCourses();

Console.WriteLine("\nUse of GroupJoin, for each course we display all the students associated with it: ");
TrainingStuffI.ProgramI.Execute_GroupJoin_StundentsAndCourses();

//** Trouebleshooting **//
Console.WriteLine("\nTrying to get a collectin of something that is an empty sequence: ");
TrainingStuffJ.ProgramJ.TryGetCollectionStudents_usingWhere_ConditionNotFound();

// Console.WriteLine("Trying to get first element of collection but conditions doesnt match: ");
// TrainingStuffJ.ProgramJ.TryGetStudents_usingFirst_ConditionNotFound();

Console.WriteLine("\nTrying to get first element OR THE DEFAULT ONE of collection but conditions doesnt match: ");
TrainingStuffJ.ProgramJ.TryGetStudents_usingFirstOrDefault_ConditionNotFound();

Console.WriteLine("\nTrying to get first element of collection but conditions doesnt match - good implementation: ");
TrainingStuffJ.ProgramJ.TryGetStudents_usingFirst_ConditionNotFound_GoodImplementation();


Console.WriteLine("\nTrying to get first element of collection but conditions doesnt match - BEST implementation: ");
TrainingStuffJ.ProgramJ.TryGetStudents_usingFirstOrDefault_ConditionNotFound_BestImplementation();


Console.WriteLine("\nCreating a XML tree by parsing a string: ");
//TrainingStuffK.ProgramK.StringToXMLTree();

Console.WriteLine("\nLoad a XML from file: ");
TrainingStuffK.ProgramK.LoadXMLfromFile();

Console.WriteLine("\nLoad XML from Text Reader: ");
TrainingStuffK.ProgramK.LoadXMLfromTextReader();

Console.WriteLine("\nDescendant on an XML file: ");
TrainingStuffK.ProgramK.Descendants_XML();

Console.WriteLine("\nAncestors on an XML file: ");
TrainingStuffK.ProgramK.Ancestors_XML();

Console.WriteLine("\nCollection of child elements of an XML file: ");
TrainingStuffK.ProgramK.Elements_XML();

Console.WriteLine("\nRetrieve value of an element from a XML file: ");
TrainingStuffK.ProgramK.Retrieve_Value_Element();

Console.WriteLine("\nCreate a XML file with atributes ");
TrainingStuffK.ProgramK.StringToXMLTreeWithAttributs();

Console.WriteLine("\nGet attributes from a field of a XML ");
TrainingStuffK.ProgramK.Retrieve_Atributes();

Console.WriteLine("\nGet an speciffic attribute from a field of a XML ");
TrainingStuffK.ProgramK.Retrieve_SingleAtribute();

Console.WriteLine("\nAdd an element to an XML Tree");
TrainingStuffK.ProgramK.AddingElementsToXMLTree();

Console.WriteLine("\nRemove some stuff from a XML Tree");
TrainingStuffK.ProgramK.RemoveElementOfXMLTree();

Console.WriteLine("\nRemove some nodes from a XML Tree");
TrainingStuffK.ProgramK.RemoveNodesOfXMLTree();

Console.WriteLine("\nTry Is Epty");
TrainingStuffM.ProgramM.IsEmpty_OnListString();