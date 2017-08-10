namespace PrimeString
{
    public class Kata
    {
        public bool PrimeString(string source)
        {
            if (OnlyOneWord_Should_Be_True(source)) return true;

            for (var i = 0; i < source.Length / 2; i++)
            {
                if (!Source_Be_Replace_All_Should_Be_PrimeString(source, i))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool Source_Be_Replace_All_Should_Be_PrimeString(string source, int position)
        {
            return source.Replace(source.Substring(0, position + 1), "") != "";
        }

        private static bool OnlyOneWord_Should_Be_True(string source)
        {
            return source.Length == 1;
        }
    }
}