using ConsoleApp1;
Employee employee1 = new Employee("Adam","Kowalski","lat32");
Employee employee2 = new Employee("Hanna", "Kowalska","lat 20");
Employee employee3 = new Employee("Karol","Nasalki","lat 40");

employee1.AddScore(5); 
employee1.AddScore(3);
employee1.AddScore(2);

employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(6);


employee3.AddScore(2);
employee3.AddScore(4);
employee3.AddScore(6);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2,employee3
};

int maxResult=-1;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
   if( employee1.Result>maxResult)
    {
        maxResult = employee1.Result;
        employeeWithMaxResult = employee1;
    }
   else if (employee2.Result>maxResult) 
    {
       maxResult= employee2.Result;
        employeeWithMaxResult = employee2;
    }
   else if(employee3.Result>maxResult) 
    {
        maxResult= employee3.Result;
        employeeWithMaxResult =  employee3;
    }
}
Console.WriteLine($"Pracownik z najwyższą ilością punktów to: {employeeWithMaxResult.Name} {employeeWithMaxResult.Surname}  {employeeWithMaxResult.Age} suma punktów to:{maxResult}");

