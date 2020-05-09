using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace UserRestaurnats3.Entities
{
    public class User
    { 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Guid Identity { get; set; } = Guid.NewGuid();
        public bool IsAdmin { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public virtual ICollection<Restaurant> Restaurants { get; set; }
    }
}
