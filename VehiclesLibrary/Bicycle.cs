using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1;

namespace VehiclesLibrary
{
    public class Bicycle : Vehicle, IVehicle, IDriveable
    {
        private readonly int _wheels;
        private MovingModule _MovingModule;
        public string Name => GetType().Name;
        public int Wheels => _wheels;
        public Bicycle()
        {
            _wheels = 2;
            _MovingModule = new MovingModule(true, Wheels);
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
        public override string ToString()
        {
            return $"{Name}" + base.ToString() + $"Wheels: {Wheels}\n";
        }
    }
}
