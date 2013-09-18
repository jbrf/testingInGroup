using System;


class car
{
 
    public string Modelname { get; set; }
    public int NumberOfDoors { get; set; }
    public int NumberOfHorsePower { get; set; }


   public car(string x,int numOfDoors)
   {
       Modelname = x;
       NumberOfDoors = numOfDoors;
       NumberOfHorsePower = NumberOfHorsePower;
   }

}

class Fiat : car
{
    public Fiat(string modelname, int numOfDoors): base(modelname,numOfDoors) { } 
}

class Nissan : car 
{
    public Nissan(string modelname,int numOfDoors, int numOfHP): base(modelname,numOfDoors) { }
}

class Audi : car
{
    public Audi(string modelname, int numOfDoors) : base(modelname, numOfDoors) { }

}

class Ferrari : car 
{
    public Ferrari(string modelname, int numOfDoors): base(modelname, numOfDoors) { }

}

class Program
{
    static void Main()
    {
        car Nissan = new Nissan("Nissan GTR", 2, 530);
        car Audi = new Audi("Audi r8", 2);
        car Fiat = new Fiat("Fiat PUNTO 1,2", 5);
        car Ferrari = new Ferrari ("Ferrari 458 Italia", 2);
        Console.WriteLine(Nissan.Modelname + " has "+ Nissan.NumberOfDoors + " doors" + " The 2013 version has 530 HorsePower");
        Console.WriteLine(Audi.Modelname + " has " + Audi.NumberOfDoors + " doors");
        Console.WriteLine(Fiat.Modelname + " has "+ Fiat.NumberOfDoors + " doors" );
        Console.WriteLine(Ferrari.Modelname + " has " + Ferrari.NumberOfDoors + " door ");
        
    }
}
