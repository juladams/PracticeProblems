// See https://aka.ms/new-console-template for more information
using PracticeProblems;

PeekValley p = new PeekValley();
int[] ar = { 19, 8, 12, 5, 1, 3, 11};

Console.WriteLine("The Array");

Array.ForEach(p.setTerrain(ar), t => Console.WriteLine(t));
