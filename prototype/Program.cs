using SimplePrototypeCSharp;

Teacher teacher = new Teacher("Sean", "Creational Design Patterns in C#");
Teacher teacherClone = (Teacher)teacher.Clone();
Console.WriteLine($"Teacher was cloned: {teacherClone.Name} who teachers '{teacherClone.Course}'");

Student student = new Student("James", teacherClone);
Student studentClone = (Student)student.Clone(true);
Console.WriteLine($"Student was cloned: {studentClone.Name} is enrolled in '{studentClone.Teacher.Course}', teacher: {studentClone.Teacher.Name}.");

// change the teacher name on the clone
teacherClone.Name = "John";
Console.WriteLine($"Student was cloned: {studentClone.Name} is enrolled in '{studentClone.Teacher.Course}', teacher: {studentClone.Teacher.Name}.");
