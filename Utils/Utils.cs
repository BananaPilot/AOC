using System.Configuration;

namespace Utils
{
    public class Util
    {
        public List<string> ParseFile(string filePath)
        {
            List<string> result = new List<string>();
            try
            {
                StreamReader streamReader = new StreamReader(filePath);

                string line = streamReader.ReadLine();

                while (line != null)
                {
                    result.Add(line);
                    line = streamReader.ReadLine();
                }

                streamReader.Close();

                return result;
            }
            catch(Exception ex) 
            {
                Console.WriteLine(ex.ToString());
            }

            return result;
        }

        public string GetFilePath()
        {
            return ConfigurationManager.AppSettings["Path"];
        }
    }
}