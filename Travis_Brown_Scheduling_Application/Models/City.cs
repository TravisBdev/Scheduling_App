﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travis_Brown_Scheduling_Application.Models {
    public class City {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int CountryId { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = "System";
        public DateTime LastUpdate { get; set; } = DateTime.UtcNow;
        public string LastUpdateBy { get; set; } = "System";
    }
}
