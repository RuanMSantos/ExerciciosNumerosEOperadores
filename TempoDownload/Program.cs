const int valorByte = 8;

Console.Clear();

Console.WriteLine("--- Tempo de Download ---\n");

Console.Write("Tamanho do arquivo em MB........: ");
double tamanho = Convert.ToDouble(Console.ReadLine());

Console.Write("Velocidade da conexão em Mbps...: ");
double velocidade = Convert.ToDouble(Console.ReadLine()) / valorByte;

double tempo = tamanho / velocidade / 60;

Console.WriteLine($"\nTempo estimado de download: {tempo:N1} minutos\n\n");