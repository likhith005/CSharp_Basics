// class Car{
//     public string color;
//     public string brand;
//     public string name;
//     public int age;

//     public Car(string color, string brand){
//         this.color = color;
//         this.brand = brand;
//     }

//     public Car(string name, int age){
//         this.name = name;
//         this.age = age;
//     }

//     public void details(){
//         Console.WriteLine($"name:{this.name} age: {this.age}");
//     }

//     public static void Main(){
//         Car car = new Car("Red", "Mesareti");
//         Console.WriteLine($"My car color: {car.color} and brand: {car.brand}");

//         Car car1 = new Car("Raju", 1000);
//         car1.details();
//     }
// }

class Program{
    public static void Main(){
        Car car = new Car("Ford","Mustang", 2022, "red");
        car.display();

        //to invoke toString object
        Console.WriteLine(car.ToString());

        Car car2 = new Car("Chevrolet", "Camaro");
        car2.display();
        Console.WriteLine(car2.ToString());
    }
}

class Car{
    string brand;
    string model;
    int year;
    string color;

    public Car(string brand, string model, int year, string color){
        this.brand = brand;
        this.model = model;
        this.year = year;
        this.color = color;
    }

    public Car(string brand, string model){
        this.brand = brand;
        this.model = model;
    }

    public void display(){
        Console.WriteLine($"You drive the {this.brand} {this.model} {this.year}");
    }

    public override string ToString()
    {
        return $"This is a {this.model} from {this.year}, and it's {this.color}";
    }
} 