using System.ComponentModel.DataAnnotations;

namespace HashPass.Dto
{
    public class HashPassCreateDto
    {
        [Required]
        public string PassText { get; set; }
    }
}