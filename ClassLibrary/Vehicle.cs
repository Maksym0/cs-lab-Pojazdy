using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Vehicle
    {
        public enum State { Moving, Staying }

        protected double MovingSpeed;
        protected State _state = State.Staying;
        protected Environments ActualEnvironment;
        public Environments actualEnv => ActualEnvironment;
        public double ActualSpeed => MovingSpeed;
        public SpeedUnits actualUnit
        {
            get 
            {
                switch (actualEnv)
                {
                    case Environments.Flying:
                        return SpeedUnits.MpS;
                    case Environments.OnGround:
                        return SpeedUnits.KMpH;
                    case Environments.Sailing:
                        return SpeedUnits.Knots;
                    default:
                        return SpeedUnits.KMpH;
                } 
            }
        }
        protected List<Environments> AvailableEnvironments = new List<Environments>();
        public static double UnitConverter(double speed, SpeedUnits from, SpeedUnits to)
        {
            double val = 0;
            if (from == to)
                return speed;
            switch (from)
            {
                case SpeedUnits.KMpH:
                    if (to == SpeedUnits.MpS)
                        val = speed * 0.277;
                    else
                        val = speed * 0.539;
                    break;
                case SpeedUnits.MpS:
                    if (to == SpeedUnits.KMpH)
                        val = speed * 3.6;
                    else
                        val = speed * 1.943;
                        break;
                case SpeedUnits.Knots:
                    if (to == SpeedUnits.KMpH)
                        val = speed * 1.852;
                    else
                        val = speed * 0.514;
                    break;
            }
            return Math.Round(val, 2, MidpointRounding.AwayFromZero);
        }
        public override string ToString()
        {
            int min = 0;
            int max = 0;
            SpeedUnits? unit = null;
            switch (ActualEnvironment)
            {
                case Environments.OnGround:
                    min = DrivingModule.MinSpeed;
                    max = DrivingModule.MaxSpeed;
                    unit = SpeedUnits.KMpH;
                    break;
                case Environments.Flying:
                    min = FlyingModule.MinSpeed;
                    max = FlyingModule.MaxSpeed;
                    unit = SpeedUnits.MpS;
                    break;
                case Environments.Sailing:
                    min = SailingModule.MinSpeed;
                    max = SailingModule.MaxSpeed;
                    unit = SpeedUnits.Knots;
                    break;
            }
            string temp = string.Join(", ", AvailableEnvironments);
            return $"\nActual enviroment: {ActualEnvironment}\nActual state: {_state}\nActual speed: {MovingSpeed}{unit}\nAvailable environemnts: {temp}\nSpeed range avaiable in actual environment: {min}-{max}{unit}\n";
        }
    }
}
