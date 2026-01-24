//namespace Lab10
//{
//    internal class Program
//    {
//        class Queue
//        {
//            int[] arr;
//            int top;
//            int counter;
//            public Queue()
//            {
//                arr = new int[10];
//                top = 0;
//                counter = 0;
//            }
//            public void inqueue(int val)
//            {
//                if (top < arr.Length)
//                {
//                    arr[top++] = val;
//                }
//                else
//                {
//                    throw new ArgumentOutOfRangeException();
//                }
//                counter++;
//            }
//            public int outqueue()
//            {
//                int val = arr[0];
//                for (int i = 0; i < top; i++)
//                {
//                    arr[i] = arr[i + 1];
//                }
//                counter--;
//                top--;
//                return val;
//            }
//            public bool isEmpty()
//            {
//                return counter == 0;
//            }
//            public bool isFull()
//            {
//                return arr.Length == counter;
//            }
//            public void print()
//            {
//                for (int i = 0; i < top; i++)
//                {
//                    Console.WriteLine(arr[i]);
//                }
//            }
//            static void Main(string[] args)
//            {
//                Queue queue = new Queue();
//                queue.inqueue(1);
//                queue.inqueue(2);
//                queue.inqueue(3);
//                queue.print();
//                Console.WriteLine($"deleted value = {queue.outqueue()}"); 
//                queue.print();
//            }
//        }
//    }
//}



namespace Lab10
{
    internal class Program
    {
        class Queue
        {
            int[] arr;
            int tail;

            int count;

            public Queue(int size) 
            {
                arr = new int[size];
                tail = 0;
                count = 0;
            }

            public void Enqueue(int val) 
            {
                if (tail == arr.Length) 
                {
                    throw new Exception("Queue is Full!");
                }

                arr[tail] = val;
                tail++;
                count++;
            }

            public int Dequeue() 
            {
                if (IsEmpty())
                {
                    throw new Exception("Queue is Empty!");
                }

                int val = arr[0];

                
                for (int i = 0; i < tail - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                tail--;
                count--;
                return val;
            }

            public bool IsEmpty()
            {
                return count == 0;
            }

            public bool IsFull()
            {
                return count == arr.Length;
            }

            public void Print()
            {
                Console.WriteLine("--- Queue Content ---");
                if (IsEmpty())
                {
                    Console.WriteLine("Queue is empty.");
                    return;
                }

                for (int i = 0; i < tail; i++)
                {
                    Console.WriteLine(arr[i]);
                }
                Console.WriteLine("---------------------");
            }
        }

        static void Main(string[] args)
        {
            Queue queue = new Queue(5);

            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(30);

            queue.Print();

            Console.WriteLine($"Deleted value = {queue.Dequeue()}");

            queue.Print();
        }
    }
}