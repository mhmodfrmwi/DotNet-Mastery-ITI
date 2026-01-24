namespace Lab11p1
{
    internal class Program
    {
        public delegate string BookDelegate(Book B);
        public class Book
        {
            public string ISBN { get; set; }
            public string Title { get; set; }
            public string[] Authors { get; set; }
            public DateTime PublicationDate { get; set; }
            public decimal Price { get; set; }
            public Book(string _ISBN, string _Title,
            string[] _Authors, DateTime _PublicationDate,
            decimal _Price)

            {
                this .ISBN = _ISBN;
                this .Title = _Title;
                this .Authors = _Authors;
                this .PublicationDate = _PublicationDate;
                this .Price = _Price;

            }
            public override string ToString() => $"title : {Title} price : {Price}";
        }
        public class BookFunctions
        {
            public static string GetTitle(Book B)
            {
                return B.Title;
            }
            public static string GetAuthors(Book B)
            {
                string s = "";
                if (B.Authors != null) {
                    for (int i = 0; i < B.Authors.Length; i++)
                    {
                        s += B.Authors[i];
                    }
                }
                return s; 
            }
            public static string GetPrice(Book B)
            {
                return B.Price.ToString();

            }
        }
        public class LibraryEngine
        {
            public static void ProcessBooks(List<Book> bList,/*Pointer To BookFunciton*/ BookDelegate fPtr)

            {
                foreach (Book B in bList)
                {
                    Console.WriteLine(fPtr(B));
                }
            }

            public static void ProcessBooks(List<Book> bList, Func<Book, string> fn)
            {
                foreach (Book B in bList)
                {
                    Console.WriteLine(fn(B));
                }
            }
        }
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book("1", "C#", new string[] { "Messi" }, new DateTime(2019, 3, 23), 500m),

                new Book("2", "Clean Code", new string[] { "nymar" }, new DateTime(2008, 8, 1), 450.5m),

                new Book("3", "Design Patterns", new string[] { "suarez" }, new DateTime(1994, 10, 21), 600m)
            };
            BookDelegate ptr = new BookDelegate(BookFunctions.GetTitle);
            LibraryEngine.ProcessBooks(books, ptr);

            Func<Book, string> funcPtr = BookFunctions.GetPrice;
            //LibraryEngine.ProcessBooks(books, funcPtr);

            LibraryEngine.ProcessBooks(books, book => book.ISBN);
        }
    }
}
