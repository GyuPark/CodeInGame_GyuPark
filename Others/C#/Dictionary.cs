<Dictionary>


<Dictionaries>

Unique to lists, because they are associated by key value pairs.

[System.Serializable]
public class Item
{
    public string name;
    public int id;
    public Sprite icon;
}


public class ItemDB : MonoBehaviour
{
    public Dictionary<int, Item> itemDictionary = new Dictionary<int, Item>();

    private void Start()
    {
        Item sword = new Item();
        sword.name = "Sword";
        sword.id = 0;

        Item bread= new Item();
        bread.name = "Bread";
        bread.id = 1;

        Item cape = new Item();
        cape.name = "Cape";
        cape.id = 2;

        //how to add items
        itemDictionary.Add(0, sword); //Dictionary<TKey,TValue>.Add(TKey, TValue)
        itemDictionary.Add(1, bread); 
        itemDictionary.Add(2, cape);

        //iterate through both values and pairs
        foreach (KeyValuePair<int, Item> item in itemDictionary)
        {
            Debug.Log("Key : " + item.Key);
            Debug.Log("Value : " + item.Value.name);
        }

        //iterate through either values or pairs
        foreach (var key in itemDictionary.Keys)
        {
            Debug.Log("Key : " + key);
        }
        foreach (Item item in itemDictionary.Values)
        {
            Debug.Log("Key : " + item);
        }
    }
}

When to use Dictionaries?

Large lists - rpg shop systems bunch of itmes, 
purchase system - buy an id ... don't have to iterate through item DB


