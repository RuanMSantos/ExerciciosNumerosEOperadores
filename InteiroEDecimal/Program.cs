Console.Clear();

Console.WriteLine("--- Inteiro e Decimal ---\n");

Console.Write("Digite um número: ");
double numero = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

double resto = numero % 1;

Console.WriteLine($"Parte inteira: {Convert.ToInt32(numero)}");
Console.WriteLine($"Parte decimal: {resto:N4}");

Console.WriteLine();