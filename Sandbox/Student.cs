namespace Sandbox
{
    public class Student
    {
        public string Name { get;  }
        public string Mobile { get; }

        public Student()
        {
            Name = "No name";
            Mobile = "Nothing";
        }

        public Student(string name, string mobile)
        {
            Name = name;
            Mobile = mobile;
        }
    }
}