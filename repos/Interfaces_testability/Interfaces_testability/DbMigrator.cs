using System;

namespace Interfaces_testability
{


    public class DbMigrator
    {
        private readonly IIlogger logger;

        public DbMigrator(IIlogger logger)
        {
            this.logger = logger;
        }

        public void Migrate()
        {

            this.logger.LogInfo("Migration started at {0}" + DateTime.Now);
            
            //Details of migrating the database

            this.logger.LogInfo("Migration finished at {0}" + DateTime.Now);
        }
    }
}
