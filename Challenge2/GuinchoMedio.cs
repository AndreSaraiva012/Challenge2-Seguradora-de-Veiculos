namespace Challenge2
{
    public class GuinchoMedio : Guincho
    {
        public GuinchoMedio(Porte porte) : base(porte)
        {
        }

        public override void Socorro(Veiculo veiculo)
        {
            string message = $"Socorrendo Carro Medio Modelo {veiculo.Modelo}";
            Log.Get.LogInfo(message);
        }
    }
}
