namespace LinQDay1p2
{
    internal class Program
    {
        class Subject
        {
            public int Code {  get; set; }
            public string Name { get; set; }
        }
        class Student
        {
            public int ID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public Subject[] subjects { get; set; } 


        }
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>(){
                new Student(){ ID=1, FirstName="Ali", LastName="Mohammed",
                subjects=new Subject[]{ new Subject(){ Code=22,Name="EF"}, new Subject(){
                Code=33,Name="UML"}}},
                new Student(){ ID=2, FirstName="Mona", LastName="Gala",
                subjects=new Subject []{ new Subject(){ Code=22,Name="EF"}, new Subject (){
                Code=34,Name="XML"},new Subject (){ Code=25, Name="JS"}}}, new
                Student(){ ID=3, FirstName="Yara", LastName="Yousf", subjects=new Subject
                []{ new Subject (){ Code=22,Name="EF"}, new Subject (){
                Code=25,Name="JS"}}},
                new Student(){ ID=1, FirstName="Ali", LastName="Ali",
                subjects=new Subject []{ new Subject (){ Code=33,Name="UML"}}},
            };
            var query1 = students.Select(student => new { fullName = student.FirstName + " " + student.LastName, numOfSubjects = student.subjects.Length });
            //foreach (var student in query1)
            //{
            //    Console.WriteLine(student);
            //}
            var query2 = students.Select(student => new { student.FirstName, student.LastName }).OrderByDescending(student => student.FirstName).ThenBy(student => student.LastName).Select(student=>student.FirstName+" "+student.LastName);
            //foreach (var student in query2)
            //{
            //    Console.WriteLine(student);
            //}

            var query3 = students.Select(student => new { studentName = student.FirstName + " " + student.LastName, subjectName = student.subjects[0].Name });
            //foreach (var student in query3)
            //{
            //    Console.WriteLine(student);
            //}
        }
    }
}
