using Microsoft.AspNetCore.Mvc;
using SPMiner.BLL.Backend.Interface;

namespace SPMiner.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        /// <summary>
        /// 後台使用者商業邏輯
        /// </summary>
        private IAdminService _adminService;

        public WeatherForecastController(IAdminService adminService)
        {
            this._adminService = adminService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var admin = this._adminService.GetAdmin();

            return Ok(admin);
        }
    }
}
