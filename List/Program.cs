using System;
using System.Collections.Generic;
class Program{
    public static void Main(){
        // //arrays
        // string[] food = new string[4];
        // food[0]="Pizza";
        // food[1]="Burger";
        // food[2]="Tacco";
        // food[3]="Rolls";
        // foreach(string item in food){
        //     Console.WriteLine(item);
        // }

        List<string> food = new List<string>();
        food.Add("Pizza");
        food.Add("Burger");
        food.Add("Tacco");
        food.Add("Rolls");

        foreach(string item in food){ 
            Console.WriteLine(item);
        }

        food.Remove("Rolls");
        food.Insert(0,"Sushi");
        Console.WriteLine(food.Count);
        Console.WriteLine(food.IndexOf("Tacco"));
        Console.WriteLine(food.LastIndexOf("Tacco"));
        Console.WriteLine(food.Contains("Tacco"));
        food.Sort();
        food.Reverse();
        // food.Clear();
        for(int i=0;i<food.Count;i++){
            Console.WriteLine(food[i]);
        }

        string[] foodArray = food.ToArray();
        foreach(string items in foodArray){
            Console.WriteLine(items);
        }
    }
} 