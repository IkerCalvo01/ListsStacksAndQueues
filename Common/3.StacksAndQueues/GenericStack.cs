
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace Common
{
    public class GenericStack<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class

        GenericList<T> list;
       
        //GenericArrayList<T> array; 
        
        
        public GenericStack ()
        {
            int n = 0;

            list = new GenericList<T> ();
            //array = new GenericArrayList<T>(n);
            
        }


        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list

            return list.AsString();
            //return array.AsString ();
        }

        public int Count()
        {
            //TODO #3: Return the number of objects
            return list.Count();
           // return array.Count();
        }

        public void Clear()
        {
            //TODO #4: Remove all objects stored
            list.Clear();
           // array.Clear();
        }

        public void Push(T value)
        {
            //TODO #5: Add a new object to the list (at the end of it)
            list.Add (value);
           // array.Add (value);
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it

            T top = default;
            int num = list.Count();
            top = list.Get(num-1);
            list.Remove(num-1);
            return top;

           /* T topArray = default;
            int numArray = array.Count();
            topArray = list.Get(numArray-1);
            array.Remove(numArray-1);
            return topArray;
            */
            
            
        }
    }
}