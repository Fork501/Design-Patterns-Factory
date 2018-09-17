from abc import abstractproperty


class Vehicle:

    def __init__(self):
        pass

    @abstractproperty
    def name(self):
        pass

    @abstractproperty
    def number_of_axles(self):
        pass


class Car(Vehicle):

    @property
    def name(self):
        return "Car"

    @property
    def number_of_axles(self):
        return 2


class SemiTruck(Vehicle):

    @property
    def name(self):
        return "Semi Truck"

    @property
    def number_of_axles(self):
        return 4
