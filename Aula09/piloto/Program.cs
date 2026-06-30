using System;
using System.Collections.Generic;

struct Piloto
{
    public string Nome;
    public string Equipe;
    public int Pontuacao;
}

class Program
{
    static List<Piloto> pilotos = new List<Piloto>();

    static void Main()
    {
        // Cadastro dos 10 pilotos
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"\nPiloto {i + 1}");
            CadastrarPiloto();
        }

        Console.WriteLine("\n=== RANKING ===");
        ExibirRanking();

        double media = CalcularPontuacaoMedia();

        Console.WriteLine($"\nMédia de pontos: {media:F2}");

        int acimaDaMedia = 0;

        foreach (Piloto piloto in pilotos)
        {
            if (piloto.Pontuacao > media)
            {
                acimaDaMedia++;
            }
        }

        Console.WriteLine($"Pilotos acima da média: {acimaDaMedia}");

        Console.WriteLine();
        ExibirMelhorEquipe();
    }

    static void CadastrarPiloto()
    {
        Piloto piloto = new Piloto();

        Console.Write("Nome: ");
        piloto.Nome = Console.ReadLine();

        Console.Write("Equipe: ");
        piloto.Equipe = Console.ReadLine();

        Console.Write("Pontuação: ");
        piloto.Pontuacao = int.Parse(Console.ReadLine());

        pilotos.Add(piloto);
    }

    static void ExibirRanking()
    {
        List<Piloto> ranking = new List<Piloto>(pilotos);

        ranking.Sort((a, b) => b.Pontuacao.CompareTo(a.Pontuacao));

        int posicao = 1;

        foreach (Piloto piloto in ranking)
        {
            Console.WriteLine(
                $"{posicao}º - {piloto.Nome} | {piloto.Equipe} | {piloto.Pontuacao} pontos"
            );

            posicao++;
        }
    }

    static double CalcularPontuacaoMedia()
    {
        int soma = 0;

        foreach (Piloto piloto in pilotos)
        {
            soma += piloto.Pontuacao;
        }

        return (double)soma / pilotos.Count;
    }

    static void ExibirMelhorEquipe()
    {
        Dictionary<string, int> equipes = new Dictionary<string, int>();

        foreach (Piloto piloto in pilotos)
        {
            if (equipes.ContainsKey(piloto.Equipe))
            {
                equipes[piloto.Equipe] += piloto.Pontuacao;
            }
            else
            {
                equipes[piloto.Equipe] = piloto.Pontuacao;
            }
        }

        string melhorEquipe = "";
        int maiorPontuacao = 0;

        foreach (var equipe in equipes)
        {
            if (equipe.Value > maiorPontuacao)
            {
                maiorPontuacao = equipe.Value;
                melhorEquipe = equipe.Key;
            }
        }

        Console.WriteLine(
            $"Melhor equipe: {melhorEquipe} ({maiorPontuacao} pontos)"
        );
    }
}