namespace Urano.Implementations.Standard
{
    public class UranoStringReader : IStringReader
    {
        public string ReadNumber(int number)
        {
            return number.ToString();
        }
    }
}
