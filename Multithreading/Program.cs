﻿using System;
using System.Threading;
class Program{
    public static void Main(){
        //assigning Thread datatype to a local variable 
        // Thread mainThread = Thread.CurrentThread;
        // mainThread.Name = "Main Thread";
        // Console.WriteLine(mainThread.Name);

        Thread thread1 = new Thread(CountDown);
        Thread thread2 = new Thread(CountUp);
        thread1.Start();
        thread2.Start();

        // CountDown();
        // CountUp();
        // Console.WriteLine(mainThread.Name + " is Complete!");
    }

    public static void CountDown(){ 
        for(int i=10;i>=0;i--){
            Console.WriteLine("Timer #1: " + i + " seconds"); 
            Thread.Sleep(1000);
        }
        Console.WriteLine("Timer #1 is complete!");
    }
    public static void CountUp(){
        for(int i=1;i<=10;i++){
            Console.WriteLine("Timer #2: " + i + " seconds"); 
            Thread.Sleep(1000);
        }
        Console.WriteLine("Timer #2 is complete!");
    }
}