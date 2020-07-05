using System;
using System.Collections.Generic;

public class CStack
{
    #region Field
    private int p_index; //top item에 접근을 용이하게 만드는 index
    List<int> list; //ArrayList로 Stack ArrayList는 참고로 더이상 사용하는 걸 권장하지 않는다. List<T>써라.

    /// <summary>
    /// The size of the stack
    /// </summary>
    public int Count
    {
        get { return list.Count; }
    } 
    #endregion

    #region Methods
    /// <summary>
    /// a constructor
    /// </summary>
    public CStack()
    {
        list = new List<int>();
        p_index = -1; //why?
    }

    /// <summary>
    /// Push method
    /// </summary>
    /// <param name="item">the item to push to the stack</param>
    public void Push(object item)
    {
        list.Add(item);
        p_index++;//?
    }

    /// <summary>
    /// Pop method
    /// </summary>
    /// <returns>returns the object to pop</returns>
    public object Pop()
    {
        object obj = list[p_index];
        list.RemoveAt(p_index);
        p_index--;
        return obj;
    }

    /// <summary>
    /// method that clears the entire stack
    /// </summary>
    public void Clear()
    {
        list.Clear();
        p_index = -1;
    }

    /// <summary>
    /// Method that returns the top item in the stack
    /// </summary>
    /// <returns>the top item in the stack</returns>
    public object Peek()
    {
        return list[p_index];
    } 
    #endregion
}
