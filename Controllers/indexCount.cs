using Nest;

namespace WebApplication1.Controllers
{
    internal class IndexCount
    {
        private static IndexCount indexCount = new IndexCount();
        private ElasticClient nestClient;
        private int num { get; set; }
        private IndexCount()
        {
            nestClient = new ElasticClient();
            var response = nestClient.SearchAsync<Data>(s => s.Query(q => q.MatchAll()));

            foreach(var obj in response.Result.Hits)
            {
                /*
                if (obj.Index > num)
                {
                    num = obj.Index;
                };
                */
            }
        }

        public static IndexCount getInstance()
        {
            return indexCount;
        }
        public int increment()
        {
            return ++num;
        }
    }
}