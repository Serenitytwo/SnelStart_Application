﻿using SQLite;

namespace SnelStart_Application
{
    public class DBCustomers
    {
        public DBCustomers()
        {

        }

        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Recent { get; set; }
    }
}
