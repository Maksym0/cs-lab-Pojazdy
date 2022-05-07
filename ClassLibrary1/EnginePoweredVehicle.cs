using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class EnginePoweredVehicle : Vehicle
    {
        protected readonly Engine _engine;
        public EnginePoweredVehicle(int horsePower, Engine.FuelType fuelType)
        {
            _engine = new Engine(horsePower, fuelType);
        }
        public string GetEngineInfo() => _engine.ToString();
        public override string ToString()
        {
            return base.ToString() + GetEngineInfo();
        }
    }
}
