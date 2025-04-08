Console.Clear();

Console.WriteLine();

Console.Write("Salário (R$)..: ");
decimal salario = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine();

decimal fgts = 8 * salario / 100;

Console.WriteLine($"FGTS: R$ {fgts:N2}\n");