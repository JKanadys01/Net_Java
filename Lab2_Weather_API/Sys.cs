using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_Weather_API
{
    internal class Sys
    {
        public int type {  get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunreise { get; set; }
        public int sunset { get; set; }
    }
}
