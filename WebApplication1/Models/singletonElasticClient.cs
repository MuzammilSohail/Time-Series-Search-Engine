using Nest;

namespace Time_Series_Serach_Engine.Models
{
    public class SingletonNestClient
    {
        private ElasticClient nestClient;
        private static SingletonNestClient instance = new SingletonNestClient();

        private SingletonNestClient()
        {
            var settings = new ConnectionSettings().DefaultDisableIdInference();
            nestClient = new ElasticClient(settings);
        }
        public static SingletonNestClient getInstance()
        {
            return instance;
        }
    }
}