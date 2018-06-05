namespace Wotkflow_Ex1
{

    public class CreateDocument
    {
        private readonly ILogger logger;

        public CreateDocument(ILogger logger)
        {
            this.logger = logger;
        }

        public void Create()
        {
            this.logger.LogInfo("Starting add the document");
            
            ///Details to Create Document

            this.logger.LogInfo("Document added");
        }
    }
}
