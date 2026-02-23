namespace OrientaçãoObjetos
{
    public class Produto2
    {
        // Método construtor 
        public Produto2(string? nome, double preco, int estoqueMinimo)
        {
            Nome = nome;
            Preco = preco;
            EstoqueMinimo = estoqueMinimo;
        }
        
        // Método para exibir o objeto, ele não retorna nenhum valor. Por isso usar o void
        public void Exibir()
        {
            // \n é para pular uma linha no console
            // O ToString passando c no parametro retorna o valor na moeda local da região que está o pc
            Console.WriteLine($"{Nome}\n{Preco.ToString("c")}\n{PrecoFinal.ToString("c")}\n{minimo}"); 
        }
        private string? nome;
        public string? Nome
        {
            get { return nome?.ToUpper(); }
            set { nome = value; }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
            set
            {
                if (preco < 5.00)
                {
                    preco = 5.00;
                }
                else
                {
                    preco = value;
                }
            }
        }

        private double desconto = 0.05;
        public double Desconto
        {
            get { return desconto; }
        }

        public double PrecoFinal
        {
            get { return Preco - (Preco * Desconto); }
        }

        private int minimo;
        public int EstoqueMinimo
        {
            set { minimo = value; }
        }
    }
}
