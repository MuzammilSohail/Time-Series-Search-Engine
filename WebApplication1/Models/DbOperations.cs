using Elasticsearch.Net;
using Nest;
using Nest.Specification.IndicesApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Web;
using Time_Series_Serach_Engine.Controllers;

namespace Time_Series_Serach_Engine.Models
{
    public  class DbOperationsElastic: IDbOperations
    {
        private static ElasticClient nestClient;
        private SingletonNestClient singletonNestClient;

        public  DbOperationsElastic()
        {
            SingletonNestClient singletonNestClient;
            singletonNestClient = SingletonNestClient.getInstance();
            var settings = new ConnectionSettings().DefaultDisableIdInference();
            nestClient = new ElasticClient(settings);
        }

        public async Task<BulkResponse> BulkInsertFeaturesAsync(string indexName, IEnumerable<Feature> features)
        {
            return await nestClient.BulkAsync(b => b.Index(indexName).IndexMany<Feature>(features));
        }

        public  int GetMaxIndex()
        {
            List<int> videoNumbers = new List<int>();
            int convertedInt = 0;
            var result = nestClient.Cat.Indices(i=>i.AllIndices());
            foreach (var record in result.Records)
            {
                if(Int32.TryParse(record.Index, out convertedInt))
                {
                    videoNumbers.Add(convertedInt);
                }
            }
            return videoNumbers.Max();
        }
        public BytesResponse SetVideoStats(string indexName, VideoStats videoStats)
        {
            return nestClient.LowLevel.Index<BytesResponse>("0", indexName, PostData.Serializable(videoStats));
        }

        public VideoStats GetVideoStats(string indexName)
        {
            return nestClient.Get<VideoStats>(indexName, g => g.Index("0")).Source;
        }

        

        public async Task<DeleteIndexResponse> DeleteIndexAsync(string indexName)
        {
            var result = await nestClient.Indices.DeleteAsync(indexName);
            return result;
        }

        public List<ResultInstance> SearchForString(string indexName, string featureType, string word)
        {
            
            List<ResultInstance> shortInstances = new List<ResultInstance>();
            Type t = Assembly.GetExecutingAssembly().GetType("Time_Series_Serach_Engine.Models." + "Feature");
            var searchResponse = nestClient.Search<Feature>(s => s.Index(indexName).Query(q => q.QueryString(qs => qs.Query(word))));


            foreach (var hit in searchResponse.Hits)
            {
                //Polymorphism
                Feature source = hit.Source;
                if(featureType == "All" || source.docType == featureType)
                {
                    foreach (var instance in source.instances)
                    {
                        var text = source.text;
                        if (text == null)
                        {
                            text = source.name;
                        }
                        shortInstances.Add(new ResultInstance
                        {
                            featureDetails = new List<FeatureDetails>()
                        {
                            new FeatureDetails()
                            {
                                featureType = source.docType,
                                info = text
                            }
                        },
                            start = instance.start,
                            end = instance.end
                        });
                    }
                }
            }
            return shortInstances;
        }
    }
}