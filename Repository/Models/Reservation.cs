using System;
using System.Runtime.Serialization;

namespace Repository.Models
{
    [DataContract(IsReference = false)]
    public partial class Reservation
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public int UserId { get; set; }
        [DataMember]
        public int StationId { get; set; }
        [DataMember]
        public DateTime ExpiredDate { get; set; }
        [DataMember]
        public DateTime? CompletedDate { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
        [DataMember]
        public virtual Station Station { get; set; }
        [DataMember]
        public virtual User User { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}
