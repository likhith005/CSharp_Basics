class Person{
    private string name;
    private int age;

    // Public properties
    public string getName{
        get {return name;}
        set {name = value;} 
    }

    public int getAge{
        get {return age;}
        set {
            if (value >= 0 && value <= 150)
                age = value;
            else
                throw new ArgumentException("Age must be between 0 and 150.");
        }
    }
} 

class Program{
    public static void Main(){
        Person person = new Person();
        Console.WriteLine("Enter name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        person.getName = name;
        person.getAge = age;

        Console.WriteLine("Name: " + person.getName);
        Console.WriteLine("age: " + person.getAge);
    }
}


// using System;

// class Person
// {
//     // Auto-implemented properties
//     public string Name { get; set; }
//     public int Age { get; set; }

//     // Constructor
//     public Person(string name, int age)
//     {
//         Name = name;
//         Age = age;
//     }

//     // Method to display person's details
//     public void Display()
//     {
//         Console.WriteLine($"Name: {Name}, Age: {Age}");
//     }
// }

// class Program
// {
//     static void Main()
//     {
//         // Creating an instance of Person
//         Person person = new Person("Alice", 30);

//         // Accessing properties
//         Console.WriteLine(person.Name); // Output: Alice
//         Console.WriteLine(person.Age);  // Output: 30

//         // Modifying properties
//         person.Name = "Bob";
//         person.Age = 25;

//         // Displaying updated details
//         person.Display(); // Output: Name: Bob, Age: 25
//     }
// }
