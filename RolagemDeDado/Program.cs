Console.Clear();
Console.WriteLine("--- Rolagem de Dado ---\n");

Console.Write("Quantas faces? ");
int faces = Convert.ToInt32(Console.ReadLine());

Random dado = new Random();

Console.WriteLine($"\nRolagem: {dado.Next(1, faces++)}\n\n");