namespace Exercicio02
{
    public class Produto
    {
        public string Nome { get; set; }
        public double PrecoBase { get; set; }
        public string Categoria { get; set; }

        public double AplicarDesconto()
        {
            if (Categoria == "Eletrônico")
            {
                return 0.15;
            }
            else if (Categoria == "Vestuário")
            {
                return 0.10;
            }
            return 0.05;
        }

        public double PrecoFinal()
        {
            return PrecoBase * (1 - AplicarDesconto());
        }
    }
}