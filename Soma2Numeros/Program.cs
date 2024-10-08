Console.WriteLine("Cálculo da soma entre dois números.\n");

Console.Write("Digite o primeiro número ");
int primeiroNumero = Convert.ToInt32(Console.ReadLine());

Console.Write("Digite o primeiro número ");
int segundoNumero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"\n{Soma(primeiroNumero, segundoNumero)}");

int Soma(int a, int b) => a + b;