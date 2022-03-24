namespace Challenge2
{
    public class GuinchoGrande : Guincho
    {
        public GuinchoGrande(Porte porte) : base(porte)
        {
        }

        public override void Socorro(Veiculo veiculo)
        {
            string message = $"Socorrendo Carro Grande - Modelo {veiculo.Modelo}";
            Log.Get.LogInfo(message);
        }
    }
}

