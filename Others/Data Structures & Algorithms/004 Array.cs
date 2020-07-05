//Array
https://docs.microsoft.com/en-us/dotnet/api/system.array?view=netframework-4.8

/*
The array is the (most common) data structure, present in nearly all programming languages.
ArrayList is an interesting alternative to using arrays in C#, for it (can grow dynamically) as more space is needed.
The Array provides (several properties for retrieving metadata) about an array : Length, GetLength, Rank, GetType 
*/

type[] arrayName;

string[] names;
name = new string[length]; // A second line is required.

string[] names = new string[length]; //is also correct
int[] numbers = new int[] {1,2,3,4,5}; //is also possible, and you don't have to specify the number of elements.



/*
In C#, an array can have up to 32 dimensions, though arrays with more than three dimensions are very rare.
Multidemensional arrays are declared by providing (the upper bound of each of the dimensions) of the array.
*/

//declares a two-dimensional array that consists of 4 rows and 5 coloumns.
int [,] grades = new int[4,5]; //index 가 아니라 길이의 값임.

//When you initialise an array with an initialisation list, you can't specify the bounds of the array.
int[,] grades = new int[,]{{1, 82, 74, 89, 100},
                           {2, 93, 96, 85, 86},
						   {3, 83, 72, 95, 89},
						   {4, 91, 98, 79, 88}}


//It is a common operation to (perform calculations on all the elements of) a multi-dimensional array.
//총점 구하기
using System;					
public class Program
{
	public static void Main()
	{
		int[,] grades = new int[,]{{1,10,20,30},
								   {2,10,20,30},
								   {3,10,20,30}};
		
		int last_grade = grades.GetUpperBound(1);
		int last_student = grades.GetUpperBound(0);
		public int total = 0;
		
		for (int row=0; row<=last_student; row++)
		{
			for (int col=1; col<=last_grade; col++)
			{
				total += grades[row,col];
			}
		}
		Console.WriteLine(total);
	}
}


//Use a construct called "parameter array" to to write a method definition that allows an optional number of parameters.
static int sumNums(params int[] nums)
{
	int sum = 0;
	for(int i =0; i <= nums.GetUpperBound(0); i++)
		sum += nums[i];
	return sum;
}
//이렇게 활용이 가능하다.
total = sumNums(1, 2, 3);
total = sumNums(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);



/*
<Jagged Array>
When you create a multidimensional array, 
you always create a structure that has the (same number of elements in each of the rows).
But depending on how you decide to fill them, some arrays will have several empty elements. 
This is going to be problematic in case of a large array, for it will be left with a lot of wasted space.
*/

int sales[,] = new int[12,30]; //stores daily sales data for twelve months. Each rows in this array has 30 columns. But some months have 29 or 31 days.

/*
The solution to this problem is to use a jagged array instead of a two-dimensional array.
A jagged array is an (array of arrays where each row of an array is made up of an array).
Each dimension of a jagged array is a one-dimensional array. 
We call it a “jagged” array because the number of elements in each row may be different. 
A picture of a jagged array would not be square or rectangular, but would have uneven or jagged edges.
*/

int[][] jagged = new int[12][];
jagged[0][0] = 31; //First element of the first array
jagged[0][1] = 13; //Second element of the first array
jagged[7][5] = 45; //Sixth element of the eighth array

int[] Jan = new int[31];
int[] Feb = new int[29];
int[][] sales = new int{Jan,Feb};


























