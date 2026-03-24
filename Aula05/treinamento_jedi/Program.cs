Console.Write("Informe as horas de treino por dia (segunda a sexta): ");
int horasPorDia = int.Parse(Console.ReadLine());
     
int meta_horas = 1000;
int horas_acumuladas = 0;
int dias_passados = 0;

while (horas_acumuladas < meta_horas)
{
    horas_acumuladas += horasPorDia;
    dias_passados++;
}
    
double total_semanas = (double)dias_passados / 5;
double total_meses = total_semanas / 4.5;

Console.WriteLine($"Total de horas: {horas_acumuladas}h");
Console.WriteLine($"Dias necessários: {dias_passados} dias");
Console.WriteLine($"Semanas necessárias: {total_semanas:F2} semanas");
Console.WriteLine($"Meses necessários: {total_meses:F2} meses");
