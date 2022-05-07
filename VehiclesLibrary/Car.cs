using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace VehiclesLibrary
{
    public class Car : EnginePoweredVehicle, IVehicle, IDriveable
    {
        private readonly int _wheels;
        private MovingModule _MovingModule;
        public Car(int horsePower, Engine.FuelType fuelType) : base(horsePower, fuelType)
        {
            AvailableEnvironments.Add(Environments.OnGround);
            _wheels = 4;
            _MovingModule = new MovingModule(true, Wheels);
        }
        public string Name => GetType().Name;
        public int Wheels => _wheels;
        public override string ToString()
        {
            return $"{Name}" + base.ToString() + $"\nWheels: {Wheels}\n";
        }
        public void Accelerate(double targetSpeed)
        {
            _MovingModule.TryToAccelerate(ActualEnvironment, ref _state, ref MovingSpeed, targetSpeed, Name);
        }

        public void SlowDown(double targetSpeed)
        {
            _MovingModule.TryToSlowDown(ActualEnvironment, ref _state, ref MovingSpeed, targetSpeed, Name);
        }

        public void StopVehicle()
        {
            _MovingModule.StopMoving(ref _state, ActualEnvironment, ref MovingSpeed, Name);
        }
    }
}
