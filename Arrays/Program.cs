// class Arrays{
//     public static void Main(){
//         string[] cars = {"BMW","Mustang","Corvette"};
        
//         Console.WriteLine(cars[0]);
//         Console.WriteLine(cars[1]);
//         Console.WriteLine(cars[2]);

//         cars[0]="Tesla";
//         Console.WriteLine(cars[0]);

//         for(int i=0;i<cars.Length;i++){
//             Console.WriteLine(cars[i]);
//         }

//         foreach(String Cars in cars){
//             Console.WriteLine(Cars);
//         }
//     }
// } 

class Arrays{
    public static void Main(){
        Console.WriteLine("Enter the number of cars: ");
        int carNums = Convert.ToInt32(Console.ReadLine());

        string[] cars = new string[carNums];

        for(int i=0;i<carNums;i++){
            Console.WriteLine($"Enter the {i+1} car: ");
            cars[i] = Console.ReadLine(); 
        }

        for(int i=0;i<cars.Length;i++){
            Console.WriteLine(cars[i]);
        }
    }
}