namespace Ventas.Infraestructure.Execeptions
{
    public class NegocioException : Exception
    {
        public NegocioException(string message) : base(message) { }        
    }
}
