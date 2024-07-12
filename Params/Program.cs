class Program{
    public static void Main(){
        double totalAmount = checkOut(3.99, 5.75, 15, 1.00, 10.25);
        Console.WriteLine(totalAmount);
    }

    static double checkOut(params double[] prices){
        double total = 0;
        foreach(double price in prices){
            total += price;
        }
        return total;
    } 
}