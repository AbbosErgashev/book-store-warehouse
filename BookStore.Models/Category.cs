using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [MaxLength(30)]
        [Required]
        public string Name { get; set; } = null!;

        [DisplayName("Display Order")]
        [Range(0, 100, ErrorMessage = "Display order must be between 1 - 100")]
        public int DisplayOrder { get; set; }
    }
}
