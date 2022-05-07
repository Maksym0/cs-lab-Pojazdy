using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public class Engine
    {
        public enum FuelType { Petrol, LPG, Electric, Diesel}
        private readonly int HorsePower;
        private readonly FuelType _fuelType;
        public Engine(int power, FuelType type)
        {
            HorsePower = power;
            _fuelType = type;
        }
        public override string ToString() => $"{_fuelType} powered engine, power: {HorsePower}hp";
    }
}
