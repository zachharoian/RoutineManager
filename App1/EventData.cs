using System;
using System.Collections.Generic;
using System.Text;

namespace App1
{
    public class EventData
    {
        //  Event Properties
        public string Title { get; set; }
        public string Desc { get; set; }

        //  Constructor
        public EventData ()
        {

        }

        //  Overloaded Constructor
        public EventData(string tempTitle, string tempDesc)
        {
            Title = tempTitle;
            Desc = tempDesc;
        }

    }
}
