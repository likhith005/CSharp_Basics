class MultiDimensionalArrays{
    public static void Main(){

        // // Declaration of a 2D array
        // int[,] matrix = new int[3, 3];

        // // Initialization of a 2D array
        // int[,] matrix = {
        //     {1, 2, 3},
        //     {4, 5, 6},
        //     {7, 8, 9}
        // };


        // ford = {"Mustang", "F-150", "Explorer"};
        // chevy = {"Corvette", "Camaro","Silverado"};
        // toyota = {"Corolla", "Camry", "Rav4"};

        string[,] parkingCars = {
            {"Mustang", "F-150", "Explorer"},
            {"Corvette", "Camaro","Silverado"},
            {"Corolla", "Camry", "Rav4"}
        };
        parkingCars[0,2]="Fusion";
        parkingCars[2,0]="Tacoma";

        foreach(string Parking in parkingCars){
            Console.WriteLine(Parking);
        }

        Console.WriteLine();

        for(int i=0;i<parkingCars.GetLength(0);i++){
            for(int j=0;j<parkingCars.GetLength(1);j++){
                Console.Write(parkingCars[i,j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        string[][] jaggedArrays = new string[3][];

        jaggedArrays[0] = new string[]{"apple","banana","avacado"};
        jaggedArrays[1] = new string[]{"dog","cat"};
        jaggedArrays[2] = new string[]{"mermaid"};

        for(int i=0;i<jaggedArrays.Length;i++){
            for(int j=0;j<jaggedArrays[i].Length;j++){
                Console.Write(jaggedArrays[i][j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();

        object[] arr = {"C", 1200, true, "Welcome", 12.5};
        for(int i=0;i<arr.Length;i++){
            Console.WriteLine(arr[i]);
        }

        object[] objArray = new object[5];
        objArray[0] = 42;              // Integer
        objArray[1] = "Hello";         // String
        objArray[2] = 3.14;            // Double
        objArray[3] = 'A';             // Char
        objArray[4] = true;            // Boolean

        foreach(object obj in objArray){
            Console.WriteLine(obj);
        }
    }
}

//sort the element an array
//find unique element in an array
//display prime element in an array
// merge 2 array in one array

//matrix addition ... 