using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackTester;

namespace UnitTestProject1
{
    /// <summary>
    ///This is a test class for StackTest and is intended
    ///to contain all StackTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StackTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        [TestMethod()]
        public void Stack_IsEmpty_NewStackReturnsTrue()
        {
            Stack testStack = new Stack();
            bool isEmpty = testStack.IsEmpty();
            Assert.IsTrue(isEmpty);
        }

        [TestMethod()]
        public void Stack_IsEmpty_OldEmptyStackReturnsTrue()
        {
            Stack testStack = new Stack();
            testStack.Push("Bob");
            String topValue = testStack.Pop();

            bool isEmpty = testStack.IsEmpty();
            Assert.IsTrue(isEmpty);
        }

        [TestMethod()]
        public void Stack_IsEmpty_SingleItemReturnsFalse()
        {
            Stack testStack = new Stack();
            testStack.Push("Bob");

            bool isEmpty = testStack.IsEmpty();
            Assert.IsFalse(isEmpty);
        }

        [TestMethod()]
        public void Stack_IsEmpty_MultiItemsReturnsFalse()
        {
            Stack testStack = new Stack();
            testStack.Push("Bob");
            testStack.Push("Fred");

            bool isEmpty = testStack.IsEmpty();
            Assert.IsFalse(isEmpty);
        }

