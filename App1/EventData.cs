using System;
using System.Collections.Generic;
using System.Text;

//  Database Package
using SQLite;

namespace App1
{
    public class EventData
    {
        //  SQLite setup information
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int ID { get; set; }

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
