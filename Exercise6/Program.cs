namespace Exercise6
{
    /// <summary>
    /// Calculate and display the cosine and sine of an angle that are prompted
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            float angle;
            //Prompt and get angle
            Console.WriteLine("Angle(Degree): ");
            angle = float.Parse(Console.ReadLine());
            //Convert angle from degree to radian to work with Mathf method
            angle = angle * MathF.PI / 180;
            //Print the calculated sine
            Console.WriteLine("Sine: " + MathF.Sin(angle));
            //Print the calculated cosine
            Console.WriteLine("Cosine: " + MathF.Cos(angle));
        }
    }
}
