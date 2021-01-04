using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Time_Series_Serach_Engine.Models
{
    public class SearchOperatorFactory
    {
        public SearchOperator getSearchOperator(string operatorType)
        {
            if (operatorType.Equals("AND"))
            {
                return new AND();
            }else if (operatorType.Equals("OR"))
            {
                return new OR();
            }else if (operatorType.Equals("NOT"))
            {
                return new NOT();
            }
            return null;
        }
    }
}