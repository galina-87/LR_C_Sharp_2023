using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LR1
{
    internal class OverallResults
    {
        public List<Result>? ResultList;

        public int NumberAttempts
        {
            get { return ResultList.Count; }
        }

        public double AverageSpeed()
        {
            double sp = 0;
            foreach (var result in ResultList)
            {
                sp += result.speed;
            }

            return sp / ResultList.Count;

        }

        public double MaxSpeed()
        {
            return ResultList.MaxBy(res => res.speed).speed;

        }

        public double MinSpeed()
        {
            return ResultList.MinBy(res => res.speed).speed;

        }

        public OverallResults() 
        {
            ResultList = new List<Result>();
        }
    }
}
