namespace Lab4
{
    internal class Program
    {
        class Duration {

            public int Hours { get; set; }
            public int Minutes { get; set; }
            public int Seconds { get; set; }
            public Duration() { }
            public Duration(int seconds) {
                int hour = seconds / 3600;
                int minute = (seconds % 3600) / 60;
                int second = seconds % 60;
                Hours = hour;
                Minutes = minute;
                Seconds = second;
            }
            public Duration(int hours,int minutes,int seconds) {
                Hours = hours;
                Minutes = minutes;
                Seconds = seconds;
            }
            public override string ToString()
            {
                if (Hours == 0)
                    return $"Minutes:{Minutes}, Seconds: {Seconds}";
                return $"Hours : {Hours} Minutes : {Minutes} Seconds : {Seconds}";
            }
            public override bool Equals(object? obj)
            {
                Duration duration= (Duration)obj;

                return Hours==duration.Hours&&Minutes==duration.Minutes&&Seconds==duration.Seconds;
            }
            public override int GetHashCode()
            {
                return Hours + Minutes + Seconds;
            }
        };
        static void Main(string[] args)
        {
            //Duration D1 = new Duration(1, 10, 15);
            //Duration D1 = new Duration(3600);
            //Duration D1 = new Duration(7800);
            //Duration D1 = new Duration(666);

            //Console.WriteLine( D1.ToString());


            Duration[] arr = new Duration[3];
            int hours = 0;
            int minutes = 40;
            int seconds = 30;
            for (int i = 0; i < 3; i++)
            {
                arr[i] = new Duration();
                arr[i].Hours=hours++;
                arr[i].Minutes=minutes++;
                arr[i].Seconds=seconds++;
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(arr[i].ToString());     
            }
        }
    }
}
