using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SahTests
{
    [TestClass]
    public class SvastaTest
    {
        [TestMethod]
        public void TestEvent()
        {
            Adder a = new Adder();
            a.OnMultipleOfFiveReached += a_MultipleOfFiveReached;
            int iAnswer = a.Add(4, 3);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            iAnswer = a.Add(4, 6);
            Console.WriteLine("iAnswer = {0}", iAnswer);
            Console.ReadKey();
        }

        static void a_MultipleOfFiveReached(object sender, EventArgs e)
        {
            Console.WriteLine("Multiple of five reached!");
        }
    }
    
}

