using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RadzenBlazorPOC.Server.Extensions;
using RadzenBlazorPOC.Shared;

namespace RadzenBlazorPOC.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ConfigurationController : ControllerBase
    {
        [HttpGet("GetConfigurations")]
        public ActionResult<IEnumerable<Configuration>> GetConfigurations()
        {
            return Ok(ConfigurationMock.GetConfigurations().ToArray());
        }

        [HttpGet("GetConfigurationGroup")]
        public ActionResult<IEnumerable<ConfigurationGroup>> GetConfigurationGroup()
        {
            return Ok(ConfigurationMock.GetConfigurationGroups().ToArray());
        }

        [HttpGet("GetConfigurationTheme")]
        public IEnumerable<Theme> GetConfigurationTheme()
        {
            return ConfigurationMock.GetConfigurationTheme().ToArray();
        }
    }
}
