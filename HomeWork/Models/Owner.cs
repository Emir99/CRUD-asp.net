using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWork.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string First_name { get; set; }
        public string Last_name { get; set; }
        public string Ssn { get; set; }
        public int Age { get; set; }
        public int BuildingId { get; set; }
        public Building Building { get; set; }
    }
}
