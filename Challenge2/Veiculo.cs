namespace Challenge2
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public Porte Porte { get; set; }

        public Veiculo(Porte porte, string modelo)
        {
            Porte = porte;
            Modelo = modelo;
            
        }

    }
}