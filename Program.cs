using Aoc24;
using AoC24.Day1;

string filePath = "Day1/Day1.txt";
var fileReader = new FileReader(filePath);
var lines = fileReader.ReadLines();

var solver = new Day1Solver();
solver.ReadLines(lines);

var x = solver.PartOne();
Console.WriteLine("Answer day 1: {0} ", x);

var parttworesult = solver.PartTwo();
Console.WriteLine("Answer day 2: {0} ", parttworesult);
Console.ReadLine();