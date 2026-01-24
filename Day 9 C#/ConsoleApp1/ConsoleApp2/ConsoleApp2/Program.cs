namespace ConsoleApp2
{
    internal class Program
    {
        class Point : IComparable<Point>,ICloneable
        {
            double x, y, z;
            public Point(double x, double y)
            {
                this.x = x;
                this.y = y;
                z = 0;
            }
            public Point(double x, double y, double z) : this(x, y)
            {
                this.z = z;
            }
            public override string ToString()
            {
                return $"X= {x} Y= {y} Z={z}\n";
            }
            public override bool Equals(object? obj)
            {
                Point point = obj as Point;
                return this.x == point.x && this.y == point.y && this.z == point.z;
            }
            

            public void Deconstruct(out double x, out double y, out double z)
            {
                x = this.x;
                y = this.y;
                z = this.z;
            }

            public int CompareTo(Point? other)
            {
                if (x==other.x)
                {
                    return y.CompareTo(other.y);
                }
                return x.CompareTo(other.x);
            }

            public object Clone()
            {
                return new Point(x,y, z);
            }
        }
        record point3d (int x,int y,int z)
        {
            public int X { 
                set
                {
                    X = x;
                }
                get
                {
                    return X; 
                }
            }
            public int Y
            {
                set
                {
                    Y = y;
                }
                get {
                    return Y;
                }
            }
            public int Z
            {
                set
                {
                    Z = z;
                }
                get
                {
                    return Z;
                }
            }
        }
        static void Main(string[] args)
        {
            ////Point p1 = new Point(10, 10, 10);
            ////Console.WriteLine(p1.ToString());

            //Console.WriteLine("enter x for p1");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter y for p1");
            //double y1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter z for p1");
            //double z1 = double.Parse(Console.ReadLine());

            //Point p1 = new Point(x1, y1, z1);

            //Console.WriteLine("enter x for p2");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter y for p2");
            //double y2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("enter z for p2");
            //double z2 = double.Parse(Console.ReadLine());

            //Point p2 = new Point(x2, y2, z2);
            //if (p1.Equals(p2))
            //{
            //    Console.WriteLine("equal");

            //}
            //else
            //{
            //    Console.WriteLine("not equals");
            //}

            //var (x, y, z) = p1;
            Point p1 = new Point(3, 4, 5);
            Point[] arr = new Point[3]
            {
                new Point(2,3),
                new Point(4,5),
                new Point(1,2),
            };
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            Point p5=p1.Clone() as Point;

        }
    }
}
