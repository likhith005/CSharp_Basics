using System;
class Program{
    public static void Main(){
        Console.WriteLine(Planets.Mercury + " is a planet " + (int)Planets.Mercury);
        // string name = PlanetsRadius.Earth.ToString();
        // int radius = (int)PlanetsRadius.Earth;
        // double volume = Volume(PlanetsRadius.Earth);

        // Console.WriteLine("Name: " + name);
        // Console.WriteLine("Radius: " + radius + "km");
        // Console.WriteLine("Volume: " + volume + "km^3");

    }
    // public static double Volume(PlanetsRadius radius){
    //     double volume = (4.0/3.0) * Math.PI * Math.Pow((int)radius,3);
    //     return volume;
    // }
} 

enum Planets{
    Mercury, 
    Venus, 
    Earth, 
    Mars, 
    Jupiter, 
    Saturn, 
    Uranus, 
    Neptune,
    Pluto
}

enum PlanetsRadius{
    Mercury = 2439, 
    Venus = 6051, 
    Earth = 6371, 
    Mars = 3389, 
    Jupiter = 69911, 
    Saturn = 58232, 
    Uranus = 25362, 
    Neptune = 24622,
    Pluto = 1188
}
