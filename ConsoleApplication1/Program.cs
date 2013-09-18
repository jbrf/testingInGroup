using System;


class car
{
 
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
        car Nissan = new Nissan("Nissan GTR",2);
        car Audi = new Audi("Audi r8", 2);
        Console.WriteLine(Nissan.Modelname + " has "+ Nissan.NumberOfDoors + " doors" );
        Console.WriteLine(Audi.Modelname + " has " + Audi.NumberOfDoors + " doors");
    }
}
