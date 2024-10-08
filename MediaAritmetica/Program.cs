Console.WriteLine("Média Aritmética de 3 números\n");

Console.Write("Digite o primeiro número: ");
double nota1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double nota2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o terceiro número: ");
double nota3 = Convert.ToDouble(Console.ReadLine());

double media = (nota1 + nota2 + nota3) / 3;

Console.Write($"\nMédia: {media:N2}");