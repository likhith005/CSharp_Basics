// class Program{
//     public void fun(){
//             Console.WriteLine("this is function body");
//     }
//     public delegate void mydel();
//     public static void Main(){
//         Program program = new Program();
//         mydel del = new mydel(program.fun);
//         del();
//     }

class Program{
    public static void Main(){
        Example example = new Example();
        //single task delegate
        Example.mydel del = new Example.mydel(example.fun);
        //multi task delegate
        del+=example.fun1;
        del();
        del();
    }
}
class Example{
    public void fun(){
        Console.WriteLine("this is function body");
    } 
    public void fun1(){
        Console.WriteLine("this is function body1");
    }
    public delegate void mydel();
}