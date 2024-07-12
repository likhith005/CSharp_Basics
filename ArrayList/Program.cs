using System;
using System.Collections;
class Program{
    public static void Main(){
        ArrayList obj = new ArrayList();
        obj.Add(1);
        obj.Add("C");
        obj.Add("Java");
        obj.Add(12.34);
        foreach(object i in obj){
            Console.WriteLine(i);
        }

        obj.Remove(12.34);
        for(int i=0;i<obj.Count;i++){
            Console.WriteLine(obj[i]);
        }
    }
} 