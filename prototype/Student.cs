namespace SimplePrototypeCSharp
{
    // ConcretePrototype2
    public class Student : Person
    {
        public Student(string name, Teacher teacher) : base(name)
        {
            Teacher = teacher;
        }

        public Teacher Teacher { get; set; }

        public override Person Clone(bool deepClone = false)
        {
            if (!deepClone) return (Person)MemberwiseClone();

            Student studentClone = (Student)MemberwiseClone();
            studentClone.Teacher = new Teacher(this.Teacher.Name, this.Teacher.Course);
            return studentClone;
        }
    }
}