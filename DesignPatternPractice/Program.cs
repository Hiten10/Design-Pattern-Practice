using AbstractFactoryPattern;
using DecoratorPattern;
using FactoryPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            DecoratorExample();
            Console.ReadKey();
            //IVehicleFactory vehicleFactory = new HeroFactory();
            //IBike bike = vehicleFactory.CreateBikes<RegularBike>();
            //bike.Name();
        }

        /// <summary>
        /// Factory example with and without static object creator 
        /// </summary>
        static void FactoryExample()
        {
            VehicleFactory factory = new ConcereteVehicleFactory();
            IFactory scooter = factory.CreateVehicle<Scooter>();
            scooter.Drive(45);

            IFactory bike = factory.CreateVehicle<Bike>();
            bike.Drive(60);

            IFactory scooter1 = CreateVehicles.CreateVehicle<Scooter>();
            scooter1.Drive(45);

            IFactory bike1 = CreateVehicles.CreateVehicle<Bike>();
            bike1.Drive(70);
        }

        static void DecoratorExample()
        {
            List<Product> products = new List<Product>
            {
                new Product {Name = "Phone", Price = 587},
                new Product {Name = "Tablet", Price = 800},
                new Product {Name = "PC", Price = 1200}
            };
            var regularOrder = new RegularOrder();
            Console.WriteLine(regularOrder.CalculateTotalOrderPrice(products));
            Console.WriteLine();

            var preOrder = new Preorder();
            Console.WriteLine(preOrder.CalculateTotalOrderPrice(products));
            Console.WriteLine();

            var premiumPreorder = new PremiumPreorder(preOrder);
            Console.WriteLine(premiumPreorder.CalculateTotalOrderPrice(products));
        }
    }
}
