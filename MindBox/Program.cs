
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("To calculate the area, enter the sides of the figure,"
    + " separating them with a space");
        string input = Console.ReadLine();
        string[] splitedInput = input.Trim().Split(" ");
        double[] sides = new double[splitedInput.Length];
        for (int i = 0; i < splitedInput.Length; i++)
            if (double.TryParse(splitedInput[i], out sides[i]) == false)
                throw new Exception($"Side {splitedInput[i]} is entered incorrectly");
        Console.ReadLine();
    }
}