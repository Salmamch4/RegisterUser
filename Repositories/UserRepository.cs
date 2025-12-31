using RegisterUser.Models;
using System.Data.SqlClient;

namespace RegisterUser.Repositories
{
    public class UserRepository : IUsersRepository
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

            SqlCommand cmd = new SqlCommand(
                "INSERT INTO Users (Login, Nom, Prenom, Password, ConfirmPassword, tentatives, blocked) " +
                "VALUES ('" + u.Login + "','" + u.Nom + "','" + u.Prenom + "','" +
                u.Password + "','" + u.ConfirmPassword + "'," +
                u.tentatives + "," + u.blocked + ")",
                cn
            );

            cmd.ExecuteNonQuery();
            cn.Close();

        }
    }
}