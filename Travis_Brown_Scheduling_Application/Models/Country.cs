using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travis_Brown_Scheduling_Application.Models {
    public class Country {
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = "System";
        public DateTime LastUpdate { get; set; } = DateTime.UtcNow;
        public string LastUpdateBy { get; set; } = "System";
    }
}
