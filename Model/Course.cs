using System.ComponentModel.DataAnnotations;

namespace CIS169IntroToNET.Model;

public class Course
{
    public int Id { get; set; }
    [Display(Name = "Course Name")]
    public string? CourseName { get; set; }
    public string? CourseDescription { get; set; }
    public int RoomNumber { get; set; }

    [DataType(DataType.Time)] 
    public TimeOnly StartTime { get; set; }
    
    [DataType(DataType.Time)]
    
    public TimeOnly EndTime { get; set; }
}