namespace Exercise4
{
    internal class Program
    {
        /// <summary>
        /// Prompt for 2 altitude then calculate the distance it took to get from point 1 to 2
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Get first altitude
            Console.WriteLine("Starting point:");
            int firstAltitude = int.Parse(Console.ReadLine());
            //Get second altitude
            Console.WriteLine("Stopping point:");
            int secondAltitude = int.Parse(Console.ReadLine());
            //Calculate and print distance
            Console.WriteLine(secondAltitude - firstAltitude);


        }
    }
}
