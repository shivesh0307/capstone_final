using System.ComponentModel.DataAnnotations;

namespace bank.Entities
{
    public class admin
    {
        [Required]
        [Key]
        public string userid { get; set; }
        [Required]
        public string password { get; set; }
    }
}
