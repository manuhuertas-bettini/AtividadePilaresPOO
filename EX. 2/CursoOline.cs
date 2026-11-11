namespace AtividadePilaresPOO
{
        class CursoOnline : ProdutoDigital
        {
            public int DuracaoEmHoras { get; set; }

            public CursoOnline(string nome, decimal preco, int duracaoEmHoras) : base(nome, preco)
            {
                DuracaoEmHoras = duracaoEmHoras;
            }

            public override void ExibirInformacoes()
            {
                Console.WriteLine($"Nome: {Nome}");
                Console.WriteLine($"Preço: {Preco:C}");
                Console.WriteLine($"Duração em Horas: {DuracaoEmHoras}");
            }
        }
}