using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerTracker.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [ForeignKey("Team")]
        [Display(Name = "Team Name")]
        public int TeamId { get; set; }
        public Team Team { get; set; }

        [NotMapped]
        public IEnumerable<Team> Teams { get; set; }
    }
}
