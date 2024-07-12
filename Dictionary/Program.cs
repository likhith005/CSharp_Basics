using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        // Creating a dictionary with string keys and int values
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // Adding key/value pairs to the dictionary
        ages.Add("Alice", 30);
        ages.Add("Bob", 25);
        ages.Add("Charlie", 35);

        // Accessing values by key
        Console.WriteLine($"Alice's age: {ages["Alice"]}");
        Console.WriteLine($"Bob's age: {ages["Bob"]}");

        // Checking if a key exists
        if (ages.ContainsKey("Charlie"))
        {
            Console.WriteLine($"Charlie's age: {ages["Charlie"]}");
        }

        // Iterating over the dictionary
        foreach (var kvp in ages)
        {
            Console.WriteLine($"Name: {kvp.Key}, Age: {kvp.Value}");
        }

        // Updating a value
        ages["Alice"] = 31;
        Console.WriteLine($"Alice's updated age: {ages["Alice"]}");

        // Removing a key/value pair
        ages.Remove("Bob");

        // Checking if a value exists
        if (ages.ContainsValue(35))
        {
            Console.WriteLine("Someone is 35 years old.");
        }

        // Clearing the dictionary
        ages.Clear();
        Console.WriteLine($"Total entries after clearing: {ages.Count}");
    }
}
