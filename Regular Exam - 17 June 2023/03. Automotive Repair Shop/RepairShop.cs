using System.Text;

namespace AutomotiveRepairShop
{
    public class RepairShop
    {
        public int Capacity { get; set; }
        public List<Vehicle> Vehicles { get; set; }

        public RepairShop(int capacity)
        {
            Capacity = capacity;
            this.Vehicles = new List<Vehicle>();
        }
        public void AddVehicle(Vehicle vehicle)
        {
            if (Vehicles.Count < Capacity)
            {
                Vehicles.Add(vehicle);
            }
        }
        // public bool RemoveVehicle(string vin) => this.Vehicles.Remove(this.Vehicles.FirstOrDefault(v => v.VIN == vin));
        public bool RemoveVehicle(string vin)
        {
            Vehicle vehicle = Vehicles.FirstOrDefault(v => v.VIN == vin);
            if (vehicle != null)
            {
                Vehicles.Remove(vehicle);
                return true;
            }
            return false;
        }
        //public int GetCount() => this.Vehicles.Count;
        public int GetCount() => this.Vehicles.Count;

        public Vehicle GetLowestMileage() => this.Vehicles.OrderBy(v => v.Mileage).FirstOrDefault();

        //public Vehicle GetLowestMileage()
        //{
        //    Vehicle lowestMileageVehicle = null!;
        //    int minMileage = int.MaxValue;

        //    foreach (var vehicle in Vehicles)
        //    {
        //        if (vehicle.Mileage < minMileage)
        //        {
        //            lowestMileageVehicle = vehicle;
        //            minMileage = vehicle.Mileage;
        //        }
        //    }

        //    return lowestMileageVehicle;
        //}
        public string Report()
        {
            StringBuilder sb = new();
            sb.AppendLine("Vehicles in the preparatory:");
            foreach (var vehicle in this.Vehicles)
            {
                sb.AppendLine(vehicle.ToString());

            }
            return sb.ToString().TrimEnd();
           // return "Vehicles in the preparatory:"+string.Join(" ", Vehicles);
        }
        
    }
}



//Next, you are given a class RepairShop that has Vehicles (a List that stores Vehicles). All entities inside the repository have the same properties. The RepairShop class should have the following properties:
//•	Capacity – int
//•	Vehicles – List<Vehicle>
//The class constructor should receive capacity, also it should initialize the Vehicles with a new instance of the collection.Implement the following features:
//•	Method AddVehicle(Vehicle vehicle) – adds an entity to the collection of Vehicles, if the Capacity allows it.
//•	Method RemoveVehicle(string vin) – removes a vehicle by given vin, if such exists, and returns boolean (true if it is removed, otherwise – false)
//•	Method GetCount() – returns the number of vehicles, registered in the RepairShop
//•	Method GetLowestMileage() – returns the Vehicle with the lowest value of Mileage property.
//•	Method Report() – returns a string in the following format:
//o "Vehicles in the preparatory:
//{ Vehicle1}
//{ Vehicle2}
//(…)"
