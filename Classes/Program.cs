namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car carOne = new Car();
            carOne.Make = "Ford";
            carOne.Model = "Mustang";
            carOne.Year = 1965;

            Console.WriteLine($"{carOne.Year}, {carOne.Make} {carOne.Model}");
        }
    }
}
