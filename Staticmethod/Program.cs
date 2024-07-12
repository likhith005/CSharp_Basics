class Program{
    public static void Main(){
        Car car1 = new Car("Mustang");
        Car car2 = new Car("Corvette");

        // Console.WriteLine(car1.numOfCars);
        // Console.WriteLine(car2.numOfCars);
        Console.WriteLine(Car.numOfCars);
        Car.startRace();
    }
}

class Car{
    public string model;
    // public int numOfCars;
    public static int numOfCars;

    public Car(string model){
        this.model = model;
        numOfCars++;
    }

    public static void startRace(){
        Console.WriteLine("The race has begun!");
    }
} 