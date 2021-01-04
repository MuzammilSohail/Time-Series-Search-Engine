using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time_Series_Serach_Engine.Controllers;

namespace Time_Series_Serach_Engine.Models
{
    public class SearchResult
    {
        public string videoName;
        public List<ResultInstance> resultInstances;
    }
}