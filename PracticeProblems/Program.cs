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
/*ReverseCase r = new ReverseCase();

Console.WriteLine(r.reverseCase("Hello World"));
Console.WriteLine(r.reverseCase("AAbbCCddEEffGG1234"));*/

/*//Remove Element
RemoveElement r = new RemoveElement();

int[] nums = [3, 2, 2, 3];
int val = 3;

r.removeElement(nums, val);

Console.WriteLine("\nSecond Test");

nums = [0, 1, 2, 2, 3, 0, 4, 2];
val = 2;

r.removeElement(nums, val);

Console.WriteLine("\nThird Test");

nums = [1];
val = 1;
r.removeElement(nums, val);*/

//Remove Duplicates
/*RemoveDuplicates r = new RemoveDuplicates();
int[] nums = { 1, 2, 3 };
int[] nums2 = { 1, 1, 2 };
int[] nums3 = { 1, 1, 2, 3 };
int[] nums4 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
int[] nums5 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4, 5};
Console.WriteLine(r.removeDuplicates(nums));
Console.WriteLine("test 2");   
Console.WriteLine(r.removeDuplicates(nums2));
Console.WriteLine("test 3");
Console.WriteLine(r.removeDuplicates(nums3));
Console.WriteLine("test 4");
Console.WriteLine(r.removeDuplicates(nums4));
Console.WriteLine("test 5");
Console.WriteLine(r.removeDuplicates(nums5));*/

//Array Shift
/*ArrayShift a = new ArrayShift();
int[] nums = [1, 2, 3, 4]; // Do a jump. If the jump is greater than the length of the array - 1, 
//then the jump gets the shift - (the remainder - 1) - 1
int k = 2;

//a.shiftRight(nums, k);
a.shiftArray2(nums, k);*/

//SumArray

//Candy
/*Candy c = new Candy();
int[] ratings = { 1, 0, 2 };
Console.WriteLine("test 1"); 
Console.WriteLine(c.candy(ratings));//5

Console.WriteLine("test 2");
int[] ratings2 = { 1, 2, 2 };
Console.WriteLine(c.candy(ratings2));//4

Console.WriteLine("test 3");// failed with 11
int[] ratings3 = { 1, 2, 87, 87, 87, 2, 1 };
Console.WriteLine(c.candy(ratings3));//13
*/
//Randomized Set
/*RandomizedSet r = new RandomizedSet();
Console.WriteLine(r.Insert(1));
Console.WriteLine(r.Remove(2));
Console.WriteLine(r.Insert(2));
Console.WriteLine(r.GetRandom());
Console.WriteLine(r.Remove(1));
*/

//MaxWater
/*Maxwater m = new Maxwater();
int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

Console.WriteLine(m.maxArea(height)); //49
*/

//ThreeSum
/*ThreeSome t = new ThreeSome();
int[] nums = { -1, 0, 1, 2, -1, -4 };
Console.WriteLine("Test 1");
foreach (var item in t.ThreeSum(nums))
{
    Console.WriteLine(string.Join(",", item));
}

Console.WriteLine("Test 2");
int[] nums2 = { 1, -1, -1, 0 };
foreach (var item in t.ThreeSum(nums2))
{
    Console.WriteLine(string.Join(",", item));
}

IList<IList<int>> result = t.ThreeSum(nums2).Distinct().ToList();
foreach(var item in result)
{
    Console.WriteLine(string.Join(",", item));
}
*/

//Groups
/*FindCircleNum f = new FindCircleNum();
int[][] arr = new int[3][];
arr[0] = new int[] { 1, 1, 0 };
arr[1] = new int[] { 1, 1, 0 };
arr[2] = new int[] { 0, 0, 1 };
Console.WriteLine("Test 1");
Console.WriteLine(f.findCircleNum(arr)); //2

int[][] arr2 = new int[4][];
arr2[0] = new int[] { 1, 1, 0, 0 };
arr2[1] = new int[] { 1, 1, 1, 0 };
arr2[2] = new int[] { 0, 1, 1, 0 };
arr2[3] = new int[] { 0, 0, 0, 1 };
Console.WriteLine("Test 2");
Console.WriteLine(f.findCircleNum(arr2)); //2

int[][] arr3 = new int[5][];
arr3[0] = new int[] { 1, 0, 0, 0, 0 };
arr3[1] = new int[] { 0, 1, 0, 0, 0 };
arr3[2] = new int[] { 0, 0, 1, 0, 0 };
arr3[3] = new int[] { 0, 0, 0, 1, 0 };
arr3[4] = new int[] { 0, 0, 0, 0, 1 };
Console.WriteLine("Test 3");
Console.WriteLine(f.findCircleNum(arr3)); //5

int[][] arr4 = new int[4][];
arr4[0] = new int[] { 1, 0, 0, 1 };
arr4[1] = new int[] { 0, 1, 1, 0 };
arr4[2] = new int[] { 0, 1, 1, 1 };
arr4[3] = new int[] { 1, 0, 1, 1 };
Console.WriteLine("Test 4");
Console.WriteLine(f.findCircleNum(arr4)); //1
*/

//Binary Tree
/*Node b = new Node();
b.val = 1;
b.left = new Node();
b.left.val = 2;
b.right = new Node();
b.right.val = 3;
b.left.left = new Node();
b.left.left.val = 4;
b.left.right = new Node();
b.left.right.val = 5;
b.right.left = new Node();
b.right.left.val = 6;
b.right.right = new Node();
b.right.right.val = 7;

//DFS
BinarySearch bs = new BinarySearch();
Console.WriteLine("DFS");
Console.WriteLine(bs.DFS(b, 7));

//BFS
Console.WriteLine("BFS");
Console.WriteLine(bs.BFS(b, 7));

//Row Sum
Console.WriteLine("Row Sum");
bs.sumRow(b);
*/

//Exam
/*Exam e = new Exam();
List<int> ints = new List<int> { 4,2,3,1,1 };
Console.WriteLine("Test 1");
foreach (var item in e.findKthMinimumVulnerbility(3, 4, ints))
{
    Console.WriteLine(item);
}
*/
//Dynnamic Programming
/*DynamicProgramming d = new DynamicProgramming();
Console.WriteLine("Test 1");
Console.WriteLine(d.ClimbStairs(2)); //2
*/
//FindChange
/*DynamicProgramming f = new DynamicProgramming();

int[] coins = { 2};
int amount = 3;
Console.WriteLine("Test 1");
Console.WriteLine(f.CoinChange(coins, amount)); //3

Console.WriteLine("Test 2");
int[] coins2 = { 186, 419, 83, 408 };
int amount2 = 6249;
Console.WriteLine(f.CoinChange(coins2, amount2)); //20
*/

//Diagonal Traverse
/*Arrays a = new Arrays();
int[][] matrix = new int[3][];
matrix[0] = new int[] { 1, 2, 3 };
matrix[1] = new int[] { 4, 5, 6 };
matrix[2] = new int[] { 7, 8, 9 };

foreach (var item in a.DiagnolTraverse(matrix))
{
    Console.WriteLine(item);
}
*/

//Spiral Matrix
/*Arrays sp = new Arrays();
int[][] matrix = new int[3][];
matrix[0] = new int[] { 1, 2, 3 };
matrix[1] = new int[] { 4, 5, 6 };
matrix[2] = new int[] { 7, 8, 9 };

foreach (var item in sp.SpiralOrder(matrix))
{
    Console.WriteLine(item);
}

Console.WriteLine("Test 2");
int[][] matrix2 = new int[4][];
matrix2[0] = new int[] { 1, 2, 3, 4 };
matrix2[1] = new int[] { 5, 6, 7, 8 };
matrix2[2] = new int[] { 9, 10, 11, 12 };
matrix2[3] = new int[] { 13, 14, 15, 16 };

foreach (var item in sp.SpiralOrder(matrix2))
{
    Console.WriteLine(item);
}

Console.WriteLine("Test 3");
int[][] matrix3 = new int[5][];
matrix3[0] = new int[] { 1, 2, 3, 4, 5 };
matrix3[1] = new int[] { 6, 7, 8, 9, 10 };
matrix3[2] = new int[] { 11, 12, 13, 14, 15 };
matrix3[3] = new int[] { 16, 17, 18, 19, 20 };
matrix3[4] = new int[] { 21, 22, 23, 24, 25 };

foreach (var item in sp.SpiralOrder(matrix3))
{
    Console.WriteLine(item);
}
*/

//Pascals Triangle
/*Arrays p = new Arrays();

Console.WriteLine("Test 1");
foreach (var item in p.Generate(22))
{
    Console.WriteLine(string.Join(",", item));
}
*/
//Adding Binary
/* Arrays a = new Arrays();
Console.WriteLine("Test 1");
Console.WriteLine(a.AddBinary2("11", "1")); //100

Console.WriteLine("Test 2");
Console.WriteLine(a.AddBinary2("0", "1")); //1

Console.WriteLine("Test 3");
Console.WriteLine(a.AddBinary2("1111", "1111")); //10101
 */

 //StrStr
 /* Arrays str = new Arrays();
 Console.WriteLine("Test 1");
 Console.WriteLine(str.StrStr("words", "wo"));
 Console.WriteLine("Test 2");
 Console.WriteLine(str.StrStr("wowordswo", "words"));
  */

//LongestCommonPrefix
Arrays st = new Arrays();
string[] strs = {"ab","a"};
Console.WriteLine("Test 1");
Console.WriteLine(st.LongestCommonPrefix(strs));