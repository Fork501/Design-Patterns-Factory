# Factory Design Pattern
The Factory Design Pattern supplies a way to obtain a concrete class without specifically creating it each time.

Factories are a great way to demonstrate how Polymorphism works.  (Think: One object, many uses.)

At its core, the consumer of the factory will only know that they're receiving a certain type of object in response to their request.  The end result is that the consumer will obtain a concrete class, without explicitly creating one themselves.

This design pattern has many applications in Object-Oriented Programming and is common to find.

In this project's example, we're using vehicles to define if we want a "Car" or a "Semi Truck."  The consumer will create an instance of the factory, specify what type of factory it should be related to, then interrogate the factory for a copy of the generated object.  The IVehicle interface has properties for Name and NumberOfAxles, which will help to properly identify the type of vehicle that was created.

_Please feel free to make changes that correct errors_