using System;

namespace DesignPatterns
{
    // Adaptee class
    /*
     * Classe que será utilizada para substituir a classe Target.
     */
    public class LogNetMasterService : ILogNetMaster
    {
        public void LogInfo(string message)
        {
            Console.WriteLine("Log Customizado - " + message);
        }

        public void LogException(Exception exception)
        {
            Console.WriteLine("Log Customizado - " + exception.Message);
        }
    }
}