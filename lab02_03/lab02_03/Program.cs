using System;

namespace lab02_03
{ 
    public struct Distance
    {
        public int feet;
        public int inches;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Distance a;
            Distance b;
            Distance c;
            Console.Write("Enter feet: ");
            a.feet = int.Parse(Console.ReadLine());
            Console.Write("Enter inches: ");
            a.inches = int.Parse(Console.ReadLine());
            Console.Write("Enter feet: ");
            b.feet = int.Parse(Console.ReadLine());
            Console.Write("Enter inches: ");
            b.inches = int.Parse(Console.ReadLine());
            c.feet = a.feet + b.feet;
            c.inches = a.inches + b.inches;
            c.feet = c.feet + c.inches / 12;
            c.inches = c.inches % 12;
            Console.WriteLine($"{c.feet} '-{c.inches}''."); 
        }
    }
}
