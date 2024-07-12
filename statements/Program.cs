//using System;

// class Statements
// {
//     public static void Main()
//     {
//         char ch = 'a';
//         switch (ch)
//         {
//             case 'A':
//             case 'E':
//             case 'I':
//             case 'O':
//             case 'U':
//             case 'a':
//             case 'e':
//             case 'i':
//             case 'o':
//             case 'u':
//                 Console.WriteLine("Vowel");
//                 break;
//             default:
//                 Console.WriteLine("Not a Vowel");
//                 break;
//         }
//     }
// }


using System;

class SwitchExample
{
    public static void Main()
    {
        int day = 3; // Assume 1 = Monday, 2 = Tuesday, etc.

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }
    }
}
