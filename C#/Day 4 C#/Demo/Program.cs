namespace Day4PI
{
    #region  struct
    //struct ComplexNum
    //{
    //    #region  prop
    //    //int real;
    //    //public int Real
    //    //{
    //    //    set
    //    //    {
    //    //        if (value > 0) real = value;
    //    //        else throw new Exception("invalid real value");
    //    //    }
    //    //    get
    //    //    {
    //    //        return real;
    //    //    }
    //    //}
    //    //int img;
    //    //public int Img
    //    //{
    //    //    set { 
    //    //        img = value;
    //    //    }
    //    //    get {

    //    //        return img;
    //    //    }
    //    //}
    //    #endregion
    //    //public required int Img { init; get; } //automatic prop
    //    //public int Real { init; get; } //automatic prop
    //    public  int Img { set; get; } //automatic prop
    //    public int Real { set; get; } //automatic prop

    //    public ComplexNum()
    //    {
    //        Real = 1;
    //        Img = 1;
    //    }

    //    public ComplexNum(int _real, int _img)
    //    {
    //        Real = _real;
    //        Img = _img;
    //    }
    //    public ComplexNum(int _real)
    //    {
    //        Real = _real;
    //    }
    //    //header : public string getstring(int x)
    //    //signature :string(int)
    //    public string getstring()
    //    {
    //      return  $"{Real}+{Img}i";
    //    }


    //}
    #endregion
    #region  class

    class ComplexNum
    {
       
      
        public int Img { set; get; } //automatic prop
        public int Real { set; get; } //automatic prop

        public ComplexNum()
        {
            Real = 1;
            Img = 1;
        }

        public ComplexNum(int _real, int _img)
        {
            Real = _real;
            Img = _img;
        }
        public ComplexNum(int _real)
        {
            Real = _real;
        }
        //header : public string getstring(int x)
        //signature :string(int)
        public string getstring()
        {
            return $"{Real}+{Img}i";
        }

        ~ComplexNum()
        {
            Console.WriteLine("destractor");
        }

    }

    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            //ComplexNum c = new ComplexNum();
            //c.Real = 3;
            //c.Img = 2;
            //Console.WriteLine(c.getstring());

            #region object init
            //ComplexNum c = new ComplexNum() { Real = 3, Img = 4 };
            //ComplexNum c = new ComplexNum() { }
            // c.Real = 4;
            //c.Img = 3;


            // Console.WriteLine(c.getstring());

            // ComplexNum c = new ComplexNum() {  Img=3 };

            #endregion
            #region constractor 
            //ComplexNum c = new ComplexNum();
            //Console.WriteLine(c.getstring());
            //ComplexNum c1 = new ComplexNum(3, 4);
            //Console.WriteLine(c1.getstring());

            // ComplexNum c2 = new ComplexNum(3);
            //ComplexNum c2 = new ComplexNum();
            //Console.WriteLine(c2.getstring());
            #endregion
            #region class

          //  ComplexNum c= new ComplexNum();
           
            //ComplexNum c1 = new ();
           // c.Real = 4;

            // ComplexNum c1 = new ComplexNum();

            //ComplexNum c1 = new ComplexNum(2, 3);

            //ComplexNum c2 = new ComplexNum(2);
            #endregion
        }
    }
}
