using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class ExcelStudent
    {
        // [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public bool IsGraduate { get; set; }
        public double AttendancePercentage { get; set; }
        // [ForeignKey("Cohort")]
        public int CohortId { get; set; }
        // public Cohort Cohort { get; set; }
    }
}
