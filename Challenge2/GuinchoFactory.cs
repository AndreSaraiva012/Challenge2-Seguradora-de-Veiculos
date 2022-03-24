namespace Challenge2
{
    public class GuinchoFactory : SeguradoraFactory
    {
        private string _Porte;

        public GuinchoFactory(string porte)
        {
            _Porte = porte;
        }
        public override Guincho CriarGuincho(Porte porte)
        {
            if (_Porte == Porte.grande.ToString())
                return new GuinchoGrande(porte);
            else if (_Porte == Porte.medio.ToString())
                return new GuinchoMedio(porte);
            else if (_Porte == Porte.pequeno.ToString())
                return new GuinchoPequeno(porte);
            else
                throw null;
        }

        public override Veiculo CriarVeiculo(string modelo, Porte porte)
        {
            if (_Porte == Porte.grande.ToString())
                return new VeiculoGrande(modelo, porte);
            else if (_Porte == Porte.medio.ToString())
                return new VeiculoMedio(modelo, porte);
            else if (_Porte == Porte.pequeno.ToString())
                return new VeiculoPequeno(modelo, porte);
            else
                throw null;
        }
    }
}
