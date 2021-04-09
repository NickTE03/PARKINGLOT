using System;

namespace PARKINGLOT
{
    class Program
    {
        static void Main(string[] args)
        {
            PARKINGLOT PARKINGSPOT1 = new PARKINGLOT(1, 1, 1);
            Console.WriteLine(PARKINGSPOT1.AddCar("Large"));
            Console.WriteLine(PARKINGSPOT1.AddCar("Large"));
            Console.WriteLine(PARKINGSPOT1.AddCar("Medium"));
            Console.WriteLine(PARKINGSPOT1.AddCar("Small"));
            Console.WriteLine(PARKINGSPOT1.AddCar("Small"));
        }
    }
}
