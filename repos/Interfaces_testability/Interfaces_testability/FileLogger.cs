using System.IO;

namespace Interfaces_testability
{
    public class FileLogger : IIlogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        public void Logerror(string message)
        {
            Log(message, "ERROR");
        }

        public void LogInfo(string message)
        {
            Log(message, "INFO");
        }

        private void Log(string message , string messageType)
        {
            using (var streamWriter = new StreamWriter(path, true)) // using  ===> if something goes wrong compiler close all open "connections" etc  - dispose behind the scene
            {
                streamWriter.WriteLine(messageType +  ": " + message);

            }
        }
    }
}
