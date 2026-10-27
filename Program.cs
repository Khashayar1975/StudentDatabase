using System;

namespace StudentDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a database context
            using (var context = new SchoolContext())
            {
                // Create the database if it does not exist
                context.Database.EnsureCreated();

                // Check whether a student already exists
                if (!context.Students.Any())
                {
                    // Create a new student object
                    Student student = new Student
                    {
                        StudentName = "John Smith",
                        Age = 22
                    };

                    // Add the student to the database
                    context.Students.Add(student);

                    // Save changes to the database
                    context.SaveChanges();

                    Console.WriteLine("Student added successfully!");
                }
                else
                {
                    Console.WriteLine("Student already exists in the database.");
                }

                // Display all students
                Console.WriteLine("\nStudents in the database:");

                foreach (var student in context.Students)
                {
                    Console.WriteLine(
                        $"ID: {student.StudentId}, " +
                        $"Name: {student.StudentName}, " +
                        $"Age: {student.Age}");
                }
            }

            Console.WriteLine("\nPress Enter to exit.");
            Console.ReadLine();
        }
    }
}