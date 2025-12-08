using System.Collections.Specialized;
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

            foreach (string line in lines)
            {
                var (start, limit) = logic.GetStartAndLimitId(line);

                for(var i = start; i <= limit; i++)
                {
                    var stringOfI = i.ToString();
                    if(stringOfI.Length %  2 != 0)
                    {
                        continue;
                    }
                    var halfedId = logic.GetStringHalfedString(stringOfI);
                    if (halfedId.Item1 == halfedId.Item2) logic.ListOfIds.Add(i);

                }
            }

            Console.WriteLine(logic.ListOfIds.Sum());


        }
    }
}
