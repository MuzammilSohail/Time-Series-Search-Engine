using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time_Series_Serach_Engine.Controllers;

namespace Time_Series_Serach_Engine.Models
{
    public class Appearance
    {
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
        public double startSeconds { get; set; }
        public double endSeconds { get; set; }
    }
    public class Item
    {
        public IList<Appearance> appearances { get; set; }
    }

    public class SummarizedInsights
    {
        public string name { get; set; }
        public string id { get; set; }
        public string privacyMode { get; set; }
        public Duration duration { get; set; }
        public string thumbnailVideoId { get; set; }
        public string thumbnailId { get; set; }
        public IList<Face> faces { get; set; }
        public IList<Keyword> keywords { get; set; }
        public IList<Sentiment> sentiments { get; set; }
        public IList<Emotion> emotions { get; set; }
        public IList<object> audioEffects { get; set; }
        public IList<Label> labels { get; set; }
        public IList<FramePattern> framePatterns { get; set; }
        public IList<Brand> brands { get; set; }
        public IList<NamedLocation> namedLocations { get; set; }
        public IList<NamedPeople> namedPeople { get; set; }
        public Statistics statistics { get; set; }
        public IList<Topic> topics { get; set; }
    }










    public class Statistics
    {
        public int correspondenceCount { get; set; }
        public SpeakerTalkToListenRatio speakerTalkToListenRatio { get; set; }
        public SpeakerLongestMonolog speakerLongestMonolog { get; set; }
        public SpeakerNumberOfFragments speakerNumberOfFragments { get; set; }
        public SpeakerWordCount speakerWordCount { get; set; }

        public class SpeakerTalkToListenRatio
        {
            public int a { get; set; }
        }

        public class SpeakerLongestMonolog
        {
            public int a { get; set; }
        }

        public class SpeakerNumberOfFragments
        {
            public int a { get; set; }
        }

        public class SpeakerWordCount
        {
            public int a { get; set; }
        }
    }
      
}