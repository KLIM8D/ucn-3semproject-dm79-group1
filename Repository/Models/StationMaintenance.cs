using System;
using System.Runtime.Serialization;

namespace Repository.Models
{
    [DataContract(IsReference = false)]
    public partial class StationMaintenance
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int TypeId { get; set; }
        [DataMember]
        public int StationId { get; set; }
        [DataMember]
        public DateTime ExpectedOperationalDate { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public virtual MaintenanceType MaintenanceType { get; set; }
        [DataMember]
        public virtual Station Station { get; set; }
    }
}
