class Program{
    public static void Main(){
        // Console.WriteLine(multiplication(5,5));
        Console.WriteLine("Enter the first number: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"Result is {multiplication(a,b)}");

        double total = multiplication(2,3,4);
        Console.WriteLine(total);

    }

    static double multiplication(double a, double b){
        return a*b;
    }

    //method Overloading
    static double multiplication(double a, double b, double c){
        return a*b;
    }
    
}  