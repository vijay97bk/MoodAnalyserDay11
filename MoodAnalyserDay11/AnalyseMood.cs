using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserDay11
{
    public class AnalyseMood
    {
        string message;
       public AnalyseMood ( string message)
        {
            this.message = message;
        }
        public string MoodAnalyse()
        {
            try
            {
                if (this.message.Contains("HAPPY"))
                    return "HAPPY";
                else
                    return "SAD";
            }
            catch { return "HAPPY"; }
           
        }
        
        
    }
}
