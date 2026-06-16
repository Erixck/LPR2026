using System;

struct Heroi
{
    public string Nome;
    public string Poder;
    public int Pontuacao;
}

struct Equipe
{
    public Heroi[] Herois;
}

class Program
{
    static Heroi[] herois = new Heroi[5];
    static int qtdHerois = 0;

    static Equipe equipe;

    static void Main()
    {
        equipe.Herois = new Heroi[3];

        menuPrincipal();
    }

    static void cadastrarHeroi()
    {
        if (qtdHerois >= 5)
        {
            Console.WriteLine("Limite de heróis atingido!");
            return;
        }

        Console.Write("Nome do herói: ");
        herois[qtdHerois].Nome = Console.ReadLine();

        Console.Write("Poder: ");
        herois[qtdHerois].Poder = Console.ReadLine();

        Console.Write("Pontuação: ");
        herois[qtdHerois].Pontuacao = int.Parse(Console.ReadLine());

        qtdHerois++;

        Console.WriteLine("Herói cadastrado com sucesso!");
    }

    static void selecionarEquipe()
    {
        if (qtdHerois < 3)
        {
            Console.WriteLine("Cadastre pelo menos 3 heróis primeiro.");
            return;
        }

        Console.WriteLine("\nHeróis disponíveis:");

        for (int i = 0; i < qtdHerois; i++)
        {
            Console.WriteLine($"{i + 1} - {herois[i].Nome} ({herois[i].Poder})");
        }

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"\nEscolha o herói {i + 1}: ");
            int opcao = int.Parse(Console.ReadLine());

            while (opcao < 1 || opcao > qtdHerois)
            {
                Console.Write("Opção inválida. Digite novamente: ");
                opcao = int.Parse(Console.ReadLine());
            }

            equipe.Herois[i] = herois[opcao - 1];
        }

        Console.WriteLine("Equipe selecionada!");
    }

    static int calcularPontuacaoTotal()
    {
        int total = 0;

        for (int i = 0; i < equipe.Herois.Length; i++)
        {
            total += equipe.Herois[i].Pontuacao;
        }

        return total;
    }

    static void exibirEquipe()
    {
        Console.WriteLine("\n=== EQUIPE MARVEL ===");

        bool equipeVazia = true;

        for (int i = 0; i < equipe.Herois.Length; i++)
        {
            if (equipe.Herois[i].Nome != null)
            {
                equipeVazia = false;

                Console.WriteLine(
                    $"{i + 1}. {equipe.Herois[i].Nome} - " +
                    $"Poder: {equipe.Herois[i].Poder} - " +
                    $"Pontuação: {equipe.Herois[i].Pontuacao}"
                );
            }
        }

        if (equipeVazia)
        {
            Console.WriteLine("Nenhuma equipe foi selecionada.");
            return;
        }

        Console.WriteLine($"\nPontuação Total: {calcularPontuacaoTotal()}");
    }

    static void menuPrincipal()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n=== MENU ===");
            Console.WriteLine("1 - Cadastrar Herói");
            Console.WriteLine("2 - Selecionar Equipe");
            Console.WriteLine("3 - Exibir Equipe");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha: ");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    cadastrarHeroi();
                    break;

                case 2:
                    selecionarEquipe();
                    break;

                case 3:
                    exibirEquipe();
                    break;

                case 4:
                    Console.WriteLine("Encerrando programa...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 4);
    }
}