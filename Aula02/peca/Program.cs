string id_peca_1 = "";
int qtd_peca_1;
double valor_peca_1; 
string id_peca_2 = "";
int qtd_peca_2;
double valor_peca_2; 
double total;

Console.WriteLine("Código da primeira peça, quantidade e valor");
id_peca_1 = Console.ReadLine();
qtd_peca_1 = int.Parse(Console.ReadLine());
valor_peca_1 = double.Parse(Console.ReadLine());

Console.WriteLine("Código da segunda peça, quantidade e valor");
id_peca_2 = Console.ReadLine();
qtd_peca_2 = int.Parse(Console.ReadLine());
valor_peca_2 = double.Parse(Console.ReadLine());

total = (qtd_peca_1 * valor_peca_1) + (qtd_peca_2 * valor_peca_2);
Console.WriteLine($"Valor total: R${total}");
