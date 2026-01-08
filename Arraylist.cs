using System;
using System.Collections;

class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeID { get; set; }
    public double EmployeeSalary { get; set; }

    public Employee(string name, int id, double salary)
    {
        EmployeeName = name;
        EmployeeID = id;
        EmployeeSalary = salary;
    }

    public void DisplayEmployeeDetails()
    {
        Console.WriteLine("Employee Name: " + EmployeeName);
        Console.WriteLine("Employee ID: " + EmployeeID);
        Console.WriteLine("Employee Salary: " + EmployeeSalary);
    }
}

internal class EmployeeDAL
{
    private ArrayList employees = new ArrayList();

   
    public bool AddEmployee(Employee e)
    {
        if (e != null)
        {
            employees.Add(e);
            return true;
        }
        return false;
    }

    
    public bool DeleteEmployee(int id)
    {
        foreach (Employee emp in employees)
        {
            if (emp.EmployeeID == id)
            {
                employees.Remove(emp);
                return true;
            }
        }
        return false;
    }

    public string SearchEmployee(int id)
    {
        foreach (Employee emp in employees)
        {
            if (emp.EmployeeID == id)
            {
                return emp.EmployeeName;
            }
        }
        return null;
    }

    
    public Employee[] GetAllEmployeesListAll()
    {
        return (Employee[])employees.ToArray(typeof(Employee));
    }
   
}