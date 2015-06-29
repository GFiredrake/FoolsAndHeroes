using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoolsAndHeroes.Controllers
{
    public class CharacterController : Controller
    {
        // GET: Character
        public bool DoIHaveACharacter(string username)
        {
        //    string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        //    string insertStmt = "SELECT * FROM [Characters] WHERE UserName_PK ='" + username + "'";

        //    using(SqlConnection conn = new SqlConnection(connectionString))
        //    using(SqlCommand cmd = new SqlCommand(insertStmt, conn))
        //    {
        //        // open connection, execute command, close connection
        //        conn.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();
        //        var result = cmd.ExecuteNonQuery();
        //        conn.Close();
        //    }
            string characterName = "empty";

            string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            string script = "SELECT * FROM [Characters] WHERE UserName_PK ='" + username + "'";
            connection.Open();
            SqlCommand command = new SqlCommand(script, connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                characterName = reader["CharacterName"].ToString();    
            }

            connection.Close();

            if(characterName == "empty"){
                return false;
            }
            return true;
        }
    }
}