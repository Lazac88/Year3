using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackTester
{
    public class Stack
    {
        private const int MAX_ARRAY = 100;

        private String[] myArray;

        private int stackCount;
        private int lastEntry;

        public Stack()
        {
            myArray = new String[MAX_ARRAY];
            stackCount = 0;
            lastEntry = -1;
        }

        public void Push(String newString)      //Adds new string to the stack
        {
            if(newString == null)
            {
                //throw new ArgumentNullException("String Entered Was Null Field");
                throw new ArgumentException("String Entered Was Null Field");
            }

            try
            {
                myArray[stackCount] = newString;
                stackCount++;
                lastEntry++;
            }
            catch(IndexOutOfRangeException ex)
            {
                throw new IndexOutOfRangeException("Too many items in stack");
            }
            catch(OverflowException)
            {
                throw new OverflowException("String too large");
            }
            
        }

        public String Pop()                     //Returns the most recently added string and removes it from the stack
        {
            if(!IsEmpty())
            {
                string lastAdded = myArray[lastEntry];
                myArray[lastEntry] = null;
                stackCount--;
                lastEntry--;
                return lastAdded;
            }
            else
            {
                //throw new IndexOutOfRangeException("The Stack is Currently Empty");
                throw new Exception("The Stack is Currently Empty");
            }
            
        }

        public String Peek()                    //Returns the most recently added string, but does not remove it
        {
            if(!IsEmpty())
            {
                return myArray[lastEntry];
            }
            else
            {
                //throw new IndexOutOfRangeException("The Stack is Currently Empty");
                throw new Exception("The Stack is Currently Empty");
            }
        }

        public int Count()                      //Returns the number of strings currently held in the stack
        {
            return stackCount;
        }

        public bool IsEmpty()                   //Returns true if the stack contains zero elements, or false otherwise.
        {
            int stackNumber = Count();
            if (stackNumber == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}
