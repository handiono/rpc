using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
   public class Member
    {
        public int MemberId { get; set; }

       [Required]
       [MinLength(6)]
        public string Name { get; set; }

    }
}
