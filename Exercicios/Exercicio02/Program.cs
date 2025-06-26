using Exercicio02;

Produto p1 = new Produto(){Nome = "TV", PrecoBase = 1399.90, Categoria = "Eletrônico"};
Produto p2 = new Produto(){Nome = "Camisa", PrecoBase = 49.59, Categoria = "Vestuário"};
Produto p3 = new Produto() { Nome = "Arroz", PrecoBase = 5.50, Categoria = "Alimento" };

Console.WriteLine($"Produto: {p1.Nome}");
Console.WriteLine($"Preço sem desconto: {p1.PrecoBase:f2}");
Console.WriteLine($"Preço com desconto: {p1.PrecoFinal():f2}");
Console.WriteLine();

Console.WriteLine($"Produto: {p2.Nome}");
Console.WriteLine($"Preço sem desconto: {p2.PrecoBase:f2}");
Console.WriteLine($"Preço com desconto: {p2.PrecoFinal():f2}");
Console.WriteLine();

Console.WriteLine($"Produto: {p3.Nome}");
Console.WriteLine($"Preço sem desconto: {p3.PrecoBase:f2}");
Console.WriteLine($"Preço com desconto: {p3.PrecoFinal():f2}");
Console.WriteLine();
