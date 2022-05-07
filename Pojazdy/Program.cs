using System;
using System.Collections.Generic;
using ClassLibrary1;
using System.Linq;
using VehiclesLibrary;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicleList = new List<Vehicle>();
            Car fiat = new Car(100, Engine.FuelType.Petrol);
            Amphibian amph = new Amphibian(200, 500);
            Plane cessna = new Plane(300, Engine.FuelType.Petrol);
            Hydroplane hydro = new Hydroplane(300, Engine.FuelType.Petrol, 100);
            Boat yacht = new Boat(10000, 20000);
            UFO ufo = new UFO();
            Bicycle bic = new Bicycle();
            Submarine sub = new Submarine(5000, 5000);
            Paraglider pgli = new Paraglider(5, Engine.FuelType.Petrol);

            vehicleList.Add(fiat);
            vehicleList.Add(amph);
            vehicleList.Add(cessna);
            vehicleList.Add(hydro);
            vehicleList.Add(yacht);
            vehicleList.Add(ufo);
            vehicleList.Add(bic);
            vehicleList.Add(sub);
            vehicleList.Add(pgli);
            
            foreach(var v in vehicleList)
                Console.WriteLine(v);
            Console.WriteLine("---Onground vehicles---\n");
            var groundVehicles = vehicleList.Where(vehicle => vehicle.actualEnv == Environments.OnGround);
            foreach(var v in groundVehicles)
                Console.WriteLine(v);
            Console.WriteLine("---By Speed ascending---\n");
            fiat.Accelerate(150);
            amph.Accelerate(100);
            amph.Sail();
            cessna.Accelerate(100);
            cessna.Fly();
            cessna.Accelerate(150);
            hydro.Accelerate(40);
            hydro.Fly();
            hydro.Accelerate(180);
            yacht.Accelerate(40);
            ufo.Accelerate(100);
            ufo.Fly();
            ufo.Accelerate(200);
            bic.Accelerate(50);
            sub.Accelerate(120);
            sub.Sail();
            pgli.Accelerate(130);
            pgli.Fly();

            Console.WriteLine();
            var bySpeedAsc = vehicleList.OrderBy(vehicle => Vehicle.UnitConverter(vehicle.ActualSpeed, vehicle.actualUnit, SpeedUnits.KMpH));
            foreach(var v in bySpeedAsc)
                Console.WriteLine(v);
            Console.WriteLine("---Onground vehicles orderder by speed descending---\n");
            var groundByDesc = vehicleList.Where(vehicle => vehicle.actualEnv == Environments.OnGround).OrderByDescending(vehicle => Vehicle.UnitConverter(vehicle.ActualSpeed, vehicle.actualUnit, SpeedUnits.KMpH));
            foreach (var v in groundByDesc)
                Console.WriteLine(v);

            //ground vehicle test 
            #region car
            //Car volvo = new Car(100, Engine.FuelType.Petrol);
            //Console.WriteLine(volvo.ToString());
            //volvo.Accelerate(100);
            //Console.WriteLine(volvo.ToString());
            //volvo.Accelerate(50);
            //Console.WriteLine(volvo.ToString());
            //volvo.Accelerate(351);
            //volvo.SlowDown(-100);
            //Console.WriteLine(volvo.ToString());
            //volvo.StopVehicle();
            //Console.WriteLine(volvo.ToString());
            #endregion
            //ground-water vehicle test
            #region amphibian
            //Amphibian amph = new Amphibian(200, 500);
            //Console.WriteLine(amph.ToString());
            //amph.Sail();
            //amph.Accelerate(50);
            //amph.Sail();
            //Console.WriteLine(amph.ToString());
            //amph.Accelerate(500);
            //amph.Accelerate(10);
            //Console.WriteLine(amph.ToString());
            //amph.StopVehicle();
            //Console.WriteLine(amph.ToString());
            //amph.LeaveWater();
            //amph.Accelerate(30);
            //Console.WriteLine(amph.ToString());
            //amph.LeaveWater();
            //Console.WriteLine(amph.ToString());
            //amph.StopVehicle();
            //Console.WriteLine(amph.ToString());
            #endregion
            // ground flying vehicle test
            #region plane
            //Plane cessna = new Plane(300, Engine.FuelType.Petrol);
            //Console.WriteLine(cessna.ToString());
            //cessna.Land();
            //cessna.StopVehicle();
            //cessna.Accelerate(300);
            //Console.WriteLine(cessna.ToString());
            //cessna.Fly();
            //cessna.Fly();
            //Console.WriteLine(cessna.ToString());
            //cessna.StopVehicle();
            //cessna.Land();
            //cessna.Accelerate(150);
            //Console.WriteLine(cessna.ToString());
            //cessna.SlowDown(19);
            //cessna.SlowDown(20);
            //cessna.Land();
            //Console.WriteLine(cessna.ToString());
            //cessna.StopVehicle();
            //Console.WriteLine(cessna.ToString());
            #endregion
            //water flying vehicle test
            #region hydroplane
            //Hydroplane hydro = new Hydroplane(300, Engine.FuelType.Petrol, 100);
            //Console.WriteLine(hydro);
            //hydro.Land();
            //hydro.Accelerate(50);
            //hydro.Accelerate(40);
            //Console.WriteLine(hydro);
            //hydro.Fly();
            //Console.WriteLine(hydro);
            //hydro.StopVehicle();
            //hydro.Accelerate(150);
            //hydro.Accelerate(50);
            //hydro.Accelerate(200);
            //hydro.Accelerate(250);
            //hydro.SlowDown(20);
            //Console.WriteLine(hydro);
            //hydro.LandOnWater();
            //Console.WriteLine(hydro);
            //hydro.StopVehicle();
            //Console.WriteLine(hydro);
            #endregion
            //water vehicle test
            #region boat
            //Boat titanic = new Boat(10000, 20000);
            //titanic.LeaveWater();
            //Console.WriteLine(titanic);
            //titanic.Sail();
            //titanic.Accelerate(10);
            //titanic.Accelerate(20);
            //titanic.Accelerate(45);
            //titanic.Accelerate(40);
            //titanic.SlowDown(-1);
            //titanic.SlowDown(5);
            //titanic.Accelerate(10);
            //Console.WriteLine(titanic);
            //titanic.StopVehicle();
            //Console.WriteLine(titanic);
            #endregion
            // multienv vehicle test
            #region multi
            //UFO ufo = new UFO();
            //Console.WriteLine(ufo);
            //ufo.Accelerate(300);
            //Console.WriteLine(ufo);
            //ufo.Sail();
            //ufo.SlowDown(40);
            //ufo.Sail();
            //Console.WriteLine(ufo);
            //ufo.SlowDown(40);
            //ufo.Fly();
            //Console.WriteLine(ufo);
            //ufo.Accelerate(100);
            //ufo.SlowDown(150);
            //ufo.StopVehicle();
            //ufo.Accelerate(20);
            //ufo.LandOnWater();
            //Console.WriteLine(ufo);
            //ufo.LeaveWater();
            //Console.WriteLine(ufo);
            //ufo.StopVehicle();
            //Console.WriteLine(ufo);
            #endregion
            // no engine ground vehicle test
            #region bicycle
            //Bicycle bic = new Bicycle();
            //Console.WriteLine(bic);
            //bic.StopVehicle();
            //bic.Accelerate(50);
            //Console.WriteLine(bic);
            //bic.StopVehicle();
            //Console.WriteLine(bic);
            #endregion
        }
    }
}
