using System;
using System.Collections;
class Program{
    public static void Main(){
        Queue q = new Queue();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(4); 
        
        foreach(int item in q){
            Console.WriteLine(item);
        }

        q.Dequeue();
        foreach(int item in q){
            Console.WriteLine(item);
        }
    }
} 