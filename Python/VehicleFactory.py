from Vehicles import Car, SemiTruck
from Vehicle import Vehicle


class VehicleFactory:
    def __init__(self):
        self.vehicle = None
        pass

    def set_vehicle_type(self, vehicle):
        self.vehicle = vehicle

    def get_vehicle(self):
        if self.vehicle == Vehicle.CAR:
            return Car()
        elif self.vehicle == Vehicle.SEMI_TRUCK:
            return SemiTruck()
        else:
            raise Exception("Unsupported Vehicle Specified")
