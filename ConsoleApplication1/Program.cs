using System;


class car
{
   //public car Nissan {get;set;}

    public string Modelname { get; set; }
    public int NumberOfDoors { get; set; }


   public car(string x,int numOfDoors)
   {
       Modelname = x;
       NumberOfDoors = numOfDoors;
   }

}

class Nissan : car 
{
    public Nissan(string modelname,int numOfDoors): base(modelname,numOfDoors) { }
}

class Audi : car
{
    public Audi(string modelname, int numOfDoors) : base(modelname, numOfDoors) { }

}
class Program
{
    static void Main()
    {
        car Nissan = new Nissan("GTR",3);
        car Audi = new Audi("r8", 2);
        Console.WriteLine(Nissan.Modelname + " "+ Nissan.NumberOfDoors);
        Console.WriteLine(Audi.Modelname + " " + Audi.NumberOfDoors);
    }
}
