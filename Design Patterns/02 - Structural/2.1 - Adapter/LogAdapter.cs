using System;

namespace DesignPatterns
{
    // Adapter class
    public class LogAdapter : ILogger //utilizo a interface que a classe cliente utiliza
    {
        private readonly ILogNetMaster _logNetMaster; //Injeto a classe a de adaptação

        public LogAdapter(ILogNetMaster logNetMaster)
        {
            _logNetMaster = logNetMaster;
        }

        public void Log(string message) //método da interface ILogger
        {
            _logNetMaster.LogInfo(message); // utilizo a implementação da classe da adaptação.
        }

        public void LogError(Exception exception)
        {
            _logNetMaster.LogException(exception);
        }
    }
}