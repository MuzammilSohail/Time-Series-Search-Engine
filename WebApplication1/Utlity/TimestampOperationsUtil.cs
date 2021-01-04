using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Time_Series_Serach_Engine.Controllers;

namespace Time_Series_Serach_Engine.Utlity
{
    public static class TimestampOperationsUtil
    {
        public static ResultInstance OverlapShortInstances(this ResultInstance shortInstance1, ResultInstance shortInstance2)
        {
            if (shortInstance1.start > shortInstance2.end || shortInstance2.start > shortInstance1.end)
            {
                return null;
            }
            return new ResultInstance
            {
                
                featureDetails = new List<FeatureDetails>()
                {
                    new FeatureDetails()
                    {
                        featureType = shortInstance1.featureDetails[0].featureType,
                        info = shortInstance1.featureDetails[0].info
                    },
                    new FeatureDetails()
                    {
                        featureType = shortInstance2.featureDetails[0].featureType,
                        info = shortInstance2.featureDetails[0].info
                    },
                },
                start = new[] { shortInstance1.start, shortInstance2.start }.Max(),
                end = new[] { shortInstance1.end, shortInstance2.end }.Min(),
            };
        }

        public static List<ResultInstance> UnionShortInstances(this ResultInstance shortInstance1, ResultInstance shortInstance2)
        {
            if (shortInstance1.start > shortInstance2.end || shortInstance2.start > shortInstance1.end)
            {
                return new List<ResultInstance> { shortInstance1, shortInstance2 };
            }
            return new List<ResultInstance>
            {
                new ResultInstance{
                    //FeatureType = shortInstance1.FeatureType + shortInstance2.FeatureType,
                    start = new[] { shortInstance1.start, shortInstance2.start }.Min(),
                    end = new[] { shortInstance1.end, shortInstance2.end }.Max(),
                }
            };
        }
    }
}