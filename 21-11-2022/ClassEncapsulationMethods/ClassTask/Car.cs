using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    internal class Car
    {
        private double _fuelFor1Km; // 5 
        private double _currentFuel; // 50 -> 0
        public string Brand;
        public string Model;
        public double Millage; // 1000 -> 1010


        
        public double CurrentFuel 
        {
            get
            {
                return _currentFuel;
            }
            set
            {
                if(value > 0)
                {
                    this._currentFuel = value;
                }
            }
        }

        public double FuelFor1Km 
        {
            get
            {
                return _fuelFor1Km;
            }
            set
            {
                if(value > 0)
                {
                    this._fuelFor1Km = value;
                }
            }
        }



        #region Custom Encapsulation
        //public void CurrentFuelSetter(double fuelCapacity)
        //{
        //    if (fuelCapacity > 0)
        //    {
        //        this.CurrentFuel = fuelCapacity;
        //    }
        //}

        //public double CurrentFuelGetter()
        //{
        //    return this.CurrentFuel;
        //}


        //public void FuelFor1KmSetter(double fuel)
        //{
        //    if (fuel > 0)
        //    {
        //        this.FuelFor1Km = fuel;
        //    }
        //}

        //public double FuelFor1KmGetter()
        //{
        //    return this.FuelFor1Km;
        //}
        #endregion


        //public void Drive(int km) // 10
        //{
        //    if(km > 0 && CurrentFuel - FuelFor1Km * km >= 0)
        //    {
        //        CurrentFuel -= FuelFor1Km * km;
        //        Millage += km;
        //    }
        //    else
        //    {
        //        Console.WriteLine($"Not enough fuel for {km} km");
        //    }
        //}

        //public void ShowInfo()
        //{
        //    Console.WriteLine($"CurrentFuel: {CurrentFuel}\nFuelFor1Km: {FuelFor1Km}\nMillage: {Millage}");
        //}
    }
}
