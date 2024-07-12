using System;
using System.Collections;
class Program{
    public static void Main(){
        SortedList sl = new SortedList();
        sl.Add("fname","SpongeBob");
        sl.Add("lname","SquarePants");
        sl.Add("age", 13);

        //sl.Remove("age");
        foreach (DictionaryEntry entry in sl)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
} 