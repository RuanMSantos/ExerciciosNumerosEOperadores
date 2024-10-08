Console.Write("°F = ");
double fahrenheit = Convert.ToDouble(Console.ReadLine());

double celsius = (fahrenheit - 32) / 1.8;

Console.WriteLine($"{fahrenheit}°F equivalem a {celsius:N2}°C");