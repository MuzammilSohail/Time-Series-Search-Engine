using Elasticsearch.Net;
using Nest;
using System.Collections.Generic;
using System.Threading.Tasks;
using Time_Series_Serach_Engine.Controllers;

namespace Time_Series_Serach_Engine.Models
{
    public interface IDbOperations
    {

        Task<BulkResponse> BulkInsertFeaturesAsync(string indexName, IEnumerable<Feature> features);

        Task<DeleteIndexResponse> DeleteIndexAsync(string indexName);
        int GetMaxIndex();

        VideoStats GetVideoStats(string indexName);
        BytesResponse SetVideoStats(string indexName, VideoStats videoStats);

        List<ResultInstance> SearchForString(string indexName, string featureType, string word);
        
    }
}