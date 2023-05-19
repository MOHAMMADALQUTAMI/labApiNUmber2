using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models;
using EmployeeApi.Models.Student;
namespace EmployeeController.Controllers;
[ApiController]
[Route("[controller]/[action]")]

public class EmployeeController: ControllerBase
{
public static List<Employee> EmployeeDatabase =new List<Employee>();

[HttpGet( Name= "GetAllEmployee")]
public List<Employee> Get(){
    return EmployeeDatabase;
}
  
        
    
[HttpPost(Name = "Employee Added")]
public string Add(int id , string name , string lastName ){
    Employee employee = new Employee
    {
        Id = id,
        Name =name,
        LastName = lastName,
        

    };
    
    EmployeeDatabase.Add(employee);
//    var a = EmployeeDatabase[10];

    return "Employee Adeed" + " " + employee.Name;
}
[HttpPut(Name = "Employee Updated")]
public string Update(Employee employee){
    return $"Employee Updated:{employee.Name} {employee.Id} {employee.LastName}";
}
[HttpDelete(Name = "Employee Deleted")]
public string Delete(int id)
{
    foreach(Employee employee in EmployeeDatabase)
    if (employee.Id==id)
   { EmployeeDatabase.Remove(employee);
    break;
   }return $"Employee Deleted {id}";
}
}