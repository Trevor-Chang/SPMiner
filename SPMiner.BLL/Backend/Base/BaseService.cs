using SPMiner.Models.Entity;

namespace SPMiner.BLL.Backend.Base
{
    public class BaseService
    {
        public SpminerContext _dbContext;

        public BaseService(SpminerContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
