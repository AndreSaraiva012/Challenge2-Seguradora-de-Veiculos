namespace Challenge2
{
    public abstract class SeguradoraFactory
    {
        public abstract Veiculo CriarVeiculo(string modelo, Porte porte);
        public abstract Guincho CriarGuincho(Porte porte);
    }
}
