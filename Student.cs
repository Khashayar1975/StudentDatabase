namespace StudentDatabase
{
    // This class represents a student in the database.
    public class Student
    {
        // Primary key for each student.
        public int StudentId { get; set; }

        // Student's full name.
        public string StudentName { get; set; } = string.Empty;

        // Student's age.
        public int Age { get; set; }
    }
}