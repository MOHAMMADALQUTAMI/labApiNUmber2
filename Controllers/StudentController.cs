using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using EmployeeApi.Models.Student;
namespace StudentController.Controllers;
[ApiController]
[Route("[controller]/[action]")]

public class StudentController: ControllerBase
{
public static List<Student> StudentDatabase =new List<Student>();

[HttpGet( Name= "GetAllStudent")]
public List<Student> Get(){
    return StudentDatabase;
}
  
        
    
[HttpPost(Name = "Student Added")]
public string Add(int id , string title , string city ){
    Student student = new Student
    {
        Id = id,
        Title =title,
        City = city,
        

    };
    
    StudentDatabase.Add(student);
//    var a = EmployeeDatabase[10];

    return "Student Adeed" + " " + student.Title;
}
[HttpPut(Name = "Student Updated")]
public string Update(Student student){
    return $"Student Updated:{student.Id} {student.Title} {student.City}";
}
[HttpDelete(Name = "Student Deleted")]
public string Delete(int id)
{
    foreach(Student employee in StudentDatabase)
    if (employee.Id==id)
   { StudentDatabase.Remove(employee);
    break;
   }return $"Student Deleted {id}";
}
}