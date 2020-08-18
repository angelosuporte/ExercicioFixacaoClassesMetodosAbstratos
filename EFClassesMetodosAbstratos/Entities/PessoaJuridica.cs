namespace EFClassesMetodosAbstratos.Entities
{
    class PessoaJuridica : Contribuinte
    {
        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica()
        {
        }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios) : base(nome, rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }
        public override double imposto()
        {
            if ( NumeroDeFuncionarios <= 10)
            {
                return RendaAnual * 0.16;
            }
            else
            {
                return RendaAnual * 0.14;
            }
        }
    }
}
