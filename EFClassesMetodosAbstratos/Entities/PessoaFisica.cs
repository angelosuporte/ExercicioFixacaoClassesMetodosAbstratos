namespace EFClassesMetodosAbstratos.Entities
{
    class PessoaFisica : Contribuinte 
    {
        public double GastosSaude { get; set; }

        public PessoaFisica()
        {
        }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            GastosSaude = gastosSaude;
        }

        public override double imposto()
        {
            if (RendaAnual <= 20000.0)
            {
                return RendaAnual * 0.15 - GastosSaude * 0.50;
            }
            else
            {
                return RendaAnual * 0.25 - GastosSaude * 0.50;
            }
        }
    }
     
    
}
