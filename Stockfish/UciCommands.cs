using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stockfish
{
    public class UciCommands
    {
        // Commands to engine
        // ==================
        public const string uci = "uci";
        public const string isready = "isready";
        public const string ucinewgame = "ucinewgame";
        public const string position = "position startpos moves";
        public const string go_movetime = "go movetime";
        public const string stop = "stop";

        // Commands from engine
        // ====================
        public const string uciok = "uciok";
        public const string readyok = "readyok";
        public const string bestmove = "bestmove";
    }
}
