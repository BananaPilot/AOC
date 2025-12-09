using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Day3
{
    public class Logic
    {
        public List<long> ListOfJoltageRating = new List<long>();

        private List<string> _strings = new List<string>();
        public List<int> GetInsInLine(string input)
        {
            var returnList = new List<int>();
            foreach(var num in input)
            {
                returnList.Add(int.Parse(num.ToString())); 
            }

            return returnList;
        }

        public Dictionary<int, int> GetGreatestNumberInList(List<int> ints)
        {
            //probably start from the last didigt to the first right to left
            // for me of tomorrow you need to create a method that returns a map [indexOfGreatestNumber | GreatestNumber] then you need to sort the dictionary of inser the number in a list of string in a way that it keeps a natural line 
        }
    }
}
