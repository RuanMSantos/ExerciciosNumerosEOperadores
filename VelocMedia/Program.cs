double distancia = 0, tempo = 0;

Console.Clear();

Console.WriteLine("-- Velocidade média --\n");

Console.Write("Distância percorrida (m): ");
string dist = Console.ReadLine()!;

if (!double.TryParse(dist, out distancia)) return;

Console.Write("Tempo gasto (s): ");
string temp = Console.ReadLine()!;

if (!double.TryParse(temp, out tempo)) return;

Console.WriteLine();

Console.WriteLine(VelocMedia(distancia, tempo));
string VelocMedia(double a, double b) => $"Velocidade média: {a / b:N2} m/s";

Console.WriteLine();