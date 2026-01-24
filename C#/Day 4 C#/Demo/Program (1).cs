namespace Day4PII
{
    struct Complex
    {
        public int real { get; set; }
        public int img { get; set; }
        public override string ToString()
        {
            return $"{real}+{img}i";
        }

    }
    class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public override string ToString()
        {
           return $"{id}-{name}-{age} years old";
        }

        public override bool Equals(object? obj)
        {
            Employee em = (Employee)obj;
            return (id == em.id && name == em.name && age == em.age);
        }
        public override int GetHashCode()
        {
            return id;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee em = new Employee();


            //Complex c = new Complex();


            //object obj = new Employee();
            //obj = 1;
            //obj = new Complex();
            //obj = "ali";


            //object o1 = 2;
            //o1.

            //object[] arr = new object[4];
            //arr[0] = 1;
            //arr[1] = new Employee();
            //Console.WriteLine(arr[0].);

            //tostring

            //Complex c = new Complex() { img = 2, real = 4 };
            //Console.WriteLine(c.ToString());

            //Employee em = new Employee() { id = 1, name = "ahmed", age = 20 };
            //Console.WriteLine(em.ToString());

            //equals

            //Employee em1= new Employee() { id = 1, name = "ali", age = 20 };
            //Employee em2 = new Employee() { id = 1, name = "ali", age = 20 };

            //if (em1.Equals(em2))

            //    Console.WriteLine("equal");

            //else
            //    Console.WriteLine("not equal");


            //Complex c1 = new Complex() { real = 1, img = 2 };
            //Complex c2 = new Complex() { real = 1, img = 2 };
            //if (c1.Equals(c2))

            //    Console.WriteLine("equal");

            //else
            //    Console.WriteLine("not equal");

            //gettype

            //  Employee emp = new Employee();
            //  Console.WriteLine(emp.GetType().BaseType);

            //Complex c = new Complex();
            //Console.WriteLine(c.GetType().BaseType.BaseType);

            //gethashcode

            Employee em = new Employee() { id = 2, name = "ali" };
            Employee em1 = new Employee() { id = 4, name = "ali" };
            em1 = em;
            Console.WriteLine(em.GetHashCode());
            Console.WriteLine(em1.GetHashCode());


        }
    }
}