        //=====================================================


        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void Stack_Peek_NewStackThrowsException()
        {
            Stack testStack = new Stack();
            String peekValue = testStack.Peek();
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void Stack_Peek_OldEmptyStackThrowsException()
        {
            Stack testStack = new Stack();

            testStack.Push("Bob");
            String popValue = testStack.Pop();
            String peekValue = testStack.Peek();
        }

        [TestMethod()]
        public void Stack_Peek_MultItemsReturnsMostRecentItem()
        {
            Stack testStack = new Stack();

            testStack.Push("Bob");
            testStack.Push("Fred");
            String peekValue = testStack.Peek();
            Assert.AreEqual("Fred", peekValue);
        }

        [TestMethod()]
        public void Stack_Peek_MultItemsDoesntDeleteTop()
        {
            Stack testStack = new Stack();

            testStack.Push("Bob");
            testStack.Push("Fred");
            String peekValue = testStack.Peek();
            peekValue = testStack.Peek();
            Assert.AreEqual("Fred", peekValue);
        }

        [TestMethod()]
        public void Stack_Peek_MultItemsDoesntChangeCount()
        {

            // Good example of why tests should fail first.
            // If you do:
            //  Push, push
            //  Read count => oldcount
            //  Peek, Peek
            //  Read count => newcount
            // Assert oldCount == newCount
            // This will pass even if count hasn't been implemented. Or if count returns -1.
            // This indicates that your test logic is not a good test of the intention.
            // Modify so it fails, as shown.


            Stack testStack = new Stack();
            String peekValue = "";

            testStack.Push("Bob");
            testStack.Push("Fred");

            peekValue = testStack.Peek();
            peekValue = testStack.Peek();

            int countAfterPeeking = testStack.Count();

            Assert.AreEqual(2, countAfterPeeking);
        }

        //=====================================================

        [TestMethod()]
        public void Stack_Count_NewStackReturnsZero()
        {
            Stack testStack = new Stack();
            int newStackCount = testStack.Count();
            Assert.AreEqual(0, newStackCount);
        }

        [TestMethod()]
        public void Stack_Count_OldEmptyStackReturnsZero()
        {
            Stack testStack = new Stack();
            testStack.Push("Bob");
            testStack.Pop();
            int oldStackCount = testStack.Count();
            Assert.AreEqual(0, oldStackCount);
        }

        [TestMethod()]
        public void Stack_Count_MultiItemReturnsCorrectCount()
        {
            Stack testStack = new Stack();

            for (int i = 0; i < 3; i++)
                testStack.Push("Bob");

            int stackCount = testStack.Count();
            Assert.AreEqual(3, stackCount);
        }

        [TestMethod()]
        public void Stack_Count_SingleItemReturnsCorrectCount()
        {
            Stack testStack = new Stack();
            testStack.Push("Bob");

            int stackCount = testStack.Count();
            Assert.AreEqual(1, stackCount);
        }

        //=====================================================

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void Stack_Pop_NewStackThrowsException()
        {
            Stack testStack = new Stack();
            String popValue = testStack.Pop();
        }

        [TestMethod()]
        [ExpectedException(typeof(Exception))]
        public void Stack_Pop_OldEmptyStackThrowsException()
        {
            Stack testStack = new Stack();
            testStack.Push("Bob");
            String popValue = testStack.Pop();
            popValue = testStack.Pop();

        }

        [TestMethod()]
        public void Stack_Pop_MultiItemsReturnsLastIn()
        {
            // Note how helpful it is to be able to run this to check the logic
            // of index management in pop...

            Stack testStack = new Stack();

            testStack.Push("Barney");
            testStack.Push("Fred");
            testStack.Push("Betty");
            testStack.Push("Wilma");

            string popValue = testStack.Pop();
            Assert.AreEqual("Wilma", popValue);
        }

        [TestMethod()]
        public void Stack_Pop_MultiItemsReducesCount()
        {
            Stack testStack = new Stack();

            testStack.Push("Barney");
            testStack.Push("Fred");
            testStack.Push("Betty");
            testStack.Push("Wilma");
            int oldCount = testStack.Count();

            string popValue = testStack.Pop();
            int newCount = testStack.Count();
            Assert.AreEqual(oldCount - 1, newCount);
        }

        [TestMethod()]
        public void Stack_Pop_SingleItemReturnsLastIn()
        {
            Stack testStack = new Stack();
            testStack.Push("Fred");

            string popValue = testStack.Pop();
            Assert.AreEqual("Fred", popValue);
        }

        [TestMethod()]
        public void Stack_Pop_SingleItemMakesIsEmptyTrue()
        {
            Stack testStack = new Stack();
            testStack.Push("Fred");
            string popValue = testStack.Pop();
            bool isEmpty = testStack.IsEmpty();
            Assert.IsTrue(isEmpty);
        }

        [TestMethod()]
        public void Stack_Pop_MultiItemsRemovesTopItem()
        {
            Stack testStack = new Stack();

            testStack.Push("Barney");
            testStack.Push("Fred");
            testStack.Push("Betty");
            testStack.Push("Wilma");

            string popValue = testStack.Pop();
            string peekValue = testStack.Peek();
            Assert.AreEqual("Betty", peekValue);
        }

        //=====================================================

        [TestMethod()]
        public void Stack_Push_EmptyStackTakesNewItem()
        {
            Stack testStack = new Stack();
            testStack.Push("Barney");
            string peekValue = testStack.Peek();
            Assert.AreEqual("Barney", peekValue);
        }

        [TestMethod()]
        public void Stack_Push_EmptyStackCountGoesToOne()
        {
            Stack testStack = new Stack();
            testStack.Push("Barney");
            int count = testStack.Count();
            Assert.AreEqual(1, count);
        }

        [TestMethod()]
        public void Stack_Push_SingleItemTakesNewItem()
        {
            Stack testStack = new Stack();
            testStack.Push("Barney");
            testStack.Push("Fred");

            string peekValue = testStack.Peek();
            Assert.AreEqual("Fred", peekValue);
        }

        [TestMethod()]
        public void Stack_Push_SingleItemCountGoesToTwo()
        {
            Stack testStack = new Stack();
            testStack.Push("Barney");
            testStack.Push("Fred");
            int count = testStack.Count();
            Assert.AreEqual(2, count);
        }

        [TestMethod()]
        public void Stack_Push_MultiItemsTakesNewItem()
        {
            Stack testStack = new Stack();

            testStack.Push("Barney");
            testStack.Push("Fred");
            testStack.Push("Betty");
            testStack.Push("Wilma");

            string peekValue = testStack.Peek();
            Assert.AreEqual("Wilma", peekValue);

        }

        [TestMethod()]
        public void Stack_Push_MultiItemsCountGoesToNPlusOne()
        {
            Stack testStack = new Stack();

            testStack.Push("Barney");
            testStack.Push("Fred");
            testStack.Push("Betty");

            int oldCount = testStack.Count();

            testStack.Push("Wilma");

            int newCount = testStack.Count();

            Assert.AreEqual(oldCount + 1, newCount);
        }

        [TestMethod()]
        public void Stack_Push_AddAndRemoveMultiInCorrectOrder()
        {
            Stack testStack = new Stack();

            testStack.Push("Barney");
            testStack.Push("Fred");
            testStack.Push("Betty");
            testStack.Push("Wilma");

            string popValues = "";

            // Oops here's a logical error in the test.
            // Rereading Count breaks as items are popped
            //for (int i = 0; i < testStack.Count(); i++)
            // popValues += testStack.Pop();

            int totalCount = 4;
            for (int i = 0; i < totalCount; i++)
                popValues += testStack.Pop();

            Assert.AreEqual("WilmaBettyFredBarney", popValues);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void Stack_Push_NullThrowsException()
        {
            Stack testStack = new Stack();
            testStack.Push(null);
        }

    }

}
