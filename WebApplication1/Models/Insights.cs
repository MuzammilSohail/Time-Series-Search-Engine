using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time_Series_Serach_Engine.Controllers;
using Time_Series_Serach_Engine.Models;

namespace Time_Series_Serach_Engine.Controllers
{
    
    
    public class Feature
    {
        public int id { get; set; }
        public string name { get; set; }
        public string text { get; set; }
        public string docType { get; set; }

        public IList<Instance> instances { get; set; }
    }
    public class Instance: ResultInstance
    {
        public double confidence { get; set; }
        public TimeSpan adjustedStart { get; set; }
        public TimeSpan adjustedEnd { get; set; }
    }

    public class ResultInstance
    {
        
        public TimeSpan start { get; set; }
        public TimeSpan end { get; set; }
        public List<FeatureDetails> featureDetails { get; set; }

    }

    public class FeatureDetails
    {
        public string featureType { get; set; }
        public string info { get; set; }
    }

    //Insights
    /*
    public class test : Feature
    {

    }
    */

    public class Keyword : Feature
    {
        
        public string text { get; set; }
        public double confidence { get; set; }
        public string language { get; set; }
        public Keyword()
        {
            docType = "Keyword";
        }
        
    }

    public class Transcript : Feature
    {
        
        public string text { get; set; }
        public double confidence { get; set; }
        public int speakerId { get; set; }
        public string language { get; set; }

        public Transcript()
        {
            docType = "Transcript";
        }

    }

    public class Ocr :Feature
    {
        
        public string text { get; set; }
        public double confidence { get; set; }
        public double left { get; set; }
        public double top { get; set; }
        public double width { get; set; }
        public double height { get; set; }
        public string language { get; set; }

        public Ocr()
        {
            docType = "Ocr";
        }
        
    }
    public class Topic : Feature
    {
        
        public string name { get; set; }
        public string referenceId { get; set; }
        public string referenceType { get; set; }
        public string iptcName { get; set; }
        public double confidence { get; set; }
        public string iabName { get; set; }
        public string language { get; set; }
        public string referenceUrl { get; set; }
        public Topic()
        {
            docType = "Topic";
        }


    }

    public class Face : Feature
    {
        
        public string name { get; set; }
        public double confidence { get; set; }
        public string description { get; set; }
        public string thumbnailId { get; set; }
        public string referenceId { get; set; }
        public string referenceType { get; set; }
        public object title { get; set; }
        public string imageUrl { get; set; }
        public IList<Thumbnail> thumbnails { get; set; }

        public Face()
        {
            docType = "Face";
        }

    }

    public class Label : Feature
    {
        
        public string name { get; set; }
        public string language { get; set; }
        public string referenceId { get; set; }
        public Label()
        {
            docType = "Label";
        }

    }
    public class Scene 
    {
        public int id { get; set; }
        public string docType;
        public IList<Instance> instances { get; set; }
        public Scene()
        {
            docType = "Scene";
        }

    }
    public class KeyFrame 
    {
        public int id { get; set; }
        public string docType;
        public IList<Instance> instances { get; set; }
        public KeyFrame()
        {
            docType = "Key Frame";
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
    public class Brand :Feature
    {
        
        public string referenceType { get; set; }
        public string name { get; set; }
        public string referenceId { get; set; }
        public string referenceUrl { get; set; }
        public string description { get; set; }
        public IList<object> tags { get; set; }
        public double confidence { get; set; }
        public bool isCustom { get; set; }
        public IList<Instance> instances { get; set; }
        public Brand()
        {
            docType = "Brand";
        }


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
    public class NamedLocation : Feature
    {
        
        public string name { get; set; }
        public string referenceId { get; set; }
        public string referenceUrl { get; set; }
        public string description { get; set; }
        public IList<object> tags { get; set; }
        public double confidence { get; set; }
        public bool isCustom { get; set; }
        public NamedLocation()
        {
            docType = "Named Location";
        }
    }
    public class NamedPeople : Feature
    {
        
        public string name { get; set; }
        public string referenceId { get; set; }
        public string referenceUrl { get; set; }
        public string description { get; set; }
        public IList<object> tags { get; set; }
        public double confidence { get; set; }
        public bool isCustom { get; set; }
        public NamedPeople()
        {
            docType = "Named People";
        }


    }

    public class Sentiment : Feature
    {
        
        public double averageScore { get; set; }
        public string sentimentType { get; set; }
        public Sentiment()
        {
            docType = "Sentiment";
        }

    }
    public class Emotion : Feature
    {
        
        public string type { get; set; }
        public Emotion()
        {
            docType = "Emotion";
        }

    }
    public class VisualContentModeration 
    {
        public int id { get; set; }
        public string docType;
        public double adultScore { get; set; }
        public double racyScore { get; set; }
        public IList<Instance> instances { get; set; }

        public VisualContentModeration()
        {
            docType = "Visual Content Moderation";
        }

    }

    public class Block 
    {
        public int id { get; set; }
        public string docType;
        public IList<Instance> instances { get; set; }
        public Block()
        {
            docType = "Block";
        }
    }
    public class FramePattern 
    {
        public int id { get; set; }
        public string docType;
        public IList<Instance> instances { get; set; }
        public string patternType { get; set; }
        public double confidence { get; set; }
        public FramePattern()
        {
            docType = "Frame Pattern";
        }
    }

    public class TextualContentModeration 
    {

        public int id { get; set; }
        public string docType;
        public IList<Instance> instances { get; set; }
        public double bannedWordsCount { get; set; }
        public double bannedWordsRatio { get; set; }
        public TextualContentModeration()
        {
            docType = "Textual Content Moderation";
        }

    }
    public class Statistics
    {
        public double correspondenceCount { get; set; }
        public SpeakerTalkToListenRatio speakerTalkToListenRatio { get; set; }
        public SpeakerLongestMonolog speakerLongestMonolog { get; set; }
        public SpeakerNumberOfFragments speakerNumberOfFragments { get; set; }
        public SpeakerWordCount speakerWordCount { get; set; }

        public class SpeakerTalkToListenRatio
        {
            public double a { get; set; }
        }

        public class SpeakerLongestMonolog
        {
            public double a { get; set; }
        }

        public class SpeakerNumberOfFragments
        {
            public double a { get; set; }
        }

        public class SpeakerWordCount
        {
            public double a { get; set; }
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

    public class Duration
    {
        public string time { get; set; }
        public double seconds { get; set; }
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

        
       
    }

    public class Video
    {
        public string accountId { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string moderationState { get; set; }
        public string reviewState { get; set; }
        public string privacyMode { get; set; }
        public string processingProgress { get; set; }
        public string failureCode { get; set; }
        public string failureMessage { get; set; }
        public string externalId { get; set; }
        public string externalUrl { get; set; }
        public string metadata { get; set; }
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

    
}