namespace Exercicio03
{
    public class ContaInvestimento
    {
        public string Titular { get; set; }
        public double Saldo { get; set; }
        public double TaxaJuros { get; set; }


        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && valor <= Saldo)
            {
                Saldo -= valor;
            }
            else
            {
                Console.WriteLine("Saque inválido!");
            }
        }

        public double CalcularRendimento(int meses)
        {
            double jurosMensal = (TaxaJuros / 100.0) / 12.0;
            return Saldo * jurosMensal * meses;
        }

        public void ExibirResumo()
        {
            Console.WriteLine($"Nome: {Titular}");
            Console.WriteLine($"Saldo atual: {Saldo:f2}");
            Console.WriteLine($"Rendimento projetado para 12 meses: {CalcularRendimento(12):f2}");
        }
    }
}
