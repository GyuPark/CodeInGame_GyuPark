Basic Searching Algorithms

This chapter looks at just one aspect of the search problem - searching for a given value in a list(array).
There are two fundamental ways to search for data in a list : 
the sequential search,
and the binary search.

Sequential search is used when the items in the list are in random order;
binary search is used when the items are sorted in the list.


#Sequential Search
The type of search that begins at the beginning of a set of records and move through each record 
until you find the record you are looking for or you come to the end of the records is called a sequential search.


//A function that performs a sequential search :
bool SeqSearch(int[] arr, int sValue)
{
	for (int index = 0; index < arr.Length-1; index++)
	{
		if (arr[index] == sValue)
		{
			return true;
		}
		return false;
	}
}





#Binary Search
To use this algorithm, we first need our data stored in order(ascending, preferably).
The first step in the algorithm is to set the lower and upper bounds of the search.
Then, we calculate the midpoint of the array by adding the lower and upper bounds together
and dividing by 2. 미드포인트로 계속 조져나가는 알고리즘.








#Summary

Searching a data set for a value is a ubiquitous computational operation.
Sequential search method works best when the data set is relatively small and unordered.
If the data is ordered, however, the binary search algorithm is a better choice. 
Binary search works by continually subdividing the data set until the item being searched for is found.
You can write the binary search algorithm using both iterative and recursive codes.