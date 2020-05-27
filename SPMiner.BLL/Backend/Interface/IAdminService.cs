using System;
using System.Collections.Generic;
using System.Text;

namespace SPMiner.BLL.Backend.Interface
{
    /// <summary>
    /// 後台使用者商業邏輯
    /// </summary>
    public interface IAdminService
    {
        Models.Entity.Admin GetAdmin();
    }
}
