using Factory.Interfaces;

namespace Factory.Vehicles
{
	public class Car : IVehicle
	{
		public string Name => "Car";

		public int NumberOfAxles => 2;
	}
}
