﻿using System;


class car
{
 
    public string Modelname { get; set; }
    public int NumberOfDoors { get; set; }

    public int NumberOfHorsePower { get; set; }


    public string Color { get; set; }


   public car(string x,int numOfDoors, int numOfHP, string color)
   {
       Modelname = x;
       NumberOfDoors = numOfDoors;

       NumberOfHorsePower = numOfHP;

       Color = color;

   }

}

class Fiat : car
{
    public Fiat(string modelname, int numOfDoors, int numOfHp, string color) : base(modelname, numOfDoors, numOfHp, color) { } 
}

class Nissan : car 
{
   // public Nissan(string modelname,int numOfDoors, int numOfHP): base(modelname, numOfDoors) { }

    public Nissan(string modelname, int numOfDoors, int numOfHP, string color) : base(modelname, numOfDoors, numOfHP, color) { }

}

class Audi : car
{
    public Audi(string modelname, int numOfDoors,int numOfHP, string color) : base(modelname, numOfDoors, numOfHP, color) { }

}

class Ferrari : car 
{
    public Ferrari(string modelname, int numOfDoors, int numOfHP, string color): base(modelname, numOfDoors, numOfHP, color) { }

}

class Program
{
    static void Main()
    {

       /* car Nissan = new Nissan("Nissan GTR", 2, 530);
        car Audi = new Audi("Audi r8", 2);
        car Fiat = new Fiat("Fiat PUNTO 1,2", 5);
        car Ferrari = new Ferrari ("Ferrari 458 Italia", 2);
        Console.WriteLine(Nissan.Modelname + " has "+ Nissan.NumberOfDoors + " doors" + " The 2013 version has 530 HorsePower");
        Console.WriteLine(Audi.Modelname + " has " + Audi.NumberOfDoors + " doors");
        Console.WriteLine(Fiat.Modelname + " has "+ Fiat.NumberOfDoors + " doors" );
        Console.WriteLine(Ferrari.Modelname + " has " + Ferrari.NumberOfDoors + " door ");
        */

        car Nissan = new Nissan("Nissan GTR",2, 530, "Blue");
        car Audi = new Audi("Audi r8", 2, 520, "Purple");
        car Fiat = new Fiat("Fiat PUNTO 1,2", 5, 120, "Cobalt black");
        car Ferrari = new Ferrari ("Ferrari 458 Italia", 2, 458, "Pink");
        Console.WriteLine(Nissan.Modelname + " has "+ Nissan.NumberOfDoors + " doors. The color of the car is " + Nissan.Color + ". The car has " + Nissan.NumberOfHorsePower + " HorsePower.\n");
        Console.WriteLine(Audi.Modelname + " has " + Audi.NumberOfDoors + " doors. The color of the car is " + Audi.Color + " The car has " + Audi.NumberOfHorsePower + " HorsePower.\n");
        Console.WriteLine(Fiat.Modelname + " has " + Fiat.NumberOfDoors + " doors. The color of the car is " + Fiat.Color + " This car is not a supercar, it only has " + Fiat.NumberOfHorsePower + " HorsePower.\n");
        Console.WriteLine(Ferrari.Modelname + " has " + Ferrari.NumberOfDoors + " door. The color of the car is " + Ferrari.Color +  " The car has " + Ferrari.NumberOfHorsePower +  " HorsePower.\n");

    }
}
