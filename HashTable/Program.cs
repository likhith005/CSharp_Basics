using System;
using System.Collections;
class Program{
    public static void Main(){
        Hashtable ht = new Hashtable(); 
        ht.Add("fname","SpongeBob");
        ht.Add("lname","SquarePants");
        ht.Add("age", 13);

        ht.Remove("age");
        foreach (DictionaryEntry entry in ht)
        {
            Console.WriteLine($"{entry.Key}: {entry.Value}");
        }
    }
} 