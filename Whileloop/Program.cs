class WhileLoop{
    public static void Main(){
        Console.WriteLine("Enter your name: ");
        string name = Console.ReadLine();

        while(name == ""){
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
        }

        Console.WriteLine("Hello " + name);
    }
}