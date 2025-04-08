Console.Clear();

decimal capital, taxa, tempo;

Console.WriteLine("Juros simples (j)\n");

Console.Write("Capital (R$).......: ");
capital = Convert.ToDecimal(Console.ReadLine());

Console.Write("Taxa de juros (%)..: ");
taxa = Convert.ToDecimal(Console.ReadLine()) / 100;

Console.Write("Tempo (meses)......: ");
tempo = Convert.ToDecimal(Console.ReadLine());

Console.WriteLine();

decimal
    juros = capital * taxa * tempo,
    montante = capital + juros;

Console.WriteLine($"Juros (R$).....: {juros}");
Console.WriteLine($"Montante (R$)..: {montante}");

Console.WriteLine();