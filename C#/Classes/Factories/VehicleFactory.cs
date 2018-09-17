using Factory.Enums;
using Factory.Interfaces;
using Factory.Vehicles;
using System;

namespace Factory.Factories
{
	public class VehicleFactory
	{
		Vehicle _vehicle;
		public void SetVehicleType(Vehicle vehicle)
		{
			_vehicle = vehicle;
		}

		public IVehicle GetVehicle()
		{
			switch (_vehicle)
			{
				case Vehicle.Car:
					return new Car();
				case Vehicle.SemiTruck:
					return new SemiTruck();
				default:
					throw new Exception("Unsupported Vehicle Specified");
			}
		}
	}
}
