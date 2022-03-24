namespace Challenge2
{
    public abstract class Guincho
    {
        public abstract void Socorro(Veiculo veiculo);

        public Porte Porte { get; set; }

        public Guincho(Porte porte)
        {
            Porte = porte;
        }
    }
}
