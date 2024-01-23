using System;

namespace methodsParameterChallenge 
{
    internal class Program
    {
        static void Main(string[] args)
        {
           String name, location, brand, color;
           int age, qty;
           double price;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your location: ");
            location = Console.ReadLine();

            Console.WriteLine("Enter your Car Brand: ");
            brand = Console.ReadLine();

            Console.WriteLine("Enter Quantity: ");
            qty = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Price: ");
            price = Convert.ToDouble(Console.ReadLine()); 

            Console.WriteLine("Enter color: ");
            color = Console.ReadLine();

            clientInfo(name, age, location);
            carInfo(brand, qty, price, color);
            
        }

        public static void clientInfo(String name, int age, String location){
          Console.WriteLine("Name: " + name);
          Console.WriteLine("Age: " + age);
          Console.WriteLine("Location: " + location);  
        }

        public static void carInfo(String brand, int qty, double price, String color){
        Console.WriteLine("Car Brand: " + brand);
        Console.WriteLine("Quantity: " + qty);
        Console.WriteLine("Price: " + price);
        Console.WriteLine("Car Color: " + color);
        }
    }
}
