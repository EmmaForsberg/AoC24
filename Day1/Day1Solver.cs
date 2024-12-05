using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AoC24.Day1
{
    internal class Day1Solver
    {
        List<int> first = new List<int>();
        List<int> second = new List<int>();

        //metod för att läsa alla rader och sortera efter ordning
        public void ReadLines(IEnumerable<string> lines)
        {
            foreach (var line in lines)
            {
                var newnumber = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var firstnumber = int.Parse(newnumber[0]);
                var secondnumber = int.Parse(newnumber[1]);
                first.Add(firstnumber);
                second.Add(secondnumber);
            }
            first.Sort();
            second.Sort();
        }

        //Part 1
        public int PartOne()
        {
            int result = 0;

            var differences = first.Zip(second, (a, b) => Math.Abs(a - b));

            foreach (var diff in differences)
            {
                result += diff;
            }
            return result;
        }

        //Part 2
        public int PartTwo()
        {
            var frequencyMap = second.GroupBy(x => x)
                                     .ToDictionary(g => g.Key, g => g.Count());

            int totalScore = 0;
            foreach (var number in first)
            {
                if (frequencyMap.ContainsKey(number))
                {
                    totalScore += number * frequencyMap[number];
                }
            }
            return totalScore;
        }
    }
}
