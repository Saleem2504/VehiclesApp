using MyAssignment;
Console.WriteLine("Enter details for Car:");
        string carMake = GetUserInput("Make");
        string carModel = GetUserInput("Model");
        int carYear = GetIntInput("Year");
        int numDoors = GetIntInput("Number of Doors");

        Car car = new Car(carMake, carModel, carYear, numDoors);

        Console.WriteLine("\nEnter details for Motorcycle:");
        string bikeMake = GetUserInput("Make");
        string bikeModel = GetUserInput("Model");
        int bikeYear = GetIntInput("Year");
        bool hasFairing = GetBoolInput("Has Fairing");

        Motorcycle motorcycle = new Motorcycle(bikeMake, bikeModel, bikeYear, hasFairing);

        Console.WriteLine("\nVehicle 1 Details (Car):");
        car.DisplayDetails();

        Console.WriteLine("Vehicle 2 Details (Motorcycle):");
        motorcycle.DisplayDetails();
    

    static string GetUserInput(string prompt)
    {
        Console.Write($"{prompt}: ");
        return Console.ReadLine();
    }

    static int GetIntInput(string prompt)
    {
        Console.Write($"{prompt}: ");
        int result;
        while (!int.TryParse(Console.ReadLine(), out result))
        {
            Console.Write($"Invalid input. Please enter a valid {prompt}: ");
        }
        return result;
    }

    static bool GetBoolInput(string prompt)
    {
        Console.Write($"{prompt} (true/false): ");
        bool result;
        while (!bool.TryParse(Console.ReadLine(), out result))
        {
            Console.Write($"Invalid input. Please enter a valid {prompt} (true/false): ");
        }
        return result;
    }
