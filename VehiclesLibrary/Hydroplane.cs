using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace VehiclesLibrary
{
    public class Hydroplane : EnginePoweredVehicle, IVehicle, IFlyable, IWaterLandable, IDriveable
    {
        private readonly int _displacement;
        private readonly int _wheels;

        private MovingModule _MovingModule;
        public string Name => GetType().Name;
        public int Displacement => _displacement;
        public int Wheels => _wheels;

        public Hydroplane(int horsePower, Engine.FuelType fuelType, int displacement) : base(horsePower, fuelType)
        {
            ActualEnvironment = Environments.OnGround;
            AvailableEnvironments.Add(Environments.OnGround);
            AvailableEnvironments.Add(Environments.Sailing);
            AvailableEnvironments.Add(Environments.Flying);
            _MovingModule = new MovingModule(true, true, displacement);
            _wheels = 2;
            _displacement = displacement;
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
            if (_state == State.Staying)
                Console.WriteLine($"{Name} is not moving.");
            else if (ActualEnvironment == Environments.Sailing)
                Console.WriteLine($"{Name} is not flying.");
            else
                Console.WriteLine($"{Name} can not land on the ground.");
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
            return $"{Name}" + base.ToString() + "\n";
        }

        public void LandOnWater()
        {
            _MovingModule.TryToSail(ref ActualEnvironment, _state, ref MovingSpeed, Name);
        }
    }
}
