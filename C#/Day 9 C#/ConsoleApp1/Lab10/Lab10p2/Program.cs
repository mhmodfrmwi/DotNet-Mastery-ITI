//using static System.Net.Mime.MediaTypeNames;
//using static System.Runtime.InteropServices.JavaScript.JSType;

//namespace Lab10p2
//{
//    internal class Program
//    {
//        class Question
//        {
//            string text;
//            int marks;
//            public Question(string text,int marks)
//            {
//                this.text = text;
//                this.marks = marks;
//            }
//            public override int GetHashCode()
//            {
//                return HashCode.Combine(text, marks);
//            }
//            public override bool Equals(object? obj)
//            {
//                Question q=obj as Question;
//                return text==q.text && marks==q.marks;
//            }
//            public override string ToString() { 
//                return $"{text} - {marks}\n";
//            }
//        }
//        class Choice
//        {
//            string value;
//            bool isCorrect;
//            public Choice(string value, bool isCorrect)
//            {
//                this.value = value;
//                this.isCorrect = isCorrect;
//            }
//            public override string ToString()
//            {
//                return $"{value} - {isCorrect} " ;
//            }
//        }
//        class QuestionList : List<Question> {
//            public void Add(string text,int marks) {
//                Question q=new Question(text,marks);
//                base.Add(q);

//                File.AppendAllText("D:\\ITI\\data\\C#\\Diagrams\\Day 9 C#\\ConsoleApp1\\Lab10\\Lab10p2\\file.txt", q.ToString());

//             }
//            public override string ToString()
//            {
//                string s = "";
//                foreach (Question q in this) { 
//                    s += q.ToString();

//                }
//                return s;
//            }
//        }
//        static void Main(string[] args)
//        {
//            Dictionary<Question,List<Choice>>d=new Dictionary<Question,List<Choice>>();
//            d.Add(new Question("what is c#", 10), new List<Choice>(4)
//            {
//                new Choice("Language",true),
//                new Choice("machine",false),
//                new Choice("sport",false),
//                new Choice("halawaaa",false),
//            });
//            d.Add(new Question("Which of the following is a Reference Type in C#?", 5), new List<Choice>(4)
//            {
//                new Choice("int", false),
//                new Choice("class", true),
//                new Choice("struct", false),
//                new Choice("bool", false),
//            });
//            d.Add(new Question("Which symbol is used for inheritance in C#?", 5), new List<Choice>(4)
//            {
//                new Choice("extends", false),
//                new Choice(":", true),
//                new Choice("=>", false),
//                new Choice("::", false),
//            });

//            foreach (var item in d) {

//                Console.WriteLine(item.Key);
//                foreach (var choice in item.Value) {
//                    Console.WriteLine(choice);
//                }
//            }

//            QuestionList questions = new QuestionList();
//            questions.Add("what is c#", 15);
//            questions.Add("what is html", 15);
//            questions.Add("what is css", 15);
//            questions.ToString();
//        }
//    }
//}


using System.Text; 

namespace Lab10p2
{
    internal class Program
    {
        class Question
        {
            public string Text { get; set; }
            public int Marks { get; set; }

            public Question(string text, int marks)
            {
                Text = text;
                Marks = marks;
            }

            public override int GetHashCode()
            {
                return HashCode.Combine(Text, Marks);
            }

            public override bool Equals(object? obj)
            {
                if (obj is Question q)
                {
                    return Text == q.Text && Marks == q.Marks;
                }
                return false;
            }

            public override string ToString()
            {
                return $"{Text} - {Marks}\n";
            }
        }

        class Choice
        {
            public string Value { get; set; }
            public bool IsCorrect { get; set; }

            public Choice(string value, bool isCorrect)
            {
                Value = value;
                IsCorrect = isCorrect;
            }

            public override string ToString()
            {
                return $"{Value} - {IsCorrect} ";
            }
        }

        class QuestionList : List<Question>
        {
            public void Add(string text, int marks)
            {
                Question q = new Question(text, marks);
                base.Add(q);

               
            }

            public void SaveLogToFile(string filePath)
            {
                StringBuilder sb = new StringBuilder();
                foreach (var q in this)
                {
                    sb.Append(q.ToString());
                }

                File.   (filePath, sb.ToString());
            }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                foreach (Question q in this)
                {
                    sb.Append(q.ToString());
                }
                return sb.ToString();
            }
        }

        static void Main(string[] args)
        {
            Dictionary<Question, List<Choice>> d = new Dictionary<Question, List<Choice>>();

            d.Add(new Question("what is c#", 10), new List<Choice>(4)
            {
                new Choice("Language", true),
                new Choice("machine", false),
                new Choice("sport", false),
                new Choice("halawaaa", false),
            });

            foreach (var item in d)
            {
                Console.WriteLine(item.Key); 
                foreach (var choice in item.Value)
                {
                    Console.WriteLine("   " + choice); 
                }
                Console.WriteLine();
            }

            QuestionList questions = new QuestionList();
            questions.Add("what is c#", 15);
            questions.Add("what is html", 15);
            questions.Add("what is css", 15);

           
            questions.SaveLogToFile("log.txt");

            Console.WriteLine("--- From QuestionList ---");
            Console.WriteLine(questions.ToString());
        }
    }
}