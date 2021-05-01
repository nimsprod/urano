namespace Urano.Implementations.Crazy
{
    public class CrazyUranoStringReader : IStringReader
    {
        public CrazyUranoStringReader()
        { 
        
        }

        public string ReadNumber(int number)
        {
            IStringReader standarUranoStringReader = new Standard.UranoStringReader();           

            var rand = new Random();
            return rand.Next(100).ToString() + "---" + standarUranoStringReader.ReadNumber(number);
        }
    }
}
