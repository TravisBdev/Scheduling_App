using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travis_Brown_Scheduling_Application.Models {
    public class User {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public string CreatedBy { get; set; } = "System";
        public DateTime LastUpdate { get; set; } = DateTime.UtcNow;
        public string LastUpdateBy { get; set; } = "System";
    }
}
