//Basic Sorting Algorithms


This chapter introduces you to the techniques we'll use throughout the
book to informally analyze different algorithms for speed and efficiency.
Most of the data we work with in our day-to-day lives is sorted.

We should first study some simple sorting algorithms like insertion sort, the bubble sort,
and the selection sort, before we explore more sophisticated ones.

The simple sorting algorithms are not the best overall algorithms for sorting by any means,
but for small data sets and in other special circumstances, they are the best algorithms to use.



class CArray 
{	
	//field 세 개
	private int[] arr;
	private int upper;
	private int numElements;
	
	public CArray(int size) //array 생성 및 변수 할당 함수
	{
		arr = new int[size];
		upper = size-1;
		numElements = 0;
	}
	
	public void Insert(int item) //item 받아다가 array에 집어넣는 함수 ... loop 가능
	{
		arr[numElements] = item;
		numElements++;
	}
	
	public void DisplayElements() //array elements를 directly access하여 출력
	{ 
		for (int i = 0; i <= upper; i++)
		{
			Console.Write(arr[i]+" ");
		}
	}
	
	public void Clear() 
	{
		for(int i =0; i<= upper; i++)
		{
			arr[i] = 0;
		}
		numElements = 0;
	}
}


static void Main()
{
	CArray nums = new CArray();
	for (int i = 0 ; i <= 49 ; i++)
	{
		nums.Insert(i);
	}
	nums.DisplayElements();
}



#Bubble Sort
The bubble sort is one of the slowest sorting algorithms available, 
but it is also one of the simplest of the sorts to understand and implement.
The sort gets its name because values "float like a bubble" from one end of the list to another. 
Assuming you are sorting in ascending order, higher values float to the right whereas lower values float to the left.
This behaviour is caused by moving through the list many times, comparing adjacent values and swapping them if ~.



#Selection Sort
Works by starting at the beginning of the array, comparing the first element with the other elements in the array.
The smallest element is placed in position 0, and the sort then begins again at position 1.
This continues until each position except the last position has been the starting point for a new loop.*



#Insertion Sort
This is an analogue way to sort things alphabetically or numerically.
Insertion sort works not by making exchanges, but by moving larger array elements to the right 
to make room for smaller elements on the left side of the array. 




%Time Comparisons

The three sorting algorithms are very similar in complexity and theoretically, at least, should perform
similarly when compared with each other. We can see that the effect of array size on the three algorithms.
As the array gets bigger in size, the performance of all three algorithms degrades considerably, though the
Selection sort is still many times faster than the other two. Clearly, none of these algorithms is ideal
for soring large data sets. 






-------------------
All of these algorithms work fairly well with small data sets. 
The Selection sort is the most effcient of the three, followed by the Bubble sort and the Insertion sort.
However, none of these algorithms are well suited for large data sets(i.e., more than a few thousand elements). 