using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace EJERCICIO22ELKIN.Models
{
    public class videorecord
    {

        [PrimaryKey, AutoIncrement]
        public int id { get; set; }

        public string uri { get; set; }

        public string descripcion { get; set; }
    }
}
