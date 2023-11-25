

namespace MyAssignment
{
   
        
// Base class representing a Vehicle
class Vehicle
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public Vehicle(string make, string model, int year)
    {
        Make = make;
        Model = model;
        Year = year;
    }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Make: {Make}\nModel: {Model}\nYear: {Year}\n");
    }
}

// Derived class representing a Car, inheriting from Vehicle
class Car : Vehicle
{
    public int NumDoors { get; set; }

    public Car(string make, string model, int year, int numDoors)
        : base(make, model, year)
    {
        NumDoors = numDoors;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Number of Doors: {NumDoors}\n");
    }
}

// Derived class representing a Motorcycle, inheriting from Vehicle
class Motorcycle : Vehicle
{
    public bool HasFairing { get; set; }

    public Motorcycle(string make, string model, int year, bool hasFairing)
        : base(make, model, year)
    {
        HasFairing = hasFairing;
    }

    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Has Fairing: {HasFairing}\n");
    }
}

    }
