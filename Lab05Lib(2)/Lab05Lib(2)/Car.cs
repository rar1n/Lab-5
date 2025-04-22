using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05Lib_2_
{
    public class Car
    {
        public string Brand;
        public string Model;
        public int Year;
        public double VEngine;
        public string TypeFuel;
        public int Probig;
        public double SerednyaVitrataFuel;
        public double Price;
        public double FuelPrice;
        public double FuelPricePer100Km
        {
            get
            {
                return GetFuelPricePer100Km();
            }
        }
        public double GetFuelPricePer100Km()
        {
            return SerednyaVitrataFuel * FuelPrice;
        }
    }
}
