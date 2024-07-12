class ForLoop{
    public static void Main(){
        for(int i=0;i<=10;i++){
            Console.WriteLine(i);
        }

        for(int i=10;i>0;i--){
            Console.WriteLine(i);
        }

        int num=12;
        for(int i=0;i<=10;i++){
            Console.WriteLine("{0} * {1} = {2}", num, i, num*i);
        }
    }
} 