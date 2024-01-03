namespace WebServiceApi.Modelo
{
    public class ProcedimientoSuma
    {
        public int primerdigito { get; set; }
        public int segundodigito { get; set; }
        public int total { get; set; }

        public ProcedimientoSuma(int primerdigito, int segundodigito)
        {
            this.primerdigito = primerdigito;
            this.segundodigito = segundodigito;
        }

        public void suma()
        {
            total = primerdigito + segundodigito;
        }
    }
}
