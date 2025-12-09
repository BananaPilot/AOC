using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    public class Logic
    {
        public HashSet<long> SetOfIds { get; set; } = new HashSet<long>();
        public (long, long) GetStartAndLimitId(string id)
        {
            var split = id.Split('-');
            return (long.Parse(split[0]), long.Parse(split[^1]));
        }

        public IEnumerable<string> GetSubstring(string id, int chunkSize)
        {
            return Enumerable.Range(0, id.Length / chunkSize)
            .Select(i => id.Substring(i * chunkSize, chunkSize));
        }

        public void FindInvalidIds(List<string> lines)
        {
            foreach (string line in lines)
            {
                var (start, limit) = GetStartAndLimitId(line);

                for (long i = start; i <= limit; i++)
                {
                    var stringOfI = i.ToString();
                    for (var j = stringOfI.Length / 2; j > 0; j--)
                    {
                        var stringChunk = GetSubstring(stringOfI, j).First();
                        var sb = new StringBuilder(stringChunk);
                        for (var k = 0; k < stringOfI.Length / j - 1; k++)
                        {
                            sb.Append(stringChunk);
                        }
                        if (sb.ToString() == stringOfI) SetOfIds.Add(i);
                    }
                }
            }
        }
    }
}
