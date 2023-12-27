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
/*DivingBoard d = new DivingBoard();
Console.WriteLine("Total number of Possibilities {0}", d.boardLength(3, 2, 4));

//Diving Board 2
Console.WriteLine("Total number of Possibilities {0}", d.boardLength2(new int[] {1, 3, 2 }, 4));
*/

/*BranchLess b = new BranchLess();

Console.WriteLine(b.area('s', 5.0));
Console.WriteLine(b.area('c', 5.0));*/

//Merge Sort
/*Sort s = new Sort();

int[] a1 = { 10, 30, 50, 60, 0, 0, 0 };

int[] a2 = { 2, 4, 6 };

int[] a3 = { 10, 30, 50, 60, 0, 0, 0 };

int[] a4 = { 2, 4, 6 };

Console.WriteLine("Merge Sort");
foreach (var item in s.mergeSort(a1, 4, a2, 3))
{
    Console.WriteLine(item);
}
Console.WriteLine("Merge Sort 2");
foreach (var item in s.mergeSort2(a3, 4, a4, 3))
{
    Console.WriteLine(item);
}

int[] a5 = {1};
int[] a6 = {};

Console.WriteLine("Merge Sort 2 test 2");
foreach (var item in s.mergeSort2(a5, 1, a6, 0))
{
    Console.WriteLine(item);
}

int[] a7 = {0};
int[] a8 = {1};

Console.WriteLine("Merge Sort 2 test 3");
foreach (var item in s.mergeSort2(a7, 0, a8, 1))
{
    Console.WriteLine(item);
}*/

//Reverse Case
ReverseCase r = new ReverseCase();

Console.WriteLine(r.reverseCase("Hello World"));
Console.WriteLine(r.reverseCase("AAbbCCddEEffGG1234"));