using Buisness.Concrete;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUserInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program Başlangıcı,test için console UI");
            CarManager carManager = new CarManager(new InMemoryCarDal());
            foreach (var car in carManager.GetCars())
            {
                Console.WriteLine(car.Description);

            }
        }
    }
}
