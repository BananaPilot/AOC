using System;
using System.Collections.Generic;
using System.Text;

namespace Day2
{
    public class Logic
    {
        public List<Int64> ListOfIds { get; set; } = new List<Int64>();
        public (Int64, Int64) GetStartAndLimitId(string id)
        {
            var split = id.Split('-');
            return (Int64.Parse(split[0]), Int64.Parse(split[^1]));
        }

        public (string, string) GetStringHalfedString(string id)
        {

            return (id.Substring(0, id.Length / 2), id.Substring(id.Length / 2));
        }
    }
}
