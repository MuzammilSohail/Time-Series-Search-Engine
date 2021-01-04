using Elasticsearch.Net;
using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class ValuesController : ApiController
    {
        // GET api/values
        //public async System.Threading.Tasks.Task<byte[]> GetAsync()
        private ElasticLowLevelClient lowLevelClient;
        private ElasticClient nestClient;
        private IndexCount indexCount;
        
        public ValuesController(){
            lowLevelClient = new ElasticLowLevelClient();
            nestClient = new ElasticClient();
        }
        public async System.Threading.Tasks.Task<string> GetAsync()
        {

            string responseString = "";


            var lowlevelClient = new ElasticLowLevelClient();

            var person = new Person
            {
                FirstName = "Martijn",
                LastName = "Laarman"

            };

            //var asyncIndexResponse = await lowlevelClient.IndexAsync<StringResponse>("people", "1", PostData.Serializable(person));
            //string responseString = asyncIndexResponse.Body;

            var indexResponse2 = nestClient.Index(new IndexRequest<Person>(person, "people"));

            return responseString;

        }

        // GET api/values/5
        public  IHttpActionResult Get(string id)
        {
            var searchRespones = nestClient.Search<Video>(s => s.Index("face").Query(q => q.Match(m => m.Query(id))));

            
            return Ok(searchRespones);
        }

        // POST api/values
        //[HttpPost("api/upload")]
        public async Task<IHttpActionResult> Post()
        {
            string filename = "";
            string json = "";
            IndexResponse asyncIndexResponse = null;
            string indexName = "1";

            if (!Request.Content.IsMimeMultipartContent())
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

            var provider = new MultipartMemoryStreamProvider();
            await Request.Content.ReadAsMultipartAsync(provider);
            foreach (var file in provider.Contents)
            {
                filename = file.Headers.ContentDisposition.FileName.Trim('\"');
                json = await file.ReadAsStringAsync();
            }
            
            Data data = JsonConvert.DeserializeObject<Data>(json);

            string extension = System.IO.Path.GetExtension(filename);

            string index = filename.Substring(0, filename.Length - extension.Length);

            IndexResponse responseString;

            for (int i = 0; i < data.summarizedInsights.faces.Count; i++)
            {
                asyncIndexResponse = await lowLevelClient.IndexAsync<IndexResponse>(index, i.ToString(), PostData.Serializable<Face>(data.summarizedInsights.faces[i]));
                
            }

            for (int i = 0; i < data.summarizedInsights.keywords.Count; i++)
            {
                asyncIndexResponse = await lowLevelClient.IndexAsync<IndexResponse>(index, i.ToString(), PostData.Serializable(data.summarizedInsights.keywords[i]));
                
            }

            for (int i = 0; i < data.summarizedInsights.sentiments.Count; i++)
            {
                asyncIndexResponse = await lowLevelClient.IndexAsync<IndexResponse>(index, i.ToString(), PostData.Serializable(data.summarizedInsights.sentiments[i]));
                
            }

            for (int i = 0; i < data.summarizedInsights.audioEffects.Count; i++)
            {
                asyncIndexResponse = await lowLevelClient.IndexAsync<IndexResponse>(index, i.ToString(), PostData.Serializable(data.summarizedInsights.audioEffects[i]));
                
            }

            for (int i = 0; i < data.summarizedInsights.labels.Count; i++)
            {
                asyncIndexResponse = await lowLevelClient.IndexAsync<IndexResponse>(index, i.ToString(), PostData.Serializable(data.summarizedInsights.labels[i]));
                
            }
            for (int i = 0; i < data.summarizedInsights.brands.Count; i++)
            {
                asyncIndexResponse = await lowLevelClient.IndexAsync<IndexResponse>(index, i.ToString(), PostData.Serializable(data.summarizedInsights.brands[i]));
                
            }
            for (int i = 0; i < data.summarizedInsights.emotions.Count; i++)
            {
                asyncIndexResponse = await lowLevelClient.IndexAsync<IndexResponse>(index, i.ToString(), PostData.Serializable(data.summarizedInsights.emotions[i]));
                
            }
            for (int i = 0; i < data.summarizedInsights.topics.Count; i++)
            {
                asyncIndexResponse = await lowLevelClient.IndexAsync<IndexResponse>(index, i.ToString(), PostData.Serializable((SummarizedInsights.Topic)data.summarizedInsights.topics[i]));
                
            }

            //foreach (var obj in data.summarizedInsights.brands)
            //{
            //    var indexResponse2 = nestClient.Index(new IndexRequest<Brand>(obj, "brands"));
            //}



            //var indexResponse2 = nestClient.Index(data.summarizedInsights.brands[0], new IndexRequest<Brand>((IndexName)"brands"));

            //foreach(var obj in data.summarizedInsights.brands)
            //{
            //    asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(obj));
            //}

            //foreach (var obj in data.summarizedInsights.emotions)
            //{
            //    asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(obj));
            //}

            //foreach (var obj in data.summarizedInsights.audioEffects)
            //{
            //    asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(obj));
            //}

            //foreach (var obj in data.summarizedInsights.faces)
            //{
            //    asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(obj));
            //}

            /*
            asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(data.summarizedInsights.brands));
            asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(data.summarizedInsights.emotions));
            asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(data.summarizedInsights.faces));
            asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(data.summarizedInsights.keywords));
            asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(data.summarizedInsights.labels));
            asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(data.summarizedInsights.name));
            asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(data.summarizedInsights.namedLocations));
            asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(data.summarizedInsights.sentiments));
            asyncIndexResponse = await nestClient.LowLevel.IndexAsync<IndexResponse>("1", PostData.Serializable(data.summarizedInsights.topics));
            */


            return Ok(asyncIndexResponse);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        
        public async Task<IHttpActionResult> Delete(string id)
        {
            //StringResponse asyncIndexResponse = await lowLevelClient.Indices.DeleteAsync<Data>(value);
            DeleteIndexResponse asyncIndexResponse = await nestClient.Indices.DeleteAsync(id);

            return Ok(content: asyncIndexResponse);
            
        }
        
        /*
        public void Delete(int id)
        {
        }
        */
    }
}
