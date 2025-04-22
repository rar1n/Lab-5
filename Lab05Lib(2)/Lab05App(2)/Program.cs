using Lab05Lib_2_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lab05App_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car[] arrCars;

            Console.Write("Введiть кiлькiсть автомобiлiв: ");
            int cntCars = int.Parse(Console.ReadLine());
            arrCars = new Car[cntCars];

            for (int i = 0; i < cntCars; i++)
            {
                Console.Write("Введiть марку автомобiля: ");
                string sBrand = Console.ReadLine();
                Console.Write("Введiть модель автомобiля: ");
                string sModel = Console.ReadLine();
                Console.Write("Введiть рiк випуску автомобiля: ");
                string sYear = Console.ReadLine();
                Console.Write("Введiть обем двигуна автомобiля: ");
                string sVEngine = Console.ReadLine();
                Console.Write("Введiть тип пального: ");
                string sTypeFuel = Console.ReadLine();
                Console.Write("Введiть пробiг: ");
                string sProbig = Console.ReadLine();
                Console.Write("Введiть середню витрату пального (л/100км): ");
                string sSerednyaVitrataFuel = Console.ReadLine();
                Console.Write("Введiть цiну автомобiля: ");
                string sPrice = Console.ReadLine();
                Console.Write("Введiть цiну пального: ");
                string sFuelPrice = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine();

                Car theCar = new Car();
                theCar.Brand = sBrand;
                theCar.Model = sModel;
                theCar.Year = int.Parse(sYear);
                theCar.VEngine = double.Parse(sVEngine);
                theCar.TypeFuel = sTypeFuel;
                theCar.Probig = int.Parse(sProbig);
                theCar.SerednyaVitrataFuel = double.Parse(sSerednyaVitrataFuel);
                theCar.Price = double.Parse(sPrice);
                theCar.FuelPrice = double.Parse(sFuelPrice);
                

                arrCars[i] = theCar;
            }
            foreach (Car c in arrCars)
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Данi про автомобiль {0}", c.Brand + " " + c.Model);
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Марка: " + c.Brand);
                Console.WriteLine("Модель: " + c.Model);
                Console.WriteLine("Рiк випуску: " + c.Year.ToString());
                Console.WriteLine("Обем двигуна: " + c.VEngine.ToString());
                Console.WriteLine("Тип пального: " + c.TypeFuel);
                Console.WriteLine("Пробiг: " + c.Probig.ToString());
                Console.WriteLine("Середня витрата пального (л/100км): " + c.SerednyaVitrataFuel.ToString());
                Console.WriteLine("Цiна автомобiля: " + c.Price.ToString());
                Console.WriteLine("Цiна пального: " + c.FuelPrice.ToString());
                Console.WriteLine("Ціна пального на 100 км: " + c.FuelPricePer100Km.ToString("0.00"));

            }
            Console.ReadKey();

        }
    }
}
