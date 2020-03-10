
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Newtonsoft.Json;
using SPA_Angular_Demo.Models;
using SPA_Angular_Demo.Models.DataFactory;

namespace SPA_Angular_Demo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NFLController : ControllerBase
    {
        private INFLManager _nflManager;

        public NFLController(INFLManager nflManager = null)
        {
            _nflManager = nflManager != null ? nflManager : new NFLManager(new NFLFactory(2019));
        }

        [HttpGet]
        public IEnumerable<DivisionTeamsInformation> GetNFLData()
        {
            List<DivisionTeamsInformation> result = _nflManager.GetAllNFLDivisionTeams(2019);
            //List<DivisionTeamsInformation> result2 = result;
            //string json = JsonConvert.SerializeObject(result2.ToArray());
            //System.IO.File.WriteAllText("C:\\Temp\\NFLData.txt", json);
            return result.ToArray();
        }
    }
}
