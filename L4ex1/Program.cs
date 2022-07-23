void PrintArray(int[,] mat)
{
for(int i = 0; i < mat.GetLength(0); i++)
{
    for(int j = 0; j < mat.GetLength(1); j++)
    {
        Console.Write($"{mat[i,j]}");
    }
    Console.WriteLine();
}
}
void FillArray(int[,] mat)
{
    for(int i = 0; i < mat.GetLength(0); i++)
{
    for(int j = 0; j < mat.GetLength(1); j++)
    {
        mat[i,j] = new Random().Next(1,10);
    }
    Console.WriteLine();
}
}
int[,] matrix = new int [3,4];
PrintArray(matrix);
FillArray(matrix);
PrintArray(matrix);