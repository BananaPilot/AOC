using Utils;

namespace Day3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var util = new Util();
            var logic = new Logic();

            var lines = util.ParseFile(util.GetFilePath());

            foreach ( var line in lines )
            {
                var ints = logic.GetInsInLine(line);
                logic.GetRecursiveGreatestNumberInList(ints, 12);

            }
            Console.WriteLine(logic.ListOfJoltageRating.Sum());
        }
    }
}
