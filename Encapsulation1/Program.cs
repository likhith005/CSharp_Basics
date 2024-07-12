class Program{
    public static void Main(){
        Car car = new Car(400);
        car.Speed = 1000000000;
        Console.WriteLine(car.Speed);
    }
}
class Car{
    private int speed;

    public Car(int speed)
    {
        Speed = speed;
    }

    //propertie
    public int Speed
    {
        get{return speed;}
        set{
            if(value>500)
            {
                speed = 500;
            }else{ 
                speed = value;
            }
        }
    }
}