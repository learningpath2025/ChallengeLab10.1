namespace ChallengeLab10._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Letter that was added to the second string is { FindDifference("abcd", "abcde")}.");
            Console.ReadLine();
        }

        public static string FindDifference(string s, string t)
        {
            var d = "";
            if (s != null && t != null)
            {
                d = t.Except(s).FirstOrDefault().ToString();
            }
            return d;
        }
    }
}
