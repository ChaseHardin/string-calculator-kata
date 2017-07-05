using System.Linq;

namespace StringCalculator.Business.Converters
{
    public class StringCalculator
    {
        private const int EmptyString = 0;

        public int Execute(string input)
        {
            return IsStringEmpty(input) ? EmptyString : Sum(input);
        }

        private static int Sum(string input)
        {
            return input.Where(char.IsDigit).Sum(character => int.Parse(character.ToString()));
        }

        private static bool IsStringEmpty(string input)
        {
            return input.Length == EmptyString;
        }
    }
}