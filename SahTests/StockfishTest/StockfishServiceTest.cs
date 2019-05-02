using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Stockfish;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace SahTests.StockfishTest
{
    [TestClass]
    public class StockfishServiceTest
    {
        [TestMethod]
        public void StartEngine()
        {
            StockfishService stockfishService = new StockfishService();
            stockfishService.StartEngine(true);

        }
        [TestMethod]
        public void SendMovesToEngine()
        {
            StockfishService stockfishService = new StockfishService();
            //stockfishService.StartEngine(true);
            //stockfishService.SendCommand("uci");
            //stockfishService.StartEngine(true);

            StockfishAdapter stockfishAdapter = new StockfishAdapter(stockfishService, true);
            stockfishAdapter.AddMove("e2e4");
            stockfishAdapter.SendMovesToEngine(5000);
            Thread.Sleep(5000);
            
        }
        
    }
}
