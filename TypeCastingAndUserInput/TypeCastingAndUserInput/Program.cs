namespace TypeCastingAndUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Type casting is converting a value to another data type

            double a = 3.14;
            int b = Convert.ToInt32(a); // converts the double to an int and assigns to new variable

            Console.WriteLine(b);
            Console.WriteLine(a.GetType()); //The type of variable of a - system.double will be output
            Console.WriteLine(b.GetType()); //The type of variable of B - system.Int32 will be output
            Console.ReadKey();
        }
    }
}
