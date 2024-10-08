const double km = 1.609;

Console.Write("Entre com a medida (em milhas): ");
double medidas = Convert.ToDouble(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"{medidas *= km:N3} Km");