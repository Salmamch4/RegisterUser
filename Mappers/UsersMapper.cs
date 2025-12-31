namespace RegisterUser.Mappers;
using RegisterUser.Models;

    public class UsersMapper
    {
        public static User MapToUser(ViewModels.Users.RegisterVM vm)
        {
        if (vm.Password != vm.ConfirmPassword)
        { throw new ArgumentException("Password and ConfirmPassword do not match."); }
            return new User 
            { 
                Login = vm.Login,
                Nom = vm.Nom,
                Prenom = vm.Prenom,
                Password = vm.Password,
                ConfirmPassword = vm.ConfirmPassword,
                tentatives =0,
                blocked = false

            };
        }
    }
