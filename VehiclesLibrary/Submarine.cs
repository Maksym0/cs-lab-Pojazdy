using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace VehiclesLibrary
{
    public class Submarine : EnginePoweredVehicle, IVehicle, ISailable
    {
        private readonly int _displacement;
        private MovingModule _MovingModule;
        public string Name => GetType().Name;
        public int Displacement => _displacement;
        public Submarine(int horsePower, int displacement) : base(horsePower, Engine.FuelType.Diesel)
        {
            ActualEnvironment = Environments.Sailing;
            AvailableEnvironments.Add(Environments.Sailing);
            _displacement = displacement;
            _MovingModule = new MovingModule(displacement, true);
        }

        public void Accelerate(double targetSpeed)
        {
            _MovingModule.TryToAccelerate(ActualEnvironment, ref _state, ref MovingSpeed, targetSpeed, Name);
        }

        public void LeaveWater()
        {
            Console.WriteLine($"{Name} can not leave water environment.");
        }

        public void Sail()
        {
            Console.WriteLine($"{Name} is already sailing.");
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
            return $"{Name}" + base.ToString() + $"\nDisplacement: {Displacement}\n";
        }
    }
}
