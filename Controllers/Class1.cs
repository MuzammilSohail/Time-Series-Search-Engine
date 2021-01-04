using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Controllers;

namespace WebApplication1.Controllers
{

    public class Face
    {
        public string videoId { get; set; }
        public string referenceId { get; set; }
        public string referenceType { get; set; }
        public double confidence { get; set; }
        public string description { get; set; }
        public object title { get; set; }
        public string thumbnailId { get; set; }
        public double seenDuration { get; set; }
        public double seenDurationRatio { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public IList<Appearance> appearances { get; set; }


        public class Appearance
        {
            public string startTime { get; set; }
            public string endTime { get; set; }
            public double startSeconds { get; set; }
            public double endSeconds { get; set; }
        }
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

        public class Duration
        {
            public string time { get; set; }
            public double seconds { get; set; }
        }

        public class Appearance
        {
            public string startTime { get; set; }
            public string endTime { get; set; }
            public double startSeconds { get; set; }
            public double endSeconds { get; set; }
        }

        

        public class Keyword
        {
            public bool isTranscript { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public IList<Appearance> appearances { get; set; }


            public class Appearance
            {
                public string startTime { get; set; }
                public string endTime { get; set; }
                public double startSeconds { get; set; }
                public double endSeconds { get; set; }
            }
        }

        public class Sentiment
        {
            public string sentimentKey { get; set; }
            public double seenDurationRatio { get; set; }
            public IList<Appearance> appearances { get; set; }


            public class Appearance
            {
                public string startTime { get; set; }
                public string endTime { get; set; }
                public double startSeconds { get; set; }
                public double endSeconds { get; set; }
            }
        }

        public class Emotion
        {
            public string type { get; set; }
            public double seenDurationRatio { get; set; }
            public IList<Appearance> appearances { get; set; }


            public class Appearance
            {
                public string startTime { get; set; }
                public string endTime { get; set; }
                public double startSeconds { get; set; }
                public double endSeconds { get; set; }
            }
        }

        public class Label
        {
            public int id { get; set; }
            public string name { get; set; }
            public IList<Appearance> appearances { get; set; }


            public class Appearance
            {
                public string startTime { get; set; }
                public string endTime { get; set; }
                public double startSeconds { get; set; }
                public double endSeconds { get; set; }
            }
        }
        public class FramePattern
        {
            public int id { get; set; }
            public string name { get; set; }
            public IList<Appearance> appearances { get; set; }


            public class Appearance
            {
                public string startTime { get; set; }
                public string endTime { get; set; }
                public double startSeconds { get; set; }
                public double endSeconds { get; set; }
            }
        }

        public class Brand
        {
            public string referenceId { get; set; }
            public string referenceUrl { get; set; }
            public double confidence { get; set; }
            public string description { get; set; }
            public double seenDuration { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public IList<Appearance> appearances { get; set; }


            public class Appearance
            {
                public string startTime { get; set; }
                public string endTime { get; set; }
                public double startSeconds { get; set; }
                public double endSeconds { get; set; }
            }
        }

        public class NamedLocation
        {
            public string referenceId { get; set; }
            public string referenceUrl { get; set; }
            public double confidence { get; set; }
            public string description { get; set; }
            public double seenDuration { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public IList<Appearance> appearances { get; set; }


            public class Appearance
            {
                public string startTime { get; set; }
                public string endTime { get; set; }
                public double startSeconds { get; set; }
                public double endSeconds { get; set; }
            }
        }

        public class NamedPeople
        {
            public string referenceId { get; set; }
            public string referenceUrl { get; set; }
            public double confidence { get; set; }
            public string description { get; set; }
            public double seenDuration { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public IList<Appearance> appearances { get; set; }
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




        public class Topic
        {
            public string referenceUrl { get; set; }
            public string iptcName { get; set; }
            public string iabName { get; set; }
            public double confidence { get; set; }
            public int id { get; set; }
            public string name { get; set; }
            public IList<Appearance> appearances { get; set; }
        }
    }

    public class Instance
    {
        public string adjustedStart { get; set; }
        public string adjustedEnd { get; set; }
        public string start { get; set; }
        public string end { get; set; }
    }

    public class Transcript
    {
        public int id { get; set; }
        public string text { get; set; }
        public double confidence { get; set; }
        public int speakerId { get; set; }
        public string language { get; set; }
        public IList<Instance> instances { get; set; }
    

    public class Instance
    {
        public string adjustedStart { get; set; }
        public string adjustedEnd { get; set; }
        public string start { get; set; }
        public string end { get; set; }
    }
    }

    public class Ocr
    {
        public int id { get; set; }
        public string text { get; set; }
        public double confidence { get; set; }
        public int left { get; set; }
        public int top { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public string language { get; set; }
        public IList<Instance> instances { get; set; }
    

    public class Instance
    {
        public string adjustedStart { get; set; }
        public string adjustedEnd { get; set; }
        public string start { get; set; }
        public string end { get; set; }
    }
    }

    public class Keyword
    {
        public int id { get; set; }
        public string text { get; set; }
        public double confidence { get; set; }
        public string language { get; set; }
        public IList<Instance> instances { get; set; }


        public class Instance
        {
            public string adjustedStart { get; set; }
            public string adjustedEnd { get; set; }
            public string start { get; set; }
            public string end { get; set; }
        }
    }

    public class Topic
    {
        public int id { get; set; }
        public string name { get; set; }
        public string referenceId { get; set; }
        public string referenceType { get; set; }
        public string iptcName { get; set; }
        public double confidence { get; set; }
        public string iabName { get; set; }
        public string language { get; set; }
        public IList<Instance> instances { get; set; }
        public string referenceUrl { get; set; }


        public class Instance
        {
            public string adjustedStart { get; set; }
            public string adjustedEnd { get; set; }
            public string start { get; set; }
            public string end { get; set; }
        }
    }

    public class Thumbnail
    {
        public string id { get; set; }
        public string fileName { get; set; }
        public IList<Instance> instances { get; set; }


        public class Instance
        {
            public IList<string> thumbnailsIds { get; set; }
            public string adjustedStart { get; set; }
            public string adjustedEnd { get; set; }
            public string start { get; set; }
            public string end { get; set; }
        }
    }

    

    public class Insights
    {
        public string version { get; set; }
        public string duration { get; set; }
        public string sourceLanguage { get; set; }
        public IList<string> sourceLanguages { get; set; }
        public string language { get; set; }
        public IList<string> languages { get; set; }
        public IList<Transcript> transcript { get; set; }
        public IList<Ocr> ocr { get; set; }
        public IList<Keyword> keywords { get; set; }
        public IList<Topic> topics { get; set; }
        public IList<Face> faces { get; set; }
        public IList<Label> labels { get; set; }
        public IList<Scene> scenes { get; set; }
        public IList<Shot> shots { get; set; }
        public IList<Brand> brands { get; set; }
        public IList<NamedLocation> namedLocations { get; set; }
        public IList<NamedPeople> namedPeople { get; set; }
        public IList<Sentiment> sentiments { get; set; }
        public IList<Emotion> emotions { get; set; }
        public IList<VisualContentModeration> visualContentModeration { get; set; }
        public IList<Block> blocks { get; set; }
        public IList<FramePattern> framePatterns { get; set; }
        public TextualContentModeration textualContentModeration { get; set; }
        public Statistics statistics { get; set; }

        public class Face
        {
            public int id { get; set; }
            public string name { get; set; }
            public double confidence { get; set; }
            public string description { get; set; }
            public string thumbnailId { get; set; }
            public string referenceId { get; set; }
            public string referenceType { get; set; }
            public object title { get; set; }
            public string imageUrl { get; set; }
            public IList<Thumbnail> thumbnails { get; set; }
            public IList<Instance> instances { get; set; }


            public class Instance
            {
                public double confidence { get; set; }
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }

        public class Label
        {
            public int id { get; set; }
            public string name { get; set; }
            public string language { get; set; }
            public IList<Instance> instances { get; set; }
            public string referenceId { get; set; }


            public class Instance
            {
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }
        public class Scene
        {
            public int id { get; set; }
            public IList<Instance> instances { get; set; }


            public class Instance
            {
                public string thumbnailId { get; set; }
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }
        public class KeyFrame
        {
            public int id { get; set; }
            public IList<Instance> instances { get; set; }


            public class Instance
            {
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }
        public class Shot
        {
            public int id { get; set; }
            public IList<string> tags { get; set; }
            public IList<KeyFrame> keyFrames { get; set; }
            public IList<Instance> instances { get; set; }


            public class Instance
            {
                public string brandType { get; set; }
                public string instanceSource { get; set; }
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }
        public class Brand
        {
            public int id { get; set; }
            public string referenceType { get; set; }
            public string name { get; set; }
            public string referenceId { get; set; }
            public string referenceUrl { get; set; }
            public string description { get; set; }
            public IList<object> tags { get; set; }
            public double confidence { get; set; }
            public bool isCustom { get; set; }
            public IList<Instance> instances { get; set; }


            public class Instance
            {
                public string instanceSource { get; set; }
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }
        public class NamedLocation
        {
            public int id { get; set; }
            public string name { get; set; }
            public string referenceId { get; set; }
            public string referenceUrl { get; set; }
            public string description { get; set; }
            public IList<object> tags { get; set; }
            public double confidence { get; set; }
            public bool isCustom { get; set; }
            public IList<Instance> instances { get; set; }


            public class Instance
            {
                public string instanceSource { get; set; }
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }
        public class NamedPeople
        {
            public int id { get; set; }
            public string name { get; set; }
            public string referenceId { get; set; }
            public string referenceUrl { get; set; }
            public string description { get; set; }
            public IList<object> tags { get; set; }
            public double confidence { get; set; }
            public bool isCustom { get; set; }
            public IList<Instance> instances { get; set; }


            public class Instance
            {
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }

        public class Sentiment
        {
            public int id { get; set; }
            public double averageScore { get; set; }
            public string sentimentType { get; set; }
            public IList<Instance> instances { get; set; }


            public class Instance
            {
                public double confidence { get; set; }
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }
        public class Emotion
        {
            public int id { get; set; }
            public string type { get; set; }
            public IList<Instance> instances { get; set; }


            public class Instance
            {
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }
        public class VisualContentModeration
        {
            public int id { get; set; }
            public int adultScore { get; set; }
            public double racyScore { get; set; }
            public IList<Instance> instances { get; set; }


            public class Instance
            {
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }

        public class Block
        {
            public int id { get; set; }
            public IList<Instance> instances { get; set; }


            public class Instance
            {
                public string adjustedStart { get; set; }
                public string adjustedEnd { get; set; }
                public string start { get; set; }
                public string end { get; set; }
            }
        }
        public class FramePattern
        {
            public int id { get; set; }
            public string patternType { get; set; }
            public double confidence { get; set; }
            public IList<Instance> instances { get; set; }
        }

        public class TextualContentModeration
        {
            public int id { get; set; }
            public int bannedWordsCount { get; set; }
            public int bannedWordsRatio { get; set; }
            public IList<object> instances { get; set; }
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

    public class Video
    {
        public string accountId { get; set; }
        public string id { get; set; }
        public string state { get; set; }
        public string moderationState { get; set; }
        public string reviewState { get; set; }
        public string privacyMode { get; set; }
        public string processingProgress { get; set; }
        public string failureCode { get; set; }
        public string failureMessage { get; set; }
        public object externalId { get; set; }
        public object externalUrl { get; set; }
        public object metadata { get; set; }
        public Insights insights { get; set; }
        public string thumbnailId { get; set; }
        public bool detectSourceLanguage { get; set; }
        public string languageAutoDetectMode { get; set; }
        public string sourceLanguage { get; set; }
        public IList<string> sourceLanguages { get; set; }
        public string language { get; set; }
        public IList<string> languages { get; set; }
        public string indexingPreset { get; set; }
        public string linguisticModelId { get; set; }
        public string personModelId { get; set; }
        public bool isAdult { get; set; }
        public string publishedUrl { get; set; }
        public object publishedProxyUrl { get; set; }
        public string viewToken { get; set; }
    }

    public class Range
    {
        public string start { get; set; }
        public string end { get; set; }
    }

    public class VideosRanx
    {
        public string videoId { get; set; }
        public Range range { get; set; }
    }

    public class Data
    {
        public object partition { get; set; }
        public object description { get; set; }
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