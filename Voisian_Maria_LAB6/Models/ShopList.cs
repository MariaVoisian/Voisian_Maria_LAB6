using System;
using SQLite;
using System.Collections.Generic;
using System.Text;

namespace Voisian_Maria_LAB6.Models
{
    public class ShopList
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
    }
}
