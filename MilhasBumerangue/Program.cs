Console.Clear();

Console.WriteLine("--- Milhas Bumerangue ---");

Console.WriteLine();

Console.Write("Percentual de bônus.....: ");
double bonus = Convert.ToDouble(Console.ReadLine());

Console.Write("Percentual de retorno...: ");
double retorno = Convert.ToDouble(Console.ReadLine());

Console.Write("Pontos a transferir.....: ");
double transferencia = Convert.ToDouble(Console.ReadLine());

double pontosAReduzir = Math.Abs((transferencia * retorno / 100) - transferencia);
double pontosAAcrescentar = (transferencia * bonus / 100) + transferencia;

Console.WriteLine();

Console.WriteLine($"Pontos a reduzir na origem........: {pontosAReduzir}");
Console.WriteLine($"Pontos a acrescentar no destino...: {pontosAAcrescentar}");

Console.WriteLine();