namespace Common
{

    public class GenericQueue<T> : IPushPop<T>
    {
        //TODO #1: Declare a List inside this object class to store the objects. Choose the most appropriate object class
        GenericList<T> list;

        //GenericArrayList<T> array;

        public GenericQueue()
        {
            int n = 0;

            list = new GenericList<T>();
            //array = new GenericArrayList<T>(n);

        }

        public string AsString()
        {
            //TODO #2: Return the list as a string. Use the method already implemented in your list
            return list.AsString();
            //return array.AsString();
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
            list.Add(value);
            // array.Add (value);
        }

        public T Pop()
        {
            //TODO #6: Remove the first object of the list and return it
            T top = default(T);
            top = list.Get(0);
            list.Remove(0);
            return top;

            /* T topArray = default;
             int numArray = array.Count();
             topArray = list.Get(0);
             array.Remove(0);
             return topArray;
             */
            
        }
    }
}