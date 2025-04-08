const double 
    pi = Math.PI,
    g = 9.80665;

double velocidade, angulo, radiano;
double xMax, hMax;

Console.Clear();
Console.WriteLine("-- Projétil --\n");

Console.Write("Entre com a velocidade, em m/s..: ");
velocidade = Convert.ToDouble(Console.ReadLine());

Console.Write("Entre com o ângulo, em graus....: ");
angulo = Convert.ToDouble(Console.ReadLine());

Console.WriteLine();

radiano = ConversorRadiano(angulo);

xMax = Math.Pow(velocidade, 2) * Math.Sin(radiano * 2) / g;
hMax = Math.Pow(velocidade * Math.Sin(radiano), 2) / (2 * g);

Console.WriteLine($"Alcance........: {xMax:N2} m");
Console.WriteLine($"Altura máxima..: {hMax:N2} m");

Console.WriteLine();

double ConversorRadiano(double anguloEmGraus) => anguloEmGraus * (pi / 180);