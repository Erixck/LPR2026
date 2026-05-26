int[] numeros = new int[10];
int escolha;
int ocorrencias = 0;

Console.WriteLine("Digite 10 números inteiros: ");

for (int i = 0; i < 10; i++)
{
    Console.Write($"Número {i + 1}: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("Digite o número que deseja pesquisar: ");
escolha = int.Parse(Console.ReadLine());
Console.WriteLine("------------------------------");

for (int i = 0; i < numeros.Length; i++)
{
    if (numeros[i] == escolha)
    {
        Console.WriteLine($"O número {escolha} foi encontrado na posição {i} do vetor.");   
        ocorrencias++;
    }
}
Console.WriteLine($"O número {escolha} apareceu {ocorrencias} vez(es) no vetor.");