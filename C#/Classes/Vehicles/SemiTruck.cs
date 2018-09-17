using Factory.Interfaces;

namespace Factory.Vehicles
{
	public class SemiTruck : IVehicle
	{
		public string Name => "Semi Truck";

		public int NumberOfAxles => 4;
	}
}
