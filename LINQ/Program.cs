namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> gameName = new List<string>() { "F123", "NASCAR Heat", "NHL2K19", "WWE2K23", "Call of Duty", "Halo" };

            gameName.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
