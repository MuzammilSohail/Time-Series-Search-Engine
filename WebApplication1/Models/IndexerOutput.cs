using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time_Series_Serach_Engine.Controllers;

namespace Time_Series_Serach_Engine.Models
{
    public class IndexerOutput
    {

        public object partition { get; set; }
        public string description { get; set; }
        public string privacyMode { get; set; }
        public string state { get; set; }
        public string accountId { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string userName { get; set; }
        public DateTime created { get; set; }
        public bool isOwned { get; set; }
        public bool isEditable { get; set; }
        public bool isBase { get; set; }
        public int durationInSeconds { get; set; }
        public SummarizedInsights summarizedInsights { get; set; }
        public IList<Video> videos { get; set; }
        public IList<VideosRanx> videosRanges { get; set; }

    }

    
}