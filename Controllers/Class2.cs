/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Controllers
{
    public class Duration
    {
        public string time { get; set; }
        public double seconds { get; set; }

    }
    public class Appearances
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public double startSeconds { get; set; }
        public double endSeconds { get; set; }

    }
    public class Faces
    {
        public string videoId { get; set; }
        public string referenceId { get; set; }
        public string referenceType { get; set; }
        public double confidence { get; set; }
        public string description { get; set; }
        public IList<undefined> title { get; set; }
        public string thumbnailId { get; set; }
        public double seenDuration { get; set; }
        public double seenDurationRatio { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public IList<Appearances> appearances { get; set; }

    }
    public class Appearances
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int startSeconds { get; set; }
        public double endSeconds { get; set; }

    }
    public class Keywords
    {
        public bool isTranscript { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public IList<Appearances> appearances { get; set; }

    }
    public class Appearances
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int startSeconds { get; set; }
        public double endSeconds { get; set; }

    }
    public class Sentiments
    {
        public string sentimentKey { get; set; }
        public double seenDurationRatio { get; set; }
        public IList<Appearances> appearances { get; set; }

    }
    public class Appearances
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public double startSeconds { get; set; }
        public double endSeconds { get; set; }

    }
    public class Emotions
    {
        public string type { get; set; }
        public double seenDurationRatio { get; set; }
        public IList<Appearances> appearances { get; set; }

    }
    public class Appearances
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int startSeconds { get; set; }
        public double endSeconds { get; set; }

    }
    public class Labels
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Appearances> appearances { get; set; }

    }
    public class Appearances
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public int startSeconds { get; set; }
        public int endSeconds { get; set; }

    }
    public class FramePatterns
    {
        public int id { get; set; }
        public string name { get; set; }
        public IList<Appearances> appearances { get; set; }

    }
    public class Appearances
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public double startSeconds { get; set; }
        public double endSeconds { get; set; }

    }
    public class Brands
    {
        public string referenceId { get; set; }
        public string referenceUrl { get; set; }
        public double confidence { get; set; }
        public string description { get; set; }
        public double seenDuration { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public IList<Appearances> appearances { get; set; }

    }
    public class Appearances
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public double startSeconds { get; set; }
        public double endSeconds { get; set; }

    }
    public class NamedLocations
    {
        public string referenceId { get; set; }
        public string referenceUrl { get; set; }
        public double confidence { get; set; }
        public string description { get; set; }
        public double seenDuration { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public IList<Appearances> appearances { get; set; }

    }
    public class Appearances
    {
        public string startTime { get; set; }
        public string endTime { get; set; }
        public double startSeconds { get; set; }
        public double endSeconds { get; set; }

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
        public IList<Appearances> appearances { get; set; }

    }
    
public class Statistics
{
    public int correspondenceCount { get; set; }
    public SpeakerTalkToListenRatio speakerTalkToListenRatio { get; set; }
    public SpeakerLongestMonolog speakerLongestMonolog { get; set; }
    public SpeakerNumberOfFragments speakerNumberOfFragments { get; set; }
    public SpeakerWordCount speakerWordCount { get; set; }

}
public class Appearances
{
    public string startTime { get; set; }
    public string endTime { get; set; }
    public int startSeconds { get; set; }
    public double endSeconds { get; set; }

}
public class Topics
{
    public IList<undefined> referenceUrl { get; set; }
    public string iptcName { get; set; }
    public string iabName { get; set; }
    public double confidence { get; set; }
    public int id { get; set; }
    public string name { get; set; }
    public IList<Appearances> appearances { get; set; }

}
public class SummarizedInsights
{
    public string name { get; set; }
    public string id { get; set; }
    public string privacyMode { get; set; }
    public Duration duration { get; set; }
    public string thumbnailVideoId { get; set; }
    public string thumbnailId { get; set; }
    public IList<Faces> faces { get; set; }
    public IList<Keywords> keywords { get; set; }
    public IList<Sentiments> sentiments { get; set; }
    public IList<Emotions> emotions { get; set; }
    public IList<undefined> audioEffects { get; set; }
    public IList<Labels> labels { get; set; }
    public IList<FramePatterns> framePatterns { get; set; }
    public IList<Brands> brands { get; set; }
    public IList<NamedLocations> namedLocations { get; set; }
    public IList<NamedPeople> namedPeople { get; set; }
    public Statistics statistics { get; set; }
    public IList<Topics> topics { get; set; }

}
public class Instances
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
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

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
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class Keywords
{
    public int id { get; set; }
    public string text { get; set; }
    public int confidence { get; set; }
    public string language { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class Topics
{
    public int id { get; set; }
    public string name { get; set; }
    public string referenceId { get; set; }
    public string referenceType { get; set; }
    public string iptcName { get; set; }
    public double confidence { get; set; }
    public string iabName { get; set; }
    public string language { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class Thumbnails
{
    public string id { get; set; }
    public string fileName { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public IList<string> thumbnailsIds { get; set; }
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class Faces
{
    public int id { get; set; }
    public string name { get; set; }
    public double confidence { get; set; }
    public string description { get; set; }
    public string thumbnailId { get; set; }
    public string referenceId { get; set; }
    public string referenceType { get; set; }
    public IList<undefined> title { get; set; }
    public string imageUrl { get; set; }
    public IList<Thumbnails> thumbnails { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public double confidence { get; set; }
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class Labels
{
    public int id { get; set; }
    public string name { get; set; }
    public string language { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class Scenes
{
    public int id { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string thumbnailId { get; set; }
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class KeyFrames
{
    public int id { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class Shots
{
    public int id { get; set; }
    public IList<string> tags { get; set; }
    public IList<KeyFrames> keyFrames { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string brandType { get; set; }
    public string instanceSource { get; set; }
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class Brands
{
    public int id { get; set; }
    public string referenceType { get; set; }
    public string name { get; set; }
    public string referenceId { get; set; }
    public string referenceUrl { get; set; }
    public string description { get; set; }
    public IList<undefined> tags { get; set; }
    public double confidence { get; set; }
    public bool isCustom { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string instanceSource { get; set; }
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class NamedLocations
{
    public int id { get; set; }
    public string name { get; set; }
    public string referenceId { get; set; }
    public string referenceUrl { get; set; }
    public string description { get; set; }
    public IList<undefined> tags { get; set; }
    public double confidence { get; set; }
    public bool isCustom { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string instanceSource { get; set; }
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class NamedPeople
{
    public int id { get; set; }
    public string name { get; set; }
    public string referenceId { get; set; }
    public string referenceUrl { get; set; }
    public string description { get; set; }
    public IList<undefined> tags { get; set; }
    public double confidence { get; set; }
    public bool isCustom { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class Sentiments
{
    public int id { get; set; }
    public double averageScore { get; set; }
    public string sentimentType { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public double confidence { get; set; }
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class Emotions
{
    public int id { get; set; }
    public string type { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class VisualContentModeration
{
    public int id { get; set; }
    public int adultScore { get; set; }
    public double racyScore { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class Blocks
{
    public int id { get; set; }
    public IList<Instances> instances { get; set; }

}
public class Instances
{
    public string adjustedStart { get; set; }
    public string adjustedEnd { get; set; }
    public string start { get; set; }
    public string end { get; set; }

}
public class FramePatterns
{
    public int id { get; set; }
    public string patternType { get; set; }
    public double confidence { get; set; }
    public IList<Instances> instances { get; set; }

}
public class TextualContentModeration
{
    public int id { get; set; }
    public int bannedWordsCount { get; set; }
    public int bannedWordsRatio { get; set; }
    public IList<undefined> instances { get; set; }

}
public class Statistics
{
    public int correspondenceCount { get; set; }
    public SpeakerTalkToListenRatio speakerTalkToListenRatio { get; set; }
    public SpeakerLongestMonolog speakerLongestMonolog { get; set; }
    public SpeakerNumberOfFragments speakerNumberOfFragments { get; set; }
    public SpeakerWordCount speakerWordCount { get; set; }

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
    public IList<Keywords> keywords { get; set; }
    public IList<Topics> topics { get; set; }
    public IList<Faces> faces { get; set; }
    public IList<Labels> labels { get; set; }
    public IList<Scenes> scenes { get; set; }
    public IList<Shots> shots { get; set; }
    public IList<Brands> brands { get; set; }
    public IList<NamedLocations> namedLocations { get; set; }
    public IList<NamedPeople> namedPeople { get; set; }
    public IList<Sentiments> sentiments { get; set; }
    public IList<Emotions> emotions { get; set; }
    public IList<VisualContentModeration> visualContentModeration { get; set; }
    public IList<Blocks> blocks { get; set; }
    public IList<FramePatterns> framePatterns { get; set; }
    public TextualContentModeration textualContentModeration { get; set; }
    public Statistics statistics { get; set; }

}
public class Videos
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
    public IList<undefined> externalId { get; set; }
    public IList<undefined> externalUrl { get; set; }
    public IList<undefined> metadata { get; set; }
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
    public IList<string> publishedProxyUrl { get; set; }
    public string viewToken { get; set; }

}
public class Range
{
    public string start { get; set; }
    public string end { get; set; }

}
public class VideosRanges
{
    public string videoId { get; set; }
    public Range range { get; set; }

}
public class Application
{
    public IList<> partition { get; set; }
    public IList<undefined> description { get; set; }
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
    public IList<Videos> videos { get; set; }
    public IList<VideosRanges> videosRanges { get; set; }

}
}*/