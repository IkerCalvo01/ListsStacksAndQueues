using Common;
using System.Collections.Concurrent;

public class GenericListNode<T>
{
    public T Value;
    public GenericListNode<T> Next = null;

    public GenericListNode(T value)
    {
      Value = value;
    }

    public override string ToString()
    {
      return Value.ToString();
    }
}

public class GenericList<T> : IGenericList<T>
{
    GenericListNode<T> First = null;
    GenericListNode<T> Last = null;
    int numElements = 0;

    public string AsString()
    {
      GenericListNode<T> node = First;
      string output = "[";

      while (node != null)
      {
        output += node.ToString() + ",";
        node = node.Next;
      }
      output = output.TrimEnd(',') + "] " + Count() + " elements";
      
      return output;
    }

    public void Add(T value)
    {
        //TODO #1: add a new element to the end of the list
        if (First == null)
        {
            GenericListNode<T> first = new GenericListNode<T>(value);
            first.Next = null;
            First = first;
            Last = first;
            numElements++;
        }
        else
        {
            GenericListNode<T> element = new GenericListNode<T>(value);
            Last.Next = element;
            Last = element;
            numElements++;
        }
    }

    public GenericListNode<T> FindNode(int index)
    {
        //TODO #2: Return the element in position 'index'
        int currentPos = 0;
        GenericListNode<T> currentNode = First;
        while (currentPos < index && currentNode.Next != null)
        {
            currentNode = currentNode.Next;
            currentPos++;
        }
        if (currentPos == index) return currentNode;
        return null;
    }

    public T Get(int index)
    {
        //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). Return the default value for object class T if the position is out of bounds
        if (index < 0 || index >= numElements) return default(T);
        if (index < numElements)
        {
            GenericListNode<T> currentNode = FindNode(index);
            return currentNode.Value;
        }
        return default(T);
    }
    public int Count()
    {
        //TODO #4: return the number of elements on the list

        return numElements;
    }


    public void Remove(int index)
    {
        //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
        if (index < 0 || index >= numElements) return;

        GenericListNode<T> currentNode = FindNode(index);
        GenericListNode<T> previousNode = FindNode(index - 1);
        GenericListNode<T> nextNode = FindNode(index + 1);

        if (currentNode == null) return;

        if (index < numElements && previousNode != null && nextNode != null)
        {
            currentNode.Next = null;
            previousNode.Next = nextNode;
            numElements--;
        }
        else if (previousNode == null)
        {
            First = nextNode;
            numElements--;
        }
        else if (nextNode == null)
        {
            previousNode.Next = null;
            Last = previousNode;
            numElements--;
        }
           
    }

    public void Clear()
    {
        //TODO #6: remove all the elements on the list
        First = null;
        Last = null;
        numElements = 0;
    }
}