int[,] myVeryCoolNumbers = {
    {1, 2},
    {3, 4},
    {5, 6},
    {7, 8}
};

Console.WriteLine("What is the first co-ordinate you want (y)?");
int co1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the seocond co-ordinate you want (x)?");
int co2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number at that location is: " + myVeryCoolNumbers[co1, co2]);