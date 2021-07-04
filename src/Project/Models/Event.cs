using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{

    public class Event
    {
        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("Description")]
        public string Description { get; set; }
        [JsonProperty("imgUrlMobile")]
        public string ImgUrlMobile { get; set; }
        [JsonProperty("imgUrlMobile2x")]
        public string ImgUrlMobile2x { get; set; }
        [JsonProperty("imgUrlDesktop")]
        public string ImgUrlDesktop { get; set; }
        [JsonProperty("imgUrlDesktop2x")]
        public string imgUrlDesktop2x { get; set; }

    }
}
