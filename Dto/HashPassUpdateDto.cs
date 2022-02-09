using System.ComponentModel.DataAnnotations;

namespace HashPass.Dto
{
    public class HashPassUpdateDto
    {
        [Required]
        public string PassText { get; set; }
    }
}