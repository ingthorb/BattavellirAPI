using System.Collections.Generic;

namespace BattavellirAPI.Domain.Models
{
    public class FootballField
    {

        public int Id {get; set;}
        public string Name { get; set; }
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}