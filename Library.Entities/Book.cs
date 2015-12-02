using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities
{
    public class Book
    {
        
        public int BookId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }
    }
}
