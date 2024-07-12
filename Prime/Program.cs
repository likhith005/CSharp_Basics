class Prime{
    public static void Main(){
        int num=5, i;
        for(i=2;i<num;i++){
            if(num%i==0){
                Console.WriteLine("Not a Prime");
                break;
            }
        }
        if(num == i){
            Console.WriteLine("Prime");
        }
    }
}

//factorial
//febonacci 
//sum of even or odd numbers