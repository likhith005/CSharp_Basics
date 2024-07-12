using System;
using System.Collections;
class Program{
    public static void Main(){
        Stack st = new Stack();
        st.Push(1);
        st.Push(2);
        st.Push(3);
        st.Push(4);

        foreach(int item in st){
            Console.WriteLine(item);
        }

        st.Pop();
        st.Pop();
        foreach(int item in st){
            Console.WriteLine(item);
        }
    }
}