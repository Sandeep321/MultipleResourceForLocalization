using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MultipleResourceForLocalization.Localization;

namespace MultipleResourceForLocalization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ICustomLocalizer Localizer;
        public ValuesController(ICustomLocalizer localizer)
        {
            Localizer = localizer;
        }
        // GET api/values
        //[HttpGet]
        //public ActionResult<IEnumerable<string>> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/values/5
        [HttpGet("{type}/{key}")]
        public ActionResult<string> Get(string type, string key)
        {
            MessageType messageType = MessageType.Error;
            if(Enum.TryParse(type, out messageType))
            {
                return Localizer.GetLocalizedString(messageType, key);
            }
            return "invalid resource type specified, supported are Info, Warn with en and es cultures";
        }

    }
}
