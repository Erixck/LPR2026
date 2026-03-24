Console.WriteLine("Digite um número:");
int entrada = int.Parse(Console.ReadLine());

int quadrado = entrada * entrada;
int soma = 0;

while (quadrado > 0)
{
    int digito = quadrado % 10;
    soma += digito;
    quadrado /= 10;
}
Console.WriteLine("Soma dos dígitos do quadrado: " + soma);