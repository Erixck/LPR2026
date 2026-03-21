string escolha = "";

Console.WriteLine("Bem-vindo ao RPG!");
Console.WriteLine("Escolha sua classe:");
Console.WriteLine("\n [1] Guerreiro\n [2] Mago\n [3] Arqueira");
escolha = Console.ReadLine();

switch (escolha)
{
    case "1":
        Console.WriteLine("Você escolheu a classe Guerreiro!");
        Console.WriteLine("O Guerreiro é forte e resistente, especializado em combate corpo a corpo.");
        break;
    case "2":
        Console.WriteLine("Você escolheu a classe Mago!");
        Console.WriteLine("O Mago é inteligente e poderoso, especializado em magia e feitiços.");
        break;
    case "3":
        Console.WriteLine("Você escolheu a classe Arqueira!");
        Console.WriteLine("O Arqueiro é ágil e precisa, especializada em ataques à distância com arco e flecha.");
        break;
    default:
        Console.WriteLine("Opção inválida. Por favor, escolha uma classe válida.");
        break;
}
    

    