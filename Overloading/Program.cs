class Program{
    public static void Main(){
        Calculator calculator = new Calculator();
        int result = calculator.add(5,5);
        Console.WriteLine(result);
    }
}

class Calculator{
    public int add(int a, int b){
        return a+b;
    }
    public double add(double a, double b){
        return a+b;
    }
    public double add(double a, double b, int c){
        return a+b+c;
    }
}