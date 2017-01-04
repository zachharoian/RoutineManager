using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

//  Database Package
using SQLite;

namespace App1
{
    class DataAccess
    {   
        public static string dbPath { get; set; }

        public static void SaveObject (EventData obj)
        {
            object locker = new object();
            lock (locker)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "database.db3");
                var db = new SQLiteConnection(dbPath);
                db.CreateTable<EventData>();
                db.Insert(obj);
            }

        }

 
    }
}