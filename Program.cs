using System;

namespace ConsoleApp__car_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car BMW1 = new Car();
            BMW1.brand = "BMW";
            BMW1.price = "25000$";
            BMW1.speed = "220km/h";
            BMW1.color = "red";
            Console.WriteLine($"{BMW1.brand}, {BMW1.price}, {BMW1.speed}, {BMW1.color}");

            Car Mercedes1 = new Car();
            Mercedes1.brand = "Mercedes";
            Mercedes1.price = "50000$";
            Mercedes1.speed = "300km/h";
            Mercedes1.color = "black";
            Console.WriteLine($"{Mercedes1.brand}, {Mercedes1.price}, {Mercedes1.speed}, {Mercedes1.color}");

            //Console.WriteLine(BMW1.GetDetails());
            //Console.WriteLine(Mercedes1.GetDetails());
        }

    }
}
