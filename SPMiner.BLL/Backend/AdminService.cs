using SPMiner.BLL.Backend.Base;
using SPMiner.BLL.Backend.Interface;
using SPMiner.Models.Entity;
using System.Linq;

namespace SPMiner.BLL.Backend
{
    public class AdminService : BaseService, IAdminService
    {
        public AdminService(SpminerContext spminerContext) : base (spminerContext)
        {

        }

        public Admin GetAdmin()
        {
            var result = this._dbContext.Admins.Where(x => x.Id == 1).FirstOrDefault();

            return result;
        }
    }
}
