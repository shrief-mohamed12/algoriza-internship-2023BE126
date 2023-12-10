using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vezeeta.Domain.Helpers
{
    public class LogInModel
    {
        
        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
