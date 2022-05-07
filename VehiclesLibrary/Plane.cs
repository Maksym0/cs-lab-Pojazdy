using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace VehiclesLibrary
{
    public class Plane : EnginePoweredVehicle, IVehicle, IDriveable, IFlyable
    {
        private readonly int _wheels;
        private MovingModule _MovingModule;
        public int Wheels => _wheels;
        public string Name => GetType().Name;
        public Plane(int horsePower, Engine.FuelType fuelType) : base(horsePower, fuelType)
        {
            AvailableEnvironments.Add(Environments.OnGround);
            AvailableEnvironments.Add(Environments.Flying);
            _wheels = 2;
            _MovingModule = new MovingModule(true, Wheels, true);
        }
        public void Accelerate(double targetSpeed)
        {
            _MovingModule.TryToAccelerate(ActualEnvironment, ref _state, ref MovingSpeed, targetSpeed, Name);
        }
        public void Fly()
        {
            _MovingModule.TryToFly(ref ActualEnvironment, _state, ref MovingSpeed, Name);
        }
        public void Land()
        {
            _MovingModule.TryToDrive(ref ActualEnvironment, _state, ref MovingSpeed, Name);
        }
        public void SlowDown(double targetSpeed)
        {
            _MovingModule.TryToSlowDown(ActualEnvironment, ref _state, ref MovingSpeed, targetSpeed, Name);
        }
        public void StopVehicle()
        {
            _MovingModule.StopMoving(ref _state, ActualEnvironment, ref MovingSpeed, Name);
        }
        public override string ToString()
        {
            return $"{Name}" + base.ToString() + $"\nWheels: {Wheels}\n";
        }
    }
}
