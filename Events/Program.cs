using System;
class Program{
    public static event EventHandler CalculationCompleted;
    public static void Main(){
        Console.WriteLine("Enter a number: ");
        int i = Convert.ToInt32(Console.ReadLine());

        CalculationCompleted += onCalculationCompleted;

        Transformer t = square;
        t += cube;
        
        t.Invoke(i);
        
        CalculationCompleted?.Invoke(null, EventArgs.Empty);
    }
    public delegate void Transformer(int x);

    public static void square(int x){
        Console.WriteLine(x * x);
    }
    public static void cube(int x){
        Console.WriteLine(x * x * x);
    }

    public static void onCalculationCompleted(object sender, EventArgs e){
        Console.WriteLine("Calculations are completed!");
    }
} 

