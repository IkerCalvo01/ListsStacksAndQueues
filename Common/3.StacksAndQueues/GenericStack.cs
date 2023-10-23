
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Common
{
    public class GenericStack<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class

        GenericList<T> list;
        
        GenericListNode<T> First = null;
        GenericListNode<T> Last = null;
        int numElements = 0;
        public GenericStack ()
        { 
            list = new GenericList<T> ();
            
            
        }


        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
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

        public int Count()
        {
            //TODO #3: Return the number of objects
            return list.Count();
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
            list.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            list.Add (value);
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it

            T top = default;
            int num = list.Count();
            top = list.Get(num-1);
            list.Remove(num-1);
            return top;
            
            
        }
    }
}