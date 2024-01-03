using System;
using System.Collections.Generic;

namespace PhaseEndWeb.Models
{
    public partial class EmpProfile
    {
        public int EmpCode { get; set; }
        public DateTime DateofBirth { get; set; }
        public string EmpName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int? DeptCode { get; set; }

        public virtual DeptMaster? DeptCodeNavigation { get; set; }
    }
}
