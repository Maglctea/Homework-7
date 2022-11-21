int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            matrix[i, j] = rnd.Next(-min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j]}, ");
            else Console.Write($"{matrix[i, j]}");
        }
        Console.WriteLine("]");
    }
}

int[,] m = CreateMatrixRndInt(5, 5, -100, 100);
PrintMatrix(m);

Console.WriteLine("Введите номер столбца");
int xPosition = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер строки");
int yPosition = Convert.ToInt32(Console.ReadLine());

if (xPosition > m.GetLength(0) || yPosition > m.GetLength(1)) Console.WriteLine("Позиция выходит за пределы допустимых значений");
else
{
    Console.WriteLine(m[yPosition-1, xPosition-1]);
} 