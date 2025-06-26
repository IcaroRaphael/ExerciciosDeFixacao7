using Exercicio03;

ContaInvestimento ci1 = new ContaInvestimento();

Console.Write("Nome: ");
ci1.Titular = Console.ReadLine();

Console.Write("Saldo: ");
ci1.Saldo = double.Parse(Console.ReadLine());

Console.Write("Taxa de juros: ");
ci1.TaxaJuros = double.Parse(Console.ReadLine());

Console.Write("Valor de depósito: ");
ci1.Depositar(double.Parse(Console.ReadLine()));

Console.Write("Valor de saque: ");
ci1.Sacar(double.Parse(Console.ReadLine()));

ci1.ExibirResumo();
