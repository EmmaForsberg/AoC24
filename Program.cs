using Aoc24;
using Aoc24.Day_2;

string filePath = "Day 2/Day2.txt";
var fileReader = new FileReader(filePath);
var lines = fileReader.ReadLines();

var solver = new Day2Solver();
solver.ReadLines(lines);


Console.ReadLine();