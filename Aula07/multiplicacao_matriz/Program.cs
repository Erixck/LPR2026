int[,] matrizA = new int[3, 3];
int[,] matrizB = new int[3, 3];
int[,] matrizC = new int[3, 3];

Console.WriteLine("Digite a matriz A (3x3):");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Matriz A [{i},{j}]: ");
        matrizA[i, j] = int.Parse(Console.ReadLine()!);
    }
}

Console.WriteLine();

Console.WriteLine("Digite a matriz B (3x3):");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write($"Matriz B [{i},{j}]: ");
        matrizB[i, j] = int.Parse(Console.ReadLine()!);
    }
}

for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        matrizC[i, j] = 0;

        for (int k = 0; k < 3; k++)
        {
            matrizC[i, j] += matrizA[i, k] * matrizB[k, j];
        }
    }
}

Console.WriteLine("Multiplicação");
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 3; j++)
    {
        Console.Write(matrizC[i, j] + "\t");
    }
    Console.WriteLine();
}
