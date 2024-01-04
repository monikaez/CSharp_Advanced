

namespace RawData;
public class StartUp
{
    static void Main(string[] args)
    {
        //INPUT
        int count = int.Parse(Console.ReadLine());

        //Reading The Cars
        List<Car> cars = new List<Car>();

        for (int i = 0; i < count; i++)
        {
            string[] carInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Engine currentEngine = new Engine(int.Parse(carInfo[1]), int.Parse(carInfo[2]));
            Cargo currentCargo = new Cargo(int.Parse(carInfo[3]), carInfo[4]);

            Tyre tyreOne = new Tyre(double.Parse(carInfo[5]), int.Parse(carInfo[6]));
            Tyre tyreTwo = new Tyre(double.Parse(carInfo[7]), int.Parse(carInfo[8]));
            Tyre tyreThree = new Tyre(double.Parse(carInfo[9]), int.Parse(carInfo[10]));
            Tyre tyreFour = new Tyre(double.Parse(carInfo[11]), int.Parse(carInfo[12]));

            Tyre[] currentTires = new Tyre[]
            {
                tyreOne,
                tyreTwo,
                tyreThree,
                tyreFour
            };

            Car currentCar = new Car(carInfo[0], currentEngine, currentCargo, currentTires);
            cars.Add(currentCar);
        }


        string command = Console.ReadLine();
        string[] filteredCarModels;

        if (command == "fragile")
        {
            filteredCarModels = cars
                .Where(c => c.Cargo.Type == "fragile" && c.Tyres.Any(t => t.Pressure < 1))
                .Select(c => c.Model)
                .ToArray();
        }
        else
        {
            filteredCarModels = cars
                .Where(c => c.Cargo.Type == "flammable" && c.Engine.Power > 250)
                .Select(c => c.Model)
                .ToArray();
        }

        //OUTPUT
        Console.WriteLine(string.Join(Environment.NewLine, filteredCarModels));
    }
}

