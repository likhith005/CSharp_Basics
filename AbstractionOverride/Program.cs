class Program{
    public static void Main(){
        // Animal animal = new Animal();
        Dog dog = new Dog();
        Cat cat = new Cat();

        // animal.speak();
        dog.speak();
        cat.speak(); 
    }
}

abstract class Animal{
    public abstract void speak();
}

// class Animal{
//     public virtual void speak(){
//         Console.WriteLine("The animal goes *brr*");
//     }
// }

class Dog : Animal{
    public override void speak(){
        Console.WriteLine("The dogs goes *bow*");
    }
}

class Cat : Dog{
    public override void speak(){
        Console.WriteLine("The cat goes *meow*");
    }
}