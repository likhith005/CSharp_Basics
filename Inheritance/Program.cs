class Vehicle{
    public int speed = 0;
    public void go(){
        Console.WriteLine("This vechile is moving!");
    }
}

class Car : Vehicle{
    public int wheels = 4;
}

class Bicycle : Car{
    public int wheels = 2;
}

class Boat : Bicycle{
    public int wheels = 0;
}

class Program{
    public static void Main(){
        Car car = new Car();
        car.go();
        Console.WriteLine(car.speed);
        Console.WriteLine(car.wheels);

        Bicycle bicycle = new Bicycle();
        bicycle.go();
        Console.WriteLine(bicycle.speed);
        Console.WriteLine(bicycle.wheels);

        Boat boat = new Boat();
        boat.go();
        Console.WriteLine(boat.speed);
        Console.WriteLine(boat.wheels);
    } 
}