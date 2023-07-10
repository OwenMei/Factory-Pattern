namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome, how many wheels would you like on your vehicle?");
            int numWheels = (int.TryParse(Console.ReadLine(), out int a) ? a : 0);
            IVehicle vehicle1 = VehicleFactory.GetVehicle(numWheels);
            vehicle1.Drive();
        }
    }
}
