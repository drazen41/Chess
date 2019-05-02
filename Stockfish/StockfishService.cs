using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.IO;
using System.Reactive.Linq;
using System.Diagnostics;

namespace Stockfish
{
    public class StockfishService : IStockfishService
    {
        private StreamReader streamReader;
        private StreamWriter streamWriter;
        private Process engineProcess;
        private IDisposable engineListener;
        public event Action<string> EngineMessage;
        
        public void SendCommand(string command)
        {
            if (streamWriter != null && command != UciCommands.uci)
            {
                streamWriter.WriteLine(command);
            }
        }
        public void StopEngine()
        {
            if (engineProcess != null & !engineProcess.HasExited)
            {
                engineListener.Dispose();
                streamReader.Close();
                streamWriter.Close();
            }
        }
        public void StartEngine(bool newGame)
        {
            FileInfo engine = new FileInfo(Path.Combine(Environment.CurrentDirectory, "stockfish_10_x64.exe"));
            if (engine.Exists && engine.Extension == ".exe")
            {
                engineProcess = new Process();
                engineProcess.StartInfo.FileName = engine.FullName;
                engineProcess.StartInfo.UseShellExecute = false;
                engineProcess.StartInfo.RedirectStandardInput = true;
                engineProcess.StartInfo.RedirectStandardOutput = true;
                engineProcess.StartInfo.RedirectStandardError = true;
                engineProcess.StartInfo.CreateNoWindow = true;

                engineProcess.Start();

                streamWriter = engineProcess.StandardInput;
                streamReader = engineProcess.StandardOutput;

                engineListener = Observable.Timer(TimeSpan.Zero, TimeSpan.FromMilliseconds(1)).Subscribe(s => ReadEngineMessages());

                streamWriter.WriteLine(UciCommands.uci);
                streamWriter.WriteLine(UciCommands.isready);
                if (newGame)
                    streamWriter.WriteLine(UciCommands.ucinewgame);
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
        private void ReadEngineMessages()
        {
            var message = streamReader.ReadLine();
            if (message != string.Empty)
            {
                EngineMessage?.Invoke(message);
            }
        }
       
    }
}
