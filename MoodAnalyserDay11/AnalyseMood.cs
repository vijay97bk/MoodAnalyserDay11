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
        public void MoodAnalyse()
        {
            if (this.message.Contains("happy"))
                Console.WriteLine("Happy");
            else
                Console.WriteLine("sad");

        }
        
        
    }
}
