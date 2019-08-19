using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calctest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int Num1 = 2;
            int Num2 = 5;
            int Multiplication == Num1*Num2;
            //string testresult;
            try
            {
                Multiplication = 20;
            }
            catch (Exception)
            {
            }

        }
    }
}
