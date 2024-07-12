class Program{
    public static void Main(){
        try{
            int x, y, result;
            Console.WriteLine("Enter the first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the first number: ");
            y = Convert.ToInt32(Console.ReadLine());
        
            result = x/y;

            Console.WriteLine(result);
        }
        catch(FormatException e){
            Console.WriteLine("please enter only number");
        }
        catch(DivideByZeroException e){
            Console.WriteLine("You cant divide by zero");
        }
        // catch(Exception e){
        //     Console.WriteLine("Something went wrong");
        // }
        finally{
            Console.WriteLine("thanks for visiting");
        }

    }
}