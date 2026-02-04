namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            var query1 = numbers.Distinct().OrderBy(n => n);
            //foreach (var item in query1)
            //{
            //    Console.WriteLine(item);
            //}
            var query2 = numbers.Distinct().Select(n=>n*n).OrderBy(n => n);
            //foreach(var item in query2)
            //{
            //    Console.WriteLine(item);
            //}

            string[] names = { "Tom", "Dick", "Harry", "MARY", "Jay" };
            var query3 = names.Where(name => name.Length == 3).Select(name => name);
            //foreach (var name in query3)
            //{
            //    Console.WriteLine(name);
            //}
            var query4=names.Select(name=>name.ToLower()).Where(name=>name.Contains('a')).OrderBy(name=>name.Length);
            //foreach(var name in query4)
            //{
            //    Console.WriteLine(name);
            //}

            var query5 = names.Take(2);
            foreach(var name in
                query5)
            {
                Console.WriteLine(name);
            }
        }
    }
}
