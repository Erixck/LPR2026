using System;
string id = "";
double ganho_hora;
double salario;
int horas;

Console.WriteLine("Insira seu ID: ");
id = Console.ReadLine();
Console.WriteLine("Horas trabalhadas: ");
horas = int.Parse(Console.ReadLine());
Console.WriteLine("Insira seu ganho por hora");
ganho_hora = double.Parse(Console.ReadLine());

salario = horas * ganho_hora;

Console.WriteLine($"O funcionário de id {id}, tem salário de R${salario}");

