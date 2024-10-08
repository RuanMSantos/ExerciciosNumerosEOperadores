Console.WriteLine("Digite os lados do triângulo desejado.\n");

Console.Write("Lado 1...: ");
double lado1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Lado 2...: ");
double lado2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Lado 3...: ");
double lado3 = Convert.ToDouble(Console.ReadLine());

double s = (lado1 + lado2 + lado3) / 2, a = Math.Sqrt(s * (s - lado1) * (s - lado2) * (s - lado3));

Console.WriteLine($"\nSemiperímetro...: {s}");
Console.WriteLine($"Área ...........: {a}");