// class Program{
//     public static int add(int a, int b){
//         return a+b;
//     }
//     public static int multiplication(int a, int b){
//         return a*b;
//     }
//     public delegate int mathOperations(int a, int b);
//     public static void Main(){
//         mathOperations math = new mathOperations(add);
//         Console.WriteLine("Addition: " + math(5,5));
//         math = new mathOperations(multiplication);
//         Console.WriteLine("multiplication: " + math(5,5));
//         // Console.WriteLine(add(5,5));
//         // Console.WriteLine(multiplication(5,5));
//     }
// } 

delegate void Calculator(int a, int b);
class Program{
    public static void Main(){
        Calculator cal = new Calculator(add);
        cal+=mul;
        cal(5,5);
        

        // Calculator cal1 = new Calculator(mul);
        // cal1(5,5);
    }

    public static void add(int a, int b){
        Console.WriteLine(a+b);
    }
    public static void mul(int a, int b){
        Console.WriteLine(a*b);
    }
}