using Elasticsearch.Net;
using Nest;
using Nest.Specification.IndicesApi;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using Time_Series_Serach_Engine.Models;
using Time_Series_Serach_Engine.Utlity;

namespace Time_Series_Serach_Engine.Controllers
{
    public class ValuesController : ApiController
    {
        SingletonVideoNumber singletonVideoNumber;
        DbOperationsElastic dbOperations;
        public ValuesController() {
            singletonVideoNumber = SingletonVideoNumber.getInstance();
            dbOperations = new DbOperationsElastic();
        }
        
        public IHttpActionResult Get([FromUri] string[] videoNumbers, [FromUri] string[] featureType, [FromUri] string[] queries, [FromUri] string[] operatorStrings)
        {
            string[] operators = new string[] { "AND", "OR" ,"NOT"};
            string[] specialCharacters = new string[] { "\"" };
            
            List<SearchResult> searchResults = new List<SearchResult>();
            List<string> words = new List<String>();

            
            

            
            
            foreach(var videoNumber in videoNumbers)
            {
                ArrayList tempResults = new ArrayList();
                var shortInstances = new List<ResultInstance>();
                
                
                tempResults.Add(dbOperations.SearchForString(videoNumber.ToString(), featureType[0], queries[0]));
                for (int i = 1; i < queries.Count(); i++)
                {
                    tempResults.Add(operatorStrings[i - 1]);
                    tempResults.Add(dbOperations.SearchForString(videoNumber.ToString(),featureType[i], queries[i]));
                }
                
                foreach (var op in operators)
                {
                    for (int i = 0; i < tempResults.Count; i++)
                    {
                        if (tempResults[i] is string && (string)tempResults[i] == op)
                        {
                            SearchOperatorFactory searchOperatorFactory = new SearchOperatorFactory();
                            SearchOperator searchOperator = searchOperatorFactory.getSearchOperator((string)tempResults[i]);

                            if (searchOperator.getNumberOfParameters() == 2)
                            {
                                searchOperator.AddLeft((List<ResultInstance>)tempResults[i - 1]);
                            }
                            searchOperator.AddRight((List<ResultInstance>)tempResults[i + 1]);

                            tempResults[i] = searchOperator.ApplyOperator();
                            tempResults.RemoveAt(i - 1);
                            tempResults.RemoveAt(i);

                        }
                    }
                }
                
                foreach(var tempResult in tempResults)
                {
                    foreach(var tr in (List<ResultInstance>)tempResult)
                    {
                        shortInstances.Add((ResultInstance)tr);
                    }
                }
                
                searchResults.Add(new SearchResult
                {
                    videoName = dbOperations.GetVideoStats(videoNumber).videoName,
                    resultInstances = shortInstances
                });
            }
            
            return Ok(searchResults);
        }

        

        // POST api/values
        //[HttpPost("api/upload")]
        public async Task<IHttpActionResult> PostAsync()
        {
            string videoNumber = singletonVideoNumber.getVideoNumber().ToString();

            
            string json = "";

            if (!Request.Content.IsMimeMultipartContent())
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

            var provider = new MultipartMemoryStreamProvider();
            await Request.Content.ReadAsMultipartAsync(provider);


            json = await provider.Contents.First().ReadAsStringAsync();
            IndexerOutput indexerOutput = JsonConvert.DeserializeObject<IndexerOutput>(json);            

            
            VideoStats videoStats = new VideoStats
            {
                videoName = indexerOutput.name,
                duration = indexerOutput.durationInSeconds
            };
            
            var indexResponse = dbOperations.SetVideoStats(videoNumber, videoStats);
            


            BulkResponse bulkIndexResponseItem;
            foreach (var video in indexerOutput.videos)
            {
                PropertyInfo[] properties = typeof(Insights).GetProperties();
                List<PropertyInfo> chosenProperties = new List<PropertyInfo>();

                foreach (PropertyInfo property in properties)
                {
                    if(property.GetValue(video.insights) is IEnumerable<Feature>)
                    {
                        bulkIndexResponseItem = await dbOperations.BulkInsertFeaturesAsync(videoNumber, (IEnumerable<Feature>)property.GetValue(video.insights));
                    }
                }
            }

            return Ok(videoNumber);
        }

        // PUT api/values/5
        public IHttpActionResult Put(int id, [FromBody] string value)
        {
            //return Ok(dbOperations.Search("85","feature","ashleigh"));
            return Ok();
        }

        // DELETE api/values/5

        public async Task<IHttpActionResult> Delete(string id)
        {
            //StringResponse asyncIndexResponse = await lowLevelClient.Indices.DeleteAsync<Data>(value);
            return Ok(await dbOperations.DeleteIndexAsync(id));
        }
    }
}
