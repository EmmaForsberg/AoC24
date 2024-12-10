namespace Aoc24.Day_2
{
    internal class Day2Solver
    {
        List<int> numbers = new List<int>();
      
        int difference = 0;

        //Part one solution
        public void ReadLines(IEnumerable<string> lines)
        {
           
            int safeReports = 0;

            foreach (string line in lines)
            {
                var levels = line.Split(' ').Select(int.Parse).ToList();

                bool isIncreasing = true;
                bool isDecreasing = true;
                bool isSafe = true;


                for (int i = 0; i < levels.Count - 1; i++)
                {
                    difference = levels[i + 1] - levels[i];

                    if (difference < -3 || difference > 3)
                    {
                        isSafe = false;
                        break;
                    }
                    else if (difference == 0)
                    {
                        isSafe = false;
                        break;
                    }

                    if (difference > 0)
                        isDecreasing = false;
                    if (difference < 0)
                        isIncreasing = false;
                }
                if (!isIncreasing && !isDecreasing)
                    isSafe = false;

                // Öka räknaren om raden är säker
                if (isSafe)
                    safeReports++;
                continue;
            }

            // Efter loopen kan du skriva ut resultatet
            Console.WriteLine($"Number of safe reports: {safeReports}");

        }
    }
}

