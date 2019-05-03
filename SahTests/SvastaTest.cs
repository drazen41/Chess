using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

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
        [TestMethod]
        public void TestFibo()
        {
           Console.WriteLine(Fibo(11));
        }
        static void a_MultipleOfFiveReached(object sender, EventArgs e)
        {
            Console.WriteLine("Multiple of five reached!");
        }
        static long Fibo(int broj)
        {
            long i = 0;
            long j = 1;
            long rez = 0;
            for (int k = 2; k < broj; k++)
            {
                rez = i + j;
                i = j;
                j = rez;
            }
            return rez;
        }
        static void Nit()
        {
            //Thread thread = ThreadFactory
        }
    }
    
}

