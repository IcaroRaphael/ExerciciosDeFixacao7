using Exercicio01;

Aluno a1 = new Aluno() { Nome = "Fulano" };
a1.AdicionarNota(6.5);
a1.AdicionarNota(7.5);
a1.AdicionarNota(8.5);

Console.WriteLine($"Nome: {a1.Nome}");
Console.WriteLine($"Média: {a1.Media():f1}");
Console.WriteLine($"Situação: {a1.Situacao()}");
