class NestedFor{
    public static void Main(){
        Console.WriteLine("Enter number of Rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter number of Columns: ");
        int columns = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the symbol: ");
        string symbol = Console.ReadLine();
        for(int i=0;i<rows;i++){
            for(int j=0;j<columns;j++){
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
    }
} 