using System.ComponentModel.DataAnnotations;

namespace HashPass.Models
{
    public class HashPassModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PassText { get; set; }
        
        [Required]
        public string HashPass { get; set; }
        
        [Required]
        public string CreationDate { get; set; }

        public string UpdatedDate { get; set; }
    }
}