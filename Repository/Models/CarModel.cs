using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Repository.Models
{
    [DataContract(IsReference = false)]
    public partial class CarModel
    {
        public CarModel()
        {
            this.Cars = new List<Car>();
        }

        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime Year { get; set; }
        [DataMember]
        public decimal Range { get; set; }
        [DataMember]
        public string Website { get; set; }
        [DataMember]
        public virtual List<Car> Cars { get; set; }
        [DataMember]
        public bool IsActive { get; set; }
    }
}
