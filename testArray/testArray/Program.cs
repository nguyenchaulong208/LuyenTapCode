// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
int[,]Test = new int[3,3];
Test = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
for(int i = 0; i < Test.GetLength(0); i++)
{
    for (int j = 0; j < Test.GetLength(1); j++)
    {
        Console.Write($"i = [{i}] j = [{j}] |----|{Test[i, j]}|----| ");
    }
    Console.WriteLine();
}

