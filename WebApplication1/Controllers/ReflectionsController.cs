using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web.Http;
using Time_Series_Serach_Engine.Models;
using Time_Series_Serach_Engine.Utlity;

namespace Time_Series_Serach_Engine.Controllers
{
    public class ReflectionsController : ApiController
    {
        // GET: api/Info
        public IHttpActionResult Get()
        {
            Feature feature = new Feature();
            ArrayList children = new ArrayList();
            foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
                foreach (var t in a.GetTypes())
                    if (t.IsSubclassOf(feature.GetType()))
                        children.Add(t.Name.SplitCamelCase());
            return Ok(children);
        }

        // GET: api/Info/5
        public IHttpActionResult Get(int id)
        {
            //return Ok(Assembly.GetExecutingAssembly().GetType("Time_Series_Serach_Engine.Models.SearchOperator"));
            
            Feature feature = new Feature();
            ArrayList children = new ArrayList();
            foreach (var a in AppDomain.CurrentDomain.GetAssemblies())
                foreach (var t in a.GetTypes())
                    if (t.IsSubclassOf(Assembly.GetExecutingAssembly().GetType("Time_Series_Serach_Engine.Models.SearchOperator")))
                        children.Add(t.Name);
            return Ok(children);
        }

        // POST: api/Info
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Info/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Info/5
        public void Delete(int id)
        {
        }

        
    }

    public static class ReflectiveEnumerator
    {
        static ReflectiveEnumerator() { }

        public static IEnumerable<T> GetEnumerableOfType<T>(params object[] constructorArgs) where T : class, IComparable<T>
        {
            List<T> objects = new List<T>();
            foreach (Type type in
                Assembly.GetAssembly(typeof(T)).GetTypes()
                .Where(myType => myType.IsClass && !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
            {
                objects.Add((T)Activator.CreateInstance(type, constructorArgs));
            }
            objects.Sort();
            return objects;
        }
    }
}
