using RegisterUser.Models;
using System.Data.SqlClient;

namespace RegisterUser.Repositories
{
    public class UserRepository: IUsersRepository
    {
        IConfiguration configuration;
        public UserRepository(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        public void Add(User u)
        {
            SqlConnection cn = new SqlConnection(configuration.GetConnectionString("default"));

            cn.Open();
            SqlCommand SqlCommand = new SqlCommand("insert into [User] values('" + u.email + "', '" + u.nom + "', '" + u.prenom + "', '" + u.password + ")", cn);
            SqlCommand.ExecuteNonQuery();


            cn.Close();
        }
}
