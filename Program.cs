using System;

class Program
{
    static void Main()
    {
        EmployeeDAL dal = new EmployeeDAL();

        dal.AddEmployee(new Employee("John", 101, 50000));
        dal.AddEmployee(new Employee("Peter", 102, 60000));
      
        Console.WriteLine("All Employees:");
        foreach (var emp in dal.GetAllEmployeesListAll())
        {
            emp.DisplayEmployeeDetails();
            Console.WriteLine();
        }
        Console.WriteLine("Search ID 101: " + dal.SearchEmployee(101));

        dal.DeleteEmployee(102);

        Console.WriteLine("After Deletion EmpID 102:");
        foreach (var emp in dal.GetAllEmployeesListAll())
        {
            emp.DisplayEmployeeDetails();
            Console.WriteLine();
        }
    }
}