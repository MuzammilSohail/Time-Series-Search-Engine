using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Time_Series_Serach_Engine.Models
{
    public class SingletonVideoNumber
    {
        private static SingletonVideoNumber instance = new SingletonVideoNumber();
        private int videoNumber;

        
        private SingletonVideoNumber() {
            DbOperationsElastic dbOperationsElastic = new DbOperationsElastic();
            videoNumber = dbOperationsElastic.GetMaxIndex() + 1;
        }

        //Get the only object available
        public static SingletonVideoNumber getInstance()
        {
            return instance;
        }

        public int getVideoNumber()
        {
            return videoNumber++;
        }
    }
}