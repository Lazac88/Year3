using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackClassUnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IsEmpty_StackWithZeroItems()
        {
            Stack myStack = new Stack();

            bool actual = myStack.isEmpty();

            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_StackThatUseToHaveItems()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Hi");

            myStack.Pop();
            myStack.Pop();

            bool actual = myStack.isEmpty();

            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsEmpty_StackThatHasItems()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Hi");

            bool actual = myStack.isEmpty();

            bool expected = false;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_StackThatHasNoItems_ErrorThrownTest()
        {
            Stack myStack = new Stack();
            bool errorThrown = false;

            try
            {
                String peekReturn = myStack.Peek();
            }
            catch(IndexOutOfRangeException ex)
            {
                errorThrown = true;
            }            

            bool expected = true;

            Assert.AreEqual(expected, errorThrown);
        }

        [TestMethod]
        public void Peek_StackThatHasOneItem_ErrorThrownTest()
        {
            Stack myStack = new Stack();
            String peekReturn;
            myStack.Push("Hello");
            bool errorThrown;

            try
            {
                peekReturn = myStack.Peek();
                errorThrown = false;
            }
            catch (IndexOutOfRangeException ex)
            {
                errorThrown = true;
            }

            bool expected = false;

            Assert.AreEqual(expected, errorThrown);
        }

        [TestMethod]
        public void Peek_StackThatHasMultipleItems_ErrorThrownTest()
        {
            Stack myStack = new Stack();
            String peekReturn;
            myStack.Push("Hello");
            myStack.Push("Friend");
            myStack.Push("Goodday");

            bool errorThrown;

            try
            {
                peekReturn = myStack.Peek();
                errorThrown = false;
            }
            catch (IndexOutOfRangeException ex)
            {
                errorThrown = true;
            }

            bool expected = false;

            Assert.AreEqual(expected, errorThrown);
        }

        [TestMethod]
        public void Peek_StackThatHasOneItem_CorrectStringReturnTest()
        {
            Stack myStack = new Stack();
            String actual;
            myStack.Push("Hello");

            actual = myStack.Peek();
            
            

            String expected = "Hello";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_StackThatHasMultipleItems_CorrectStringReturnTest()
        {
            Stack myStack = new Stack();
            String actual;
            myStack.Push("Hello");
            myStack.Push("Friend");
            myStack.Push("Goodday");

            actual = myStack.Peek();



            String expected = "Goodday";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Peek_StackThatHasMultipleItems_CountRemainsTheSame()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Friend");
            myStack.Push("Goodday");

            myStack.Peek();

            int actual = myStack.Count();

            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_StackThatHasNoItems()
        {
            Stack myStack = new Stack();            

            int actual = myStack.Count();

            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_StackThatHasOneItem()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");

            int actual = myStack.Count();

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_StackThatHasMultipleItems()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Friend");
            myStack.Push("Goodday");

            int actual = myStack.Count();

            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_StackThatUseToHaveItems()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Friend");
            myStack.Push("Goodday");

            myStack.Pop();
            myStack.Pop();
            myStack.Pop();

            int actual = myStack.Count();

            int expected = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pop_StackThatHasNoItems_ErrorThrownTest()
        {
            Stack myStack = new Stack();
            String peekReturn;
            bool errorThrown;

            try
            {
                peekReturn = myStack.Pop();
                errorThrown = false;
            }
            catch (IndexOutOfRangeException ex)
            {
                errorThrown = true;
            }

            bool expected = true;

            Assert.AreEqual(expected, errorThrown);
        }

        [TestMethod]
        public void Pop_StackThatHasOneItem_ErrorThrownTest()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            String peekReturn;
            bool errorThrown;

            try
            {
                peekReturn = myStack.Pop();
                errorThrown = false;
            }
            catch (IndexOutOfRangeException ex)
            {
                errorThrown = true;
            }

            bool expected = false;

            Assert.AreEqual(expected, errorThrown);
        }

        [TestMethod]
        public void Pop_StackThatHasMultipleItems_ErrorThrownTest()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Friend");
            myStack.Push("Goodday");
            String peekReturn;
            bool errorThrown;

            try
            {
                peekReturn = myStack.Pop();
                errorThrown = false;
            }
            catch (IndexOutOfRangeException ex)
            {
                errorThrown = true;
            }

            bool expected = false;

            Assert.AreEqual(expected, errorThrown);
        }

        [TestMethod]
        public void Pop_StackThatHasOneItem_CorrectStringReturnTest()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            String actual;

            actual = myStack.Pop();

            String expected = "Hello";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pop_StackThatHasMultipleItems_CorrectStringReturnTest()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Friend");
            myStack.Push("Goodday");
            String actual;
            
            actual = myStack.Pop();            

            String expected = "Goodday";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Pop_StackThatHasMultipleItems_CorrectCountReturnTest()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Friend");
            myStack.Push("Goodday");
            int actual;

            myStack.Pop();

            actual = myStack.Count();

            int expected = 2;

            Assert.AreEqual(expected, actual);
        }


        //Checks a stack that had items and then removed more than the number of items
        [TestMethod]
        public void Pop_StackThatUseToHaveItems_CorrectErrorReturnTest()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Friend");
            bool errorThrown;

            try
            {
                myStack.Pop();
                myStack.Pop();
                myStack.Pop();
                errorThrown = false;
            }
            catch (IndexOutOfRangeException ex)
            {
                errorThrown = true;
            }

            bool expected = true;

            Assert.AreEqual(expected, errorThrown);
        }

        [TestMethod]
        public void Push_StackThatHasOneItemPushed_CorrectCountReturnTest()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");

            int actual = myStack.Count();

            int expected = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Push_StackThatHasMultipeItemsPushed_CorrectCountReturnTest()
        {
            Stack myStack = new Stack();
            myStack.Push("Hello");
            myStack.Push("Friend");
            myStack.Push("Goodday");

            int actual = myStack.Count();

            int expected = 3;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Push_StackThatHasMoreThanLimitPushed_CorrectErrorReturnTest()
        {
            Stack myStack = new Stack();

            bool errorThrown;

            try
            {
                for (int i = 0; i < 105; i++)
                {
                    myStack.Push("Hello");
                }
                errorThrown = false;
            }
            catch (IndexOutOfRangeException ex)
            {
                errorThrown = true;
            }
            catch(OverflowException ex)
            {
                errorThrown = true;
            }

            bool expected = true;

            Assert.AreEqual(expected, errorThrown);
        }

        [TestMethod]
        public void Push_NullStringSendToPushTest()
        {
            Stack myStack = new Stack();
            String nullString = null;
            bool errorThrown;

            try
            {
                myStack.Push(nullString);
                errorThrown = false;
            }
            catch(ArgumentNullException)
            {
                errorThrown = true;
            }           

            bool expected = true;

            Assert.AreEqual(expected, errorThrown);
        }

        [TestMethod]
        public void Push_OneItemInStack_CheckNewStringIsAdded()
        {
            Stack myStack = new Stack();
            String expected = "Banana";

            myStack.Push(expected);

            String actual = myStack.Peek();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Push_MultipleItemsInStack_CheckNewStringIsAdded()
        {
            Stack myStack = new Stack();
            String expected = "Banana";

            myStack.Push("Hello");
            myStack.Push("Friend");
            myStack.Push(expected);

            String actual = myStack.Peek();

            Assert.AreEqual(expected, actual);
        }
    }
}
