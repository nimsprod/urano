namespace Urano.Implementations.Crazy
{
    public class CrazyUranoStringReader : IStringReader
    {
        public string ReadNumber(int number)
        {
            var rand = new Random();
            return rand.Next(100).ToString();
        }
    }
}
