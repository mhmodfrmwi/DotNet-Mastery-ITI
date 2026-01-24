namespace ConsoleApp2
{
    internal class Program
    {
        abstract class product
        {
            public string Name {  get; set; }
            public decimal Price { get; set; }
            public bool Warranty {  get; set; }
            public abstract void ApplyDiscount(decimal discount);
            public virtual void displayPrice()
            {
                Console.WriteLine($"the price = {Price}");
            }

            protected product(string name,decimal price,bool warranty)
            {
                this.Name = name;
                this.Price = price;
                this.Warranty = warranty;
            }
        }
        class Electronics : product
        {
            public Electronics(string name, decimal price, bool warranty) :base(name,price,warranty)
            {
                
            }
            public override void ApplyDiscount(decimal discount)
            {
                Console.WriteLine($"the price after discount = {Price-discount}");
            }
            public sealed override void displayPrice()
            {
                Console.WriteLine($"the price = {Price}");
            }
            public void CheckWarranty()
            {
                if (Warranty)
                {
                    
                Console.WriteLine($"found warranty");
                }
                else
                {
                    Console.WriteLine($"no warranty");
                }
            }
        }
        class Clothing : product
        {
            public Clothing(string name, decimal price, bool warranty):base(name, price, warranty)
            {
                
            }
            public override void ApplyDiscount(decimal discount)
            {
                Console.WriteLine($"the discounted price = {Price - discount}");
            }
        }
        class specialOfferProduct:product
        {
            public specialOfferProduct(string name, decimal price, bool warranty):base(name, price, warranty)
            {
                
            }
            public override void displayPrice()
            {
                Console.WriteLine($"the price = {Price}");
            }
            public override void ApplyDiscount(decimal discount)
            {
                
                Console.WriteLine($"the price = {(Price-discount)-10}");
            }
        }
        static void Main(string[] args)
        {
            product[] products = new product[]
            {
                new Electronics("pc",2000,true),
                new Clothing("t-shirt",200,false),
                new specialOfferProduct("labtop",1200,true)
            };
            for (int i = 0; i < products.Length; i++)
            {
                products[i].displayPrice();
                products[i].ApplyDiscount(20);
            }

        }
    }
}
