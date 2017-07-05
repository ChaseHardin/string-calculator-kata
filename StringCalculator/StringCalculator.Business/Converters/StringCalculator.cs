namespace StringCalculator.Business.Converters
{
    public class StringCalculator
    {
        public int Execute(string input)
        {
            return input.Length == 0 ? 0 : int.Parse(input);
        }
    }
}