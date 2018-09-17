/*
	The Factory Design Pattern supplies a way to obtain a concrete class without specifically creating it each time.
	In this example, we use a factory to generate different types of vehicles, based on what we tell it to create.
 */

using Factory.Factories;
using Factory.Enums;
using System;
using Factory.Interfaces;

namespace Factory
{
	class Program
	{
		static void Main(string[] args)
		{
			var factory = new VehicleFactory();

			IVehicle vehicle;

			factory.SetVehicleType(Vehicle.Car);

			vehicle = factory.GetVehicle();

			WriteVehicleInfo(vehicle);

			factory.SetVehicleType(Vehicle.SemiTruck);

			vehicle = factory.GetVehicle();

			WriteVehicleInfo(vehicle);

			Console.ReadLine();
		}

		static void WriteVehicleInfo(IVehicle vehicle)
		{
			Console.WriteLine($"The {vehicle.Name} has {vehicle.NumberOfAxles} axles");
		}
	}
}
