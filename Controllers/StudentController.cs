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
[HttpPost(Name = "Student Updated")]

    public string Update( int id ,string title,String city){
     Student newstudent =new Student();
     foreach(Student UpdateEmployee in StudentDatabase)
     if (UpdateEmployee.Id == id)
     newstudent =UpdateEmployee;
     
    newstudent.Id=id;
    newstudent.Title=title;
    newstudent.City=city;
    return $"Student Updated:{newstudent.Id} {newstudent.Title} {newstudent.City}";
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