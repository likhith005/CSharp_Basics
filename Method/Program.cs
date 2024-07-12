// using System;
// class Program{
//     public static void Main(){
//         singBirthdaySong("Raju", 10000);  //arguments
//     }

//     static void singBirthdaySong(string bithdayboy, int yearOld){ //parameters
//         Console.WriteLine("Happy bithday to you!");
//         Console.WriteLine("Happy bithday to you!");
//         Console.WriteLine("Happy bithday dear " + bithdayboy);
//         Console.WriteLine("You are " + yearOld + " years old!");
//         Console.WriteLine("Happy bithday to you!");
//     }
// }

using System;
class Program{
    public static void Main(){
        Birthday.singBirthdaySong("Raju", 10000);  //arguments
    }
}

class Birthday{
    public static void singBirthdaySong(string bithdayboy, int yearOld){ //parameters
        Console.WriteLine("Happy bithday to you!");
        Console.WriteLine("Happy bithday to you!");
        Console.WriteLine("Happy bithday dear " + bithdayboy);
        Console.WriteLine("You are " + yearOld + " years old!");
        Console.WriteLine("Happy bithday to you!");
    }
}