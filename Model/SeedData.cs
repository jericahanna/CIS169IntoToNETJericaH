using System;
using CIS169IntroToNET.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace CIS169IntroToNET.Model
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new CIS169IntroToNETContext(
                       serviceProvider.GetRequiredService<
                           DbContextOptions<CIS169IntroToNETContext>>()))
            {
                if (context == null || context.Course == null)
                {
                    throw new ArgumentNullException("Null CIS169IntroToNETContext");
                }

                
                if (context.Course.Any())
                {
                    return;
                }

                context.Course.AddRange(
                    new Course
                    {
                        CourseName = "Python",
                        CourseDescription = "Python is a Programming language.",
                        StartTime =  TimeOnly.Parse("12:15:12"),
                        EndTime = TimeOnly.Parse("12:15:12"),
                        RoomNumber = 116

                    },
                    new Course
                    {
                        CourseName = "C# Programming",
                        CourseDescription = "C# Programming Language.",
                        StartTime =  TimeOnly.Parse("12:15:12"),
                        EndTime =  TimeOnly.Parse("12:15:12"),
                        RoomNumber = 117
                    },
                    new Course
                    {
                        CourseName = "HTML/CSS",
                        CourseDescription = "HTML/CSS Programming Language.",
                        StartTime = TimeOnly.Parse("12:15:12"),
                        EndTime = TimeOnly.Parse("12:15:12"),
                        RoomNumber = 118
                    },
                    new Course
                    {
                        CourseName = "JavaScript Basics",
                        CourseDescription = "JavaScript Basics Language.",
                        StartTime =  TimeOnly.Parse("12:15:12"),
                        EndTime =  TimeOnly.Parse("12:15:12"),
                        RoomNumber = 119
                    },
                    new Course
                    {
                        CourseName = "SQL Fundamentals",
                        CourseDescription = "SQL Fundamentals Programming Language.",
                        StartTime = TimeOnly.Parse("12:15:12"),
                        EndTime =  TimeOnly.Parse("12:15:12"),
                        RoomNumber = 120
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
