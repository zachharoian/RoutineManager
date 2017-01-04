using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class EventData
    {
        //  Event Properties
        string title { get; set; }
        string desc { get; set; }

        //  Constructor
        public EventData(string tempTitle, string tempDesc)
        {
            title = tempTitle;
            desc = tempDesc;
        }
    }
}
