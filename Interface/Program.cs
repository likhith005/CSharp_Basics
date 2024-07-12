class Program{
    public static void Main(){
        Rabbit rabbit = new Rabbit();
        Hawk hawk = new Hawk();
        Fish fish = new Fish();

        rabbit.flee();
        hawk.hunt();
        fish.flee();
        fish.hunt();
    } 
}

interface IPrey{
    void flee();
}
interface IPredator{
    void hunt();
}
class Rabbit : IPrey{
    public void flee(){
        Console.WriteLine("The rabbit runs away!");
    }
}

class Hawk : IPredator{
    public void hunt(){
        Console.WriteLine("The hawk is searching for food!");
    }
}
class Fish : IPrey, IPredator{
    public void flee(){
        Console.WriteLine("The fish swims away!");
    }
    public void hunt(){
        Console.WriteLine("The fish is searching for small fish!");
    }
}