using System;
using System.Collections.Generic;
using System.Linq;
using ICT13580032FinalA.Models;
using SQLite;

namespace ICT13580032FinalA.Helpers
{
    public class DbHelper
    {
        SQLiteConnection db;

        public DbHelper(string dbPath)
        {
            db = new SQLiteConnection(dbPath);
            db.CreateTable<Status>();
        }

        public String AddStatus(Status status)
        {
            db.Insert(status);
            return status.Firstname;
        }
        public List<Status> GetStatus()
        {
            return db.Table<Status>().ToList();
        }
        public int UpdateStatus(Status status)
        {
            return db.Update(status);
        }
        public int DeleteStatus(Status status)
        {
            return db.Delete(status);
        }
    }
}
