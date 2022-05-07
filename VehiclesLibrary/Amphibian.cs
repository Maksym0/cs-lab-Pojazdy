using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace VehiclesLibrary
{
    public class Amphibian : EnginePoweredVehicle, IVehicle, ISailable, IDriveable
    {
        private readonly int _wheels;
        private readonly int _displacement;
        private MovingModule _MovingModule;
        public Amphibian(int horsePower, int displacement) : base(horsePower, Engine.FuelType.Diesel)
        {
            AvailableEnvironments.Add(Environments.OnGround);
            AvailableEnvironments.Add(Environments.Sailing);
            _wheels = 8;
            _displacement = displacement;
            _MovingModule = new MovingModule(true, Wheels, true, Displacement);
        }

        public int Displacement => _displacement;
        public int Wheels => _wheels;
        public string Name => GetType().Name;
        public void Accelerate(double targetSpeed)
        {
            _MovingModule.TryToAccelerate(ActualEnvironment, ref _state, ref MovingSpeed, targetSpeed, Name);
        }
        public void LeaveWater()
        {
            _MovingModule.TryToDrive(ref ActualEnvironment, _state, ref MovingSpeed, Name);
        }
        public void Sail()
        {
            _MovingModule.TryToSail(ref ActualEnvironment, _state, ref MovingSpeed, Name);
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
            return $"{Name}" + base.ToString() + $"\nWheels: {Wheels}\nDisplacement: {Displacement}\n";
        }
    }
}
