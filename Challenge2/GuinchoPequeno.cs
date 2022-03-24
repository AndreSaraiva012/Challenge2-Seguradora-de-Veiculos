namespace Challenge2
{
    public class GuinchoPequeno : Guincho
    {
        public GuinchoPequeno(Porte porte) : base(porte)
        {
        }

        public override void Socorro(Veiculo veiculo)
        {
            string message = $"Socorrendo Carro Pequeno  - Modelo {veiculo.Modelo}";
        }
    }
}