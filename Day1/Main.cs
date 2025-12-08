using System.Diagnostics.Eventing.Reader;
using Utils;

namespace Day1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var util = new Util();
            var logic = new Logic();
            var lines = util.ParseFile(util.GetFilePath());

            foreach (var line in lines)
            {
                var values = logic.GetValuesFromLine(line);

                for (int i = 0; i < values.Item2; i++)
                {
                    if (logic.DisplayValue == 0) logic.Password++;
                    _ = values.Item1 == "L" ? logic.DisplayValue-- : logic.DisplayValue++;
                }
            }

            Console.WriteLine(logic.Password);
        }
    }
}
