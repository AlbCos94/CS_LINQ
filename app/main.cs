
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

EmpresaStuff.ControlEmpresasEmpleados ControlEmpresasEmpleados_test = new EmpresaStuff.ControlEmpresasEmpleados ();
ControlEmpresasEmpleados_test.displayCEO();
// gente de google:
Console.WriteLine("People from Google: ");
ControlEmpresasEmpleados_test.displayGoogleEmployees();
// gente de Pildoras
Console.WriteLine("People from Pildoras: ");
ControlEmpresasEmpleados_test.displayPildorasEmployees();

// gente de salario Alto
Console.WriteLine("People with high Salary: ");
ControlEmpresasEmpleados_test.displayEmployeesHighSalary();