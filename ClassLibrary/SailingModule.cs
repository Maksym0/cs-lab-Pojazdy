using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    internal class SailingModule
    {
        internal readonly int _displacement;
        public static readonly int MaxSpeed = 40;
        public static readonly int MinSpeed = 0;
        public static readonly SpeedUnits SpeedUnit = SpeedUnits.Knots;

        internal SailingModule(int buoyancy)
        {
            _displacement = Displacement;
        }
        public int Displacement => _displacement;
    }
}
