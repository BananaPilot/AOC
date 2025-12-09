using System.Collections.Specialized;
using System.Linq;
using System.Text;
using Utils;

namespace Day2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var util = new Util();
            var logic = new Logic();

            List<string> lines = [.. util.ParseFile(util.GetFilePath())[0].Split(',')];

            logic.FindInvalidIds(lines);

            Console.WriteLine(logic.SetOfIds.Sum());
        }
    }
}
