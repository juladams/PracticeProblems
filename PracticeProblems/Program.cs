// See https://aka.ms/new-console-template for more information
using PracticeProblems;

/*PeekValley p = new PeekValley();
int[] ar = { 19, 8, 12, 5, 1, 3, 11};

Console.WriteLine("The Array");

Array.ForEach(p.setTerrain(ar), t => Console.WriteLine(t));*/

//Anagram
/*Anagram a = new Anagram();

string s1 = "Race";
string s2 = "Care";
string s3 = "Car";
string s4 = "Cater";
string s5 = "Recat";
string s6 = "Rater";

Console.WriteLine(a.isAnagram(s1, s2)); //true
Console.WriteLine(a.isAnagram(s1, s3)); //false
Console.WriteLine(a.isAnagram(s3, s4)); //false
Console.WriteLine(a.isAnagram(s4, s5)); //true
Console.WriteLine(a.isAnagram(s5, s6)); //false*/

//Diving Board
DivingBoard d = new DivingBoard();
Console.WriteLine("Total number of Possibilities {0}", d.boardLength(3, 2, 4));
