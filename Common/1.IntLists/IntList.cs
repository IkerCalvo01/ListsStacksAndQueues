using System;

namespace Common
{
    public class IntListNode
    {
        public int Value;
        public IntListNode Next = null;
        

        public IntListNode(int value)
        {
            Value = value;
        }
    }

    public class IntList : IList
    {
        IntListNode First = null;
        IntListNode Last = null;
        int NumElements = 0;
        //This method returns all the elements on the list as a string
        //Use it as an example on how to access all the elements on the list
        public string AsString()
        {
            IntListNode node = First;
            
            
            string output = "[";

            while (node != null)
            {
                output += node.Value + ",";
                node = node.Next;
            }
            output = output.TrimEnd(',') + "] " + Count() + " elements";

            return output;
        }

        
        public void Add(int value)
        {
            //TODO #1: add a new integer to the end of the list
            if (First == null)
            {
               // IntList intList = new IntList();
                IntListNode first = new IntListNode(value);
                first.Next = null;
                First = first;
                Last = first;   
                NumElements++;
            }
            else
            {
                IntListNode second = new IntListNode(value);
                Last.Next = second;    
                second.Next = null; 
                Last=second; 
                NumElements++;
            }

        }

        private IntListNode GetNode(int index)
        {
            //TODO #2: Return the element in position 'index'
            int currentPos = 0;
            IntListNode currentNode = First;
            while(currentPos<index && currentNode.Next!=null)
            {
                currentNode = currentNode.Next; 
                currentPos++;

            }
            if (currentPos == index)
            {
                return currentNode;
            }
            else return null;


        }

        
        public int Get(int index)
        {
            //TODO #3: return the element on the index-th position. YOU MUST USE GetNode(int). O if the position is out of bounds
           if(index < NumElements && index >= 0)
            {

                IntListNode currentNode = GetNode(index);
                return currentNode.Value;   

            } else return 0;
        }

        
        public int Count()
        {
            //TODO #4: return the number of elements on the list
            return NumElements;
        }
        
        public void Remove(int index)
        {
            //TODO #5: remove the element on the index-th position. Do nothing if position is out of bounds
            if (index < 0 || index >= NumElements) return;
            IntListNode previous = GetNode(index - 1);
            IntListNode current = GetNode(index);
            IntListNode next = GetNode(index + 1);

            if (index < NumElements && previous != null && next != null)
            {
                current.Next = null;
                previous.Next = next;
                NumElements--;
            }
            else if (previous == null)
            {
                First = next;

                NumElements--;
            }
            else if (next == null)
            {
                previous.Next = null;
                Last = previous;
                NumElements--;
            }
                
                
         }
            
        

        
        public void Clear()
        {
            First = null;   
            Last = null;
            NumElements = 0;    
        }
    }
}