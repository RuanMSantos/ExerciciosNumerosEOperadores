string Imc(double a, double b){
    double c = a / Math.Pow(b, 2);
    return $"IMC: {c:N1} kg/m²";
}

double peso = 0, altura = 0;

Console.Clear();

Console.Write("Altura (m)..: ");
altura = Convert.ToDouble(Console.ReadLine());

Console.Write("\nPeso (kg)...: ");
peso = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Imc(peso, altura));