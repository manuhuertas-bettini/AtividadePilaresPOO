namespace AtividadePilaresPOO
{
        class Ebook : ProdutoDigital
        {
            public int NumeroDePaginas { get; set; }

            public Ebook(string nome, decimal preco, int numeroDePaginas) : base(nome, preco)
            {
                NumeroDePaginas = numeroDePaginas;
            }

            public override void ExibirInformacoes()
            {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Preço: {Preco:C}");
                Console.WriteLine($"Número de Páginas: {NumeroDePaginas}");
            }  
        }
}