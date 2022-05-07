using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public interface IVehicle
    {
        void StopVehicle();
        void Accelerate(double targetSpeed);
        void SlowDown(double targetSpeed);
        string Name { get; }
        Environments actualEnv { get; }
    }
}
