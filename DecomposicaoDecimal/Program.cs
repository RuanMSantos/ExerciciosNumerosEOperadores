int u, d, c;

Console.Clear();
Console.WriteLine("-- Decomposição Decimal --\n");

Console.Write("Digite um número inteiro...: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

u = num % 10;
d = num / 10 % 10;
c = num / 100;

Console.WriteLine($"O número {num} possui:\n\n{u} unidade(s)\n\n{d} dezena(s)\n\n{c} centena(s).\n");