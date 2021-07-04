using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project.Controllers
{
    [Route("API/Events")]

    [ApiController]
    public class EventsAPIController : ControllerBase
    {
        public List<Event> GetEvents()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            // TODO: Change path to relative path
            string text = System.IO.File.ReadAllText(@"C:\Users\RudhraRaji\Desktop\Rudhra\bravo-csharp-technical-test\src\Project\wwwroot\assets\data\events.json");
            var eventsList = JsonSerializer.Deserialize<List<Event>>(text, options);
            return eventsList;
        }
    }
}
