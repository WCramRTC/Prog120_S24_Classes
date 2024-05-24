namespace Prog120_S24_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static void LoadData(T)
        {
            string relativePath = Path.Combine("Data", "myfile.csv");
            var foodEntries = Data.ReadCsv(relativePath);
        }
    } // class

    public class FoodEntry
    {
        public string Name;
        public double Calories;
        public double Quantity;
    }

} // namespace
