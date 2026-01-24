namespace ConsoleApp1
{
    internal class Program
    {
        interface ISchoolMember
        {
            public string Name { get; set; }
            void Display();
        }
        interface IPrintable
        {
            void Print();
        }
        interface IAttendable
        {
            void MarkAttendance(Student s);
        }
        class Student : ISchoolMember
        {
            string name;
            public string Name { get { return name; } set { name = value; } }

            void ISchoolMember.Display()
            {
                Console.WriteLine($"Name = {Name}");
            }
        }
        class Teacher : ISchoolMember
        {
            string name;
            public string Name { get { return name; } set { name = value; } }

            public void Display()
            {
                Console.WriteLine($"Name = {Name}");
            }
        }
        class Administrator : ISchoolMember, IAttendable
        {

            string name;
            public string Name { get { return name; } set { name = value; } }

            public void Display()
            {
                Console.WriteLine($"Name = {Name}");
            }

            public void MarkAttendance(Student s)
            {
                Console.WriteLine($"{s.Name} has attended");
            }
        }
        static void Main(string[] args)
        {
            
        }
    }
}
