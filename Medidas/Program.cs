Console.Write("Entre com a medida (em metros): ");
double medida = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("--- Equivalência ---");
Console.WriteLine($"{medida * 100} cm");
Console.WriteLine($"{medida} m");
Console.WriteLine($"{medida / 1000} km");