namespace GuideInvestimentos.Dominio.ObjetosDeValor
{
    public class Nome
    {
        public string Texto { get; private set; }

        public Nome(string texto)
        {
            Texto = texto;
        }

        public override string ToString()
        {
            return Texto;
        }
    }
}
