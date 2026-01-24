namespace Lab7p2
{
    internal class Program
    {
        class Duration
        {
            public int Hours { get; set; }
            public int Minutes {  get; set; }
            public int Seconds { get; set; }
            public Duration() { }
            public Duration(int seconds)
            {
                this.Hours = seconds / 3600;
                this.Minutes = (seconds % 3600) / 60;
                this.Seconds = seconds % 60;
            }
            public Duration(int hours,int minutes,int seconds)
            {
                this.Hours = hours;
                this.Minutes = minutes;
                this.Seconds = seconds;
            }
            public override bool Equals(object? obj)
            {
                Duration duration = obj as Duration;
                return this.Hours == duration.Hours && duration.Minutes == this.Minutes && duration.Seconds == this.Seconds; 
            }
            public override int GetHashCode()
            {
                return Hours+Minutes+Seconds;
            }
            public override string ToString() {
                return $"Hours = {Hours} Minutes = {Minutes} Seconds = {Seconds}";
            }

            public static Duration operator +(Duration duration1, Duration duration2) {
                return new Duration(duration1.Hours + duration2.Hours, duration1.Minutes + duration2.Minutes, duration1.Seconds + duration2.Seconds);
            }
            public static Duration operator + (Duration duration,int seconds)
            {
                int hours = seconds / 3600;
                int minutes = (seconds % 3600) / 60;
                int second = seconds % 60;

                return new Duration(duration.Hours+hours, duration.Minutes + minutes, duration.Seconds+second);  
            }
            public static Duration operator +(int seconds, Duration duration)
            {
                int hours = seconds / 3600;
                int minutes = (seconds % 3600) / 60;
                int second = seconds % 60;

                return new Duration(duration.Hours + hours, duration.Minutes + minutes, duration.Seconds + second);
            }
            public static Duration operator ++(Duration d1)
            {
                d1.Minutes++;
                return d1;
            }
            public static Duration operator --(Duration d1)
            {
                d1.Minutes--;
                return d1;
            }
            public static Duration operator -(Duration d)
            {
                return new Duration(-d.Hours, -d.Minutes, -d.Seconds);
            }
            public static bool operator >(Duration d1, Duration d2) { 
                int d1InSeconds=d1.Seconds + d1.Minutes*60+d1.Hours*60*60;
                int d2InSeconds=d2.Seconds + d2.Minutes*60+d2.Hours*60*60;
                return d1InSeconds > d2InSeconds;
            }
            public static bool operator <(Duration d1, Duration d2)
            {
                int d1InSeconds = d1.Seconds + d1.Minutes * 60 + d1.Hours * 60 * 60;
                int d2InSeconds = d2.Seconds + d2.Minutes * 60 + d2.Hours * 60 * 60;
                return d1InSeconds > d2InSeconds;
            }
            public static bool operator <=(Duration d1, Duration d2)
            {
                int d1InSeconds = d1.Seconds + d1.Minutes * 60 + d1.Hours * 60 * 60;
                int d2InSeconds = d2.Seconds + d2.Minutes * 60 + d2.Hours * 60 * 60;
                return d1InSeconds <= d2InSeconds;
            }
            public static bool operator >=(Duration d1, Duration d2)
            {
                int d1InSeconds = d1.Seconds + d1.Minutes * 60 + d1.Hours * 60 * 60;
                int d2InSeconds = d2.Seconds + d2.Minutes * 60 + d2.Hours * 60 * 60;
                return d1InSeconds >= d2InSeconds;
            }
            public static bool operator true(Duration d1)
            {
                return d1.Seconds != 0||d1.Minutes!=0||d1.Hours!=0; 
            }
            public static bool operator false(Duration d1) { 
                return d1.Seconds == 0 && d1.Minutes==0&&d1.Hours==0;
            }
            public static explicit operator DateTime(Duration d)
            {
                return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day,
                                    d.Hours, d.Minutes, d.Seconds);
            }
        }
        static void Main(string[] args)
        {
            //Duration D1 = new Duration(1, 10, 15);
            //D1.ToString();
            Duration D1 = new Duration(3600);
            D1.ToString();
            Duration D2 = new Duration(7800);
            D2.ToString();
            Duration D3 = new Duration(666);
            D3.ToString();
            D3 = D1 + D2;
            Console.WriteLine(D1);
            D3 = D1 + 7800;
            Console.WriteLine(D3);
            D3 = 666 + D3;
            Console.WriteLine(D3);
            D3 = D1++;
            Console.WriteLine(D3);
            D3 = --D2;
            Console.WriteLine(D3);
            D1 = -D2;
            Console.WriteLine(D1);
            if (D1 > D2){
                Console.WriteLine("d1>d2");
            }
            if(D1 <= D2)
            {
                Console.WriteLine("d2>=d1");
            }
            if (D1)
            {
                Console.WriteLine(D1);
            }
            DateTime Obj = (DateTime)D2;
            Console.WriteLine(Obj);

        }
    }
}
