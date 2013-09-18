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

class Program
{
    static void Main()
    {
        car Nissan = new Nissan("GTR",3);
        Console.WriteLine(Nissan.Modelname + " "+ Nissan.NumberOfDoors);

    }
}
