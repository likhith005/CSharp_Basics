using System;
using System.Diagnostics;
using System.Text;
class Program{
    public static void Main(){
        string s ="";

        Stopwatch sw1 = new Stopwatch();
        sw1.Start();
        for(int i=0;i<100000;i++){
            s=s+i;
        }
        sw1.Stop();

        Stopwatch sw2 = new Stopwatch();
        sw2.Start();
        StringBuilder sb = new StringBuilder();
        for(int i=0;i<100000;i++){
            sb.Append(i);
        }
        sw2.Stop();  


        Console.WriteLine("Time taken for string: " + sw1.ElapsedMilliseconds + "ms");
        Console.WriteLine("Time taken for StringBuilder: " + sw2.ElapsedMilliseconds + "ms");
    }
}

