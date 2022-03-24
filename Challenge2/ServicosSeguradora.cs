namespace Challenge2
{
    public class ServicosSeguradora
    {
        private Veiculo _veiculo;
        private Guincho _guincho;

        public ServicosSeguradora(SeguradoraFactory seguradora, Veiculo veiculo)
        {
            _veiculo = seguradora.CriarVeiculo(veiculo.Modelo, veiculo.Porte);
            _guincho = seguradora.CriarGuincho(veiculo.Porte);
        }

        public void ServicoReboque()
        {
            _guincho.Socorro(_veiculo);
        }

        public static Veiculo CriarVeiculo(string porte, string modelo)
        {
            if (porte == Porte.grande.ToString())
                return new VeiculoGrande(modelo, Porte.grande);
            else if (porte == Porte.medio.ToString())
                return new VeiculoMedio(modelo, Porte.medio);
            else if (porte == Porte.pequeno.ToString())
                return new VeiculoPequeno(modelo, Porte.pequeno);
            else
            {
                Console.WriteLine("Erro! Porte não existe!");
                return null;
            }
        }
    }
}
