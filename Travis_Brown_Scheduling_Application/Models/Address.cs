using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travis_Brown_Scheduling_Application.Models {
    public class Address {
        public int AddressId { get; set; }
        public string MainAddress { get; set; }
        public string SecondAddress { get; set; }
        public int CityId { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = "System";
        public DateTime LastUpdate { get; set; } = DateTime.UtcNow;
        public string LastUpdateBy { get; set; } = "System";
    }
}
