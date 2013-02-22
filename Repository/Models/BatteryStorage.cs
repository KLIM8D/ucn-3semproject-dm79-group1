using System;
using System.Collections.Generic;

namespace Repository.Models
{
    public partial class BatteryStorage
    {
        public BatteryStorage()
        {
            this.BatteryCollections = new List<BatteryCollection>();
        }

        public int ID { get; set; }
        public int StationId { get; set; }
        public int Available { get; set; }
        public int Reserved { get; set; }
        public int Charging { get; set; }
        public virtual ICollection<BatteryCollection> BatteryCollections { get; set; }
        public virtual Station Station { get; set; }
    }
}