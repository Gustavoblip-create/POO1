namespace _18_ValidaCpf
{
    public interface IDocumento
    {
        string Numero
        {
            get;
        }
        bool Validar();
    }
}
