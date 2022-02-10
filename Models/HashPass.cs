using System.ComponentModel.DataAnnotations;

namespace HashPass.Models
{
    public class HashPassModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PassText { get; set; }
        
        public string HashPass { get; set; }
        
        public string CreationDate { get; set; }

        public string UpdatedDate { get; set; }
    }
}