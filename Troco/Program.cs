Console.Clear();

Console.Write("Digite o valor da compra: ");
double compra = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o valor pago.....: ");
double pagamento = Convert.ToInt32(Console.ReadLine());

double troco = Math.Abs(compra - pagamento);

Console.WriteLine($"\nTroco: {troco}");