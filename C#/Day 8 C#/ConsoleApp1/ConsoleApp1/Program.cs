namespace ConsoleApp1
{
    internal class Program
    {
        abstract class Vehicle
        {
            public string Name { get; set; }
            public void stoppingEngine()
            {
                Console.WriteLine($"{Name} engine stopped");
            }
            public abstract void starttingEngine();
        }
        class Car : Vehicle
        {
            public override void starttingEngine()
            {
                Console.WriteLine($"{Name} car started");
            }
        }
        class Motorcycle : Vehicle
        {
            public override void starttingEngine()
            {
                Console.WriteLine($"{Name} motorcycle started");
            }
        }
        static void Main(string[] args)
        {
            Vehicle[] arr=new Vehicle[2] {new Car(),new Motorcycle() };
            arr[0].Name = "Car1";
            arr[1].Name = "MCycle1";

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i].starttingEngine();
                arr[i].stoppingEngine();
            }
        }
    }
}
