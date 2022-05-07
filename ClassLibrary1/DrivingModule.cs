using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    internal class DrivingModule
    {
        internal readonly int _wheelsCount;
        public static readonly int MinSpeed = 0;
        public static readonly int MaxSpeed = 350;
        public static readonly SpeedUnits SpeedUnit = SpeedUnits.KMpH;
        internal DrivingModule(int wheelsCount)
        {
            _wheelsCount = wheelsCount;
        }
        public int WheelsCount => _wheelsCount;
    }
}
