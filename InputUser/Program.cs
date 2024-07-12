class InputUser{
    public static void Main(){
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        Console.WriteLine("What is your age?");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hi " + name);
        Console.WriteLine("Great {0}",name);
        Console.WriteLine("Age: {0}",age);
    }
}