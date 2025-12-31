using System.ComponentModel.DataAnnotations;

namespace RegisterUser.ViewModels.Users
{
    public class RegisterVM
    { 
        public String Login { get; set; }
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Password { get; set; }
        public String ConfirmPassword { get; set; }


    }
}
