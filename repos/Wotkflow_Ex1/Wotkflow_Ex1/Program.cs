using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wotkflow_Ex1
{

    public class FileLogger : ILogger
    {
        private readonly string path;

        public FileLogger(string path)
        {
            this.path = path;
        }

        public void LogError(string message)
        {
            using (var strinwriter = new StringWriter(path, true))
            {
                strinwriter.WriteLine(message);
            }
                
        }

        public void LogInfo(string message)
        {
            throw new System.NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var createDocument = new CreateDocument(new ConsoleLogger());
            createDocument.Create();
        }
    }
}
