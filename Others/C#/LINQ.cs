<LINQ>



<LINQ>

Stands for Language Integrated Query

it allows for filtering through data...

using System.Linq;

public class LinqExample : MonoBehaviour
{
    public string[] names = { "jon", "alex", "julie", "jessie", "david", "mark", "matt" };
    public string[] namesWithDuplicates = { "jon", "jon", "alex", "julie", "jessie", "david", "jessie", "mark", "matt" };


    private void Start()
    {
        var nameFound = names.Any(name => name == "jon"); //checks if there is 'jon' in the array.
        Debug.Log("NameFound: " + nameFound);

        //foreach (var name in name)
        //{
        //    if (name == "jon")
        //    {
        //        Debug.Log("Found Jon"); 
        //    }
        //}

        var nameFoundd = name.Contains("Hjo"); // returns true or false

        var uniqueNames = names.Distinct(); //returns a new collection with duplicates removed...
        foreach (var name in uniqueNames)
        {
            Debug.Log(name);
        }

        //5글자 이상의 이름만 추려서 모으기
        var result = names.Where(n => n.Length > 5); //filters elements from the original collection using conditions and returns a new derivative collection of the filtered elements.
    }
}


Challenge

using System.Linq;

[System.Serializable]
public class Item
{
    public string name;
    public int itemID;
    public int buff;    
}
public class LinqChallenge : MonoBehaviour
{
    public List<Item> items;

    private void Start()
    {
        for (int i = 0; i < items.Count; i++)
        {
            items[i].itemID = i;
            items[i].buff = Random.Range(0,50);
        }

        //checks if there is an item with itemID 7
        var searchResult = items.Any(items => items.itemID == 7);
        Debug.Log(searchResult);

        //organize a new list of items with buff size greater than 20, and then print its elements in a descending order
        var result = items.Where(n => n.buff > 20).OrderByDescending(n => n.buff);
        foreach (var items in result)
        {
            Debug.Log(items.buff);
        }

        //and then print its average
        Debug.Log(result.Average(n => n.buff));
    }
}

How to read and convert query syntax :
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/

