using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time_Series_Serach_Engine.Controllers;
using Time_Series_Serach_Engine.Utlity;

namespace Time_Series_Serach_Engine.Models
{
    public  abstract class SearchOperator
    {
        protected string Keyword;
        protected int NumberOfParameters;
        public List<ResultInstance> left;
        public List<ResultInstance> right;

        public SearchOperator()
        {
            left = new List<ResultInstance>();
            right = new List<ResultInstance>();
        }
        public int getNumberOfParameters()
        {
            return NumberOfParameters;
        }
        public void AddLeft(List<ResultInstance> shortInstances)
        {
            foreach(var shortInstance in shortInstances)
            {
                left.Add(shortInstance);
            }
        }
        public void AddRight(List<ResultInstance> shortInstances)
        {
            foreach (var shortInstance in shortInstances)
            {
                right.Add(shortInstance);
            }
        }
        public abstract List<ResultInstance> ApplyOperator();


    }
    public class AND : SearchOperator
    {
        public AND()
        {
            Keyword = "AND";
            NumberOfParameters = 2;
        }
        public override List<ResultInstance> ApplyOperator()
        {

            List<ResultInstance> overlapResult = new List<ResultInstance>();
            

            //overlapResult.word = parameters[0].word + " " + Keyword + " " + parameters[1].word;
            foreach (var instance1 in left)
            {
                foreach (var instance2 in right)
                {
                    var shortInstace = instance1.OverlapShortInstances(instance2);
                    if (shortInstace != null)
                    {
                        overlapResult.Add(shortInstace);
                    }
                }
            }
            return overlapResult;

        }
    }

    public class OR : SearchOperator
    {
        public OR()
        {
            Keyword = "OR";
            NumberOfParameters = 2;
        }
        public override List<ResultInstance> ApplyOperator()
        {
            List<ResultInstance> orResult = new List<ResultInstance>();
            return orResult;
            /*
            SearchResult unionResult = new SearchResult();
            unionResult.shortInstances = new List<ShortInstance>();

            //unionResult.word = parameters[0].word + " " + Keyword + " " + parameters[1].word;
            foreach (var instance1 in left)
            {
                foreach (var instance2 in right)
                {
                    var shortInstance = UnionShortInstances(instance1, instance2);
                    foreach(var obj in shortInstance)
                    {
                        unionResult.shortInstances.Add(obj);
                    }
                }
            }
            return unionResult;
            */
        }
    }
    public class NOT : SearchOperator
    {
        public NOT()
        {
            Keyword = "NOT";
            NumberOfParameters = 1;
        }
        public  override List<ResultInstance> ApplyOperator()
        {
            return null;
        }
    }

    /*
    public class test : SearchOperator
    {
        public override List<ResultInstance> ApplyOperator()
        {
            return null;
        }
    }
    */
}

