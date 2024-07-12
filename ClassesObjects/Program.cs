using System;
class Students{
    public int studentId;
    public string studentName;
    public string studentCity;

    public void study(){
        Console.WriteLine(studentName + " is studying");
    }
    public void showDetails(){
        Console.WriteLine("Student Name is " + studentName);
        Console.WriteLine("Student ID is " + studentId);
        Console.WriteLine("Student City is " + studentCity);
    }

    public static void Main(){
        Students students = new Students(); 
        students.studentName="Sree Ram";
        students.studentId=1001;
        students.studentCity="Ayodhya";

        students.study();
        students.showDetails();
    }
}
