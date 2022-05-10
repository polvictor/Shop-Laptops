using System;

namespace Shops_Laptops
{
    class Laptop
    {
        string name;
        string producer;
        float price;
        
        public Laptop(string name, string producer, float price)
        {
            this.name = name;
            this.producer = producer;
            this.price = price;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public string Producer
        {
            get { return producer; }
            set { producer = value; }

        }
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value > 0)
                    price = value;
                else
                    price = 0;
            }
        }
        public Laptop() : this("Swift 3", "Acer", 25400) { }
        public void ShowInfo()
        {
            Console.WriteLine("Laptop: ");
            Console.WriteLine("Model: " + this.Name);
            Console.WriteLine("Producer: " + this.Producer);
            Console.WriteLine("Price: " + this.Price);
            
        }

    }
    class Shop
    {
        string shop_name;
        Laptop[] arr;

        public Shop(string shop_name)
        {
            this.shop_name = shop_name;
        }
        public Shop() : this("Green Laptops") { }
        public int ArrSize
        {
            get
            {
                return arr.Length;
            }
        }

        public Shop(params Laptop[] name)
        {
            arr = new Laptop[name.Length];
            for (int i = 0; i < name.Length; i++)
            {
                arr[i] = name[i];
            }
        }

        public Shop(int size)
        {
            arr = new Laptop[size];
        }

        public Laptop this[int index]
        {
            get
            {
                if (index >= 0 && index < arr.Length)
                {
                    return arr[index];
                }
                else
                {
                    return arr[0];
                }
            }
            set
            {
                arr[index] = value;
            }

        }
        static void Main(string[] args)
        {
            Laptop obj = new Laptop("Swift 3", "Acer", 25400);
            Laptop obj1 = new Laptop("Aspire 7", "Acer", 26999);
            Laptop obj2 = new Laptop("VivoBook 15", "ASUS", 22999);
            Laptop obj3 = new Laptop("TUF Gaming F15", "ASUS", 44999);

            Shop s = new Shop(obj, obj1, obj2, obj3);
            s.shop_name = "Green Laptops";
            Console.WriteLine("Shop name: " + s.shop_name + "\n");
            Console.WriteLine("\n We propose next Notebooks: ");
            for (int i = 0; i < s.ArrSize; i++)
                Console.Write("Name: " + s[i].Name + "  Producer: " + s[i].Producer + "  Price: " + s[i].Price + " grn.\n");
            Console.WriteLine();
        }
    }
}