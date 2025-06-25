namespace Exercicio01
{
    public class Aluno
    {
        public string Nome { get; set; }
        public List<double> Notas = new List<double>();

        public void AdicionarNota(double n)
        {
            Notas.Add(n);
        }

        public double Media()
        {
            double soma = 0;
            Notas.ForEach(n => soma += n);
            return soma / Notas.Count;
        }

        public string Situacao()
        {
            if (Media() >= 7)
            {
                return "Aprovado";
            }
            else if (Media() >= 5)
            {
                return "Recuperação";
            }
            return "Reprovado";
        }
    }
}