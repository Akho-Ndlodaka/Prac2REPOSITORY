using NUnit.Framework;

namespace Oware.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            //ARRANGE
            House a = new House (int x, int y) // arranging House 

            //ACT

            a.ResetHouse()  //Reseting House to initial state

            //ASSERT
            
            Assert.Pass(4, h, GetCount(), "Each House has four seed");  //Testing if each as 4 seeds 
        }
    }
}
