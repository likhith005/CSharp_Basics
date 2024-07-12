using System;
class Conditions{
    public static void Main(){
        // int num=5;
        // if(num%2==0){
        //     Console.WriteLine("the number is even");
        // }else{
        //     Console.WriteLine("the number is odd");
        // }

        // String username = "admin";
        // String password = "12345";
        // if(username.Equals("admin") && password.Equals("1234")){
        //     Console.WriteLine("login Success");
        // }else{
        //     Console.WriteLine("login Fail");
        // }

        // int a=56,b=45,c=74;
        // if(a>b && a>c){
        //     Console.WriteLine("a is greater");
        // }else if (b>c){
        //     Console.WriteLine("b is greater");
        // }else{
        //     Console.WriteLine("c is greater");
        // }

        int a=56,b=45,c=74;
        if(a>b){ 
            if(a>c){
                Console.WriteLine("a is greater");
            }else{
                Console.WriteLine("c is greater");
            }
        }else if (b>c){
            Console.WriteLine("b is greater");
        }else{
            Console.WriteLine("c is greater");
        }

    }
}
