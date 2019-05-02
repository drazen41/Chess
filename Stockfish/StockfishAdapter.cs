using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockfish
{
    public class StockfishAdapter
    {
        private IStockfishService engine;
        private short moveValidationTime = 1;
        private short deepAnalysisTime = 5000;
        private bool CheckMate = false;
        private StringBuilder moves = new StringBuilder();
        public StockfishAdapter(IStockfishService iss,bool newGame)
        {
            engine = iss;
            engine.EngineMessage += EngineMessage;
            engine.StartEngine(newGame);
        }
        public void AddMove(string move)
        {
            moves.Append(" " + move);
        }
        private void EngineMessage(string message)
        {
            if (message.Contains(UciCommands.bestmove)) // Message is in the form: bestmove <move> ponder <move>
            {
                if (!message.Contains("ponder")) CheckMate = true;
                var move = message.Split(' ').ElementAt(1);
                moves.Append(" " + move);
            }
        }
        private void ValidateMove()
        {
            SendMovesToEngine(moveValidationTime);
        }

        public void SendMovesToEngine(short time)
        {
            var command = UciCommands.position + moves.ToString();
            engine.SendCommand(command);
            command = UciCommands.go_movetime + " " + time.ToString();
            engine.SendCommand(command);
        }
    }
}
