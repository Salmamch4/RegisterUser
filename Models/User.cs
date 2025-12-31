using System.ComponentModel.DataAnnotations;

namespace RegisterUser.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        [Required,MaxLength(20)]
        public String Login { get; set; }
        
        [Required, MaxLength(20)]

        public String Nom { get; set; }
        [Required, MaxLength(20)]
        public String Prenom { get; set; }
        [Required, MaxLength(20)]
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }

        public int tentatives { get; set; } = 0;
        public Boolean blocked { get; set; }= false;
    }
}
