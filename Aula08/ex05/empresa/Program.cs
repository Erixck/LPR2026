using System;

struct Chamado
{
    public int Numero;
    public string Solicitante;
    public string Setor;
    public int Prioridade;
    public string Status;
    public string Descricao;
}

class Program
{
    static Chamado[] chamados = new Chamado[10];
    static int quantidade = 0;

    static void Main()
    {
        int opcao;

        do
        {
            Console.WriteLine("\n=== SISTEMA DE CHAMADOS ===");
            Console.WriteLine("1 - Cadastrar chamado");
            Console.WriteLine("2 - Listar chamados");
            Console.WriteLine("3 - Atualizar status");
            Console.WriteLine("4 - Estatísticas");
            Console.WriteLine("5 - Sair");
            Console.Write("Escolha uma opção: ");

            opcao = int.TryParse(Console.ReadLine(), out int parsedOpcao) ? parsedOpcao : 0;

            switch (opcao)
            {
                case 1:
                    cadastrarChamado();
                    break;

                case 2:
                    listarChamados();
                    break;

                case 3:
                    atualizarStatus();
                    break;

                case 4:
                    estatisticas();
                    break;

                case 5:
                    Console.WriteLine("Encerrando sistema...");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 5);
    }

    static void cadastrarChamado()
    {
        if (quantidade >= 10)
        {
            Console.WriteLine("Limite de chamados atingido.");
            return;
        }

        Console.WriteLine("\n=== Cadastro de Chamado ===");

        Console.Write("Número: ");
        chamados[quantidade].Numero = int.TryParse(Console.ReadLine(), out int parsedNumero) ? parsedNumero : 0;

        Console.Write("Solicitante: ");
        chamados[quantidade].Solicitante = Console.ReadLine() ?? string.Empty;

        Console.Write("Setor: ");
        chamados[quantidade].Setor = Console.ReadLine() ?? string.Empty;

        Console.Write("Prioridade (1-Baixa, 2-Média, 3-Alta): ");
        chamados[quantidade].Prioridade = int.TryParse(Console.ReadLine(), out int parsedPrioridade) ? parsedPrioridade : 0;

        Console.Write("Descrição: ");
        chamados[quantidade].Descricao = Console.ReadLine() ?? string.Empty;

        chamados[quantidade].Status = "Aberto";

        quantidade++;

        Console.WriteLine("Chamado cadastrado com sucesso!");
    }

    static void listarChamados()
    {
        if (quantidade == 0)
        {
            Console.WriteLine("Nenhum chamado cadastrado.");
            return;
        }

        Console.WriteLine("\n=== LISTA DE CHAMADOS ===");

        for (int i = 0; i < quantidade; i++)
        {
            Console.WriteLine($"\nChamado #{chamados[i].Numero}");
            Console.WriteLine($"Solicitante: {chamados[i].Solicitante}");
            Console.WriteLine($"Setor: {chamados[i].Setor}");
            Console.WriteLine($"Prioridade: {classificarPrioridade(chamados[i].Prioridade)}");
            Console.WriteLine($"Status: {chamados[i].Status}");
            Console.WriteLine($"Descrição: {chamados[i].Descricao}");
        }
    }

    static void atualizarStatus()
    {
        Console.Write("\nDigite o número do chamado: ");
        int numero = int.TryParse(Console.ReadLine(), out int parsedNumero) ? parsedNumero : 0;

        bool encontrado = false;

        for (int i = 0; i < quantidade; i++)
        {
            if (chamados[i].Numero == numero)
            {
                encontrado = true;

                Console.WriteLine("1 - Em andamento");
                Console.WriteLine("2 - Resolvido");
                Console.WriteLine("3 - Cancelado");
                Console.Write("Novo status: ");

                int opcao = int.TryParse(Console.ReadLine(), out int parsedOpcao) ? parsedOpcao : 0;

                switch (opcao)
                {
                    case 1:
                        chamados[i].Status = "Em andamento";
                        break;

                    case 2:
                        chamados[i].Status = "Resolvido";
                        break;

                    case 3:
                        chamados[i].Status = "Cancelado";
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        return;
                }

                Console.WriteLine("Status atualizado com sucesso!");
                return;
            }
        }

        if (!encontrado)
        {
            Console.WriteLine("Chamado não encontrado.");
        }
    }

    static string classificarPrioridade(int prioridade)
    {
        switch (prioridade)
        {
            case 1:
                return "Baixa";

            case 2:
                return "Média";

            case 3:
                return "Alta";

            default:
                return "Inválida";
        }
    }

    static void estatisticas()
    {
        int abertos = 0;
        int andamento = 0;
        int resolvidos = 0;
        int cancelados = 0;

        for (int i = 0; i < quantidade; i++)
        {
            switch (chamados[i].Status)
            {
                case "Aberto":
                    abertos++;
                    break;

                case "Em andamento":
                    andamento++;
                    break;

                case "Resolvido":
                    resolvidos++;
                    break;

                case "Cancelado":
                    cancelados++;
                    break;
            }
        }

        Console.WriteLine("\n=== ESTATÍSTICAS ===");
        Console.WriteLine($"Abertos: {abertos}");
        Console.WriteLine($"Em andamento: {andamento}");
        Console.WriteLine($"Resolvidos: {resolvidos}");
        Console.WriteLine($"Cancelados: {cancelados}");
    }
}