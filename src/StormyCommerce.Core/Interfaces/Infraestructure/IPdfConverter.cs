namespace StormyCommerce.Core.Interfaces.Infraestructure
{
    public interface IPdfConverter
    {
        byte[] Convert(string htmlContent);
    }
}
