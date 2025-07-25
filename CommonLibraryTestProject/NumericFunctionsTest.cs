namespace CommonLibraryTestProject
{
    [TestFixture]   
    public class Tests
    {
        CommonLibrary.NumericFunctions numericFunctions  = null;
      
        
        [SetUp]
        public void Setup()
        {
            numericFunctions = new CommonLibrary.NumericFunctions();

        }

        [Test]
        public void AddTest1()
        {
          
          int actual =  numericFunctions.Add(2, 5);
          Assert.AreEqual(7, actual);
        }

        [Test]
        [Ignore("this test case is in process")]
        public void AddTest2()
        {

            int actual = numericFunctions.Add(10, 30);
            Assert.AreEqual(40, actual);
        }


         

        [Test]
        [Author("Jane Doe", "jane.doe@example.com")]
        
        public void AddTest3()
        {
            int actual = numericFunctions.Add(1, 1);
            Assert.AreEqual(2, actual);
        }

        [Test]
        public void AddTest4()
        {
            
            int actual = numericFunctions.Add(1, 1);
            Assert.AreEqual(3, actual);
        }

        [TestCase(1,2,3)]
        [TestCase(10,9, 19)]
        [TestCase(3,4,7)]
        public void AddTest5(int x, int y, int expected)
        {
            int actual = numericFunctions.Add(x, y);
            Assert.AreEqual(expected, actual);  
        }


        [TearDown]
        public void AA()
        {
            numericFunctions = null;
        }

    }
}