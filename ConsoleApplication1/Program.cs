using System;


class car
{
 
    public string Modelname { get; set; }
    public int NumberOfDoors { get; set; }
    public string Color { get; set; }

   public car(string x,int numOfDoors, string color)
   {
       Modelname = x;
       NumberOfDoors = numOfDoors;
       Color = color;
   }

}

class Fiat : car
{
    public Fiat(string modelname, int numOfDoors, string color) : base(modelname, numOfDoors, color) { } 
}

class Nissan : car 
{
    public Nissan(string modelname, int numOfDoors, string color) : base(modelname, numOfDoors, color) { }
}

class Audi : car
{
    public Audi(string modelname, int numOfDoors, string color) : base(modelname, numOfDoors, color) { }

}

class Ferrari : car 
{
    public Ferrari(string modelname, int numOfDoors, string color): base(modelname, numOfDoors, color) { }

}

class Program
{
    static void Main()
    {
        car Nissan = new Nissan("Nissan GTR",2,"Blue");
        car Audi = new Audi("Audi r8", 2,"Purple");
        car Fiat = new Fiat("Fiat PUNTO 1,2", 5,"Cobalt black");
        car Ferrari = new Ferrari ("Ferrari 458 Italia", 2,"Pink");
        Console.WriteLine(Nissan.Modelname + " has "+ Nissan.NumberOfDoors + " doors. The color of the car is " + Nissan.Color +"\n");
        Console.WriteLine(Audi.Modelname + " has " + Audi.NumberOfDoors + " doors. The color of the car is " + Audi.Color + "\n");
        Console.WriteLine(Fiat.Modelname + " has " + Fiat.NumberOfDoors + " doors. The color of the car is " + Fiat.Color + "\n");
        Console.WriteLine(Ferrari.Modelname + " has " + Ferrari.NumberOfDoors + " door. The color of the car is " + Ferrari.Color + "\n");
    }
}
