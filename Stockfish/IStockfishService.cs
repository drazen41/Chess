using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockfish
{
    public interface IStockfishService
    {
        void StartEngine(bool newGame);
        void StopEngine();
        void SendCommand(string command);
        event Action<string> EngineMessage;
    }
}
