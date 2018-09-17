from VehicleFactory import VehicleFactory
from Vehicle import Vehicle


def main():
    factory = VehicleFactory()

    factory.set_vehicle_type(Vehicle.CAR)

    vehicle = factory.get_vehicle()

    write_vehicle_info(vehicle)

    factory.set_vehicle_type(Vehicle.SEMI_TRUCK)

    vehicle = factory.get_vehicle()

    write_vehicle_info(vehicle)


def write_vehicle_info(vehicle):
    print 'The {0} has {1} axles'.format(vehicle.name, vehicle.number_of_axles)


if __name__ == '__main__':
    main()
