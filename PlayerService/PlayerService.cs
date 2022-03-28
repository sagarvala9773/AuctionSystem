using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PlayerService
{
    public class PlayerService : IPlayerService
    {
        public DataSet GetPlayers()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id, P_Name, J_No, Country, P_Type FROM players",
               @"Data Source = (localdb)\ProjectsV13; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            DataSet ds = new DataSet();
            da.Fill(ds, "players");
            return ds;
        }
        public string AddPlayer(Player player)
        {
            SqlConnection con = new SqlConnection (@"Data Source = (localdb)\ProjectsV13; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO players (P_Name,J_No,Country,P_Type) VALUES (@pnm,@pjno,@cou,@ty)";
                SqlParameter p0 = new SqlParameter("@pnm", player.P_Name);
                SqlParameter p1 = new SqlParameter("@pjno", player.J_No);
                SqlParameter p2 = new SqlParameter("@cou", player.Country);
                SqlParameter p3 = new SqlParameter("@ty", player.P_Type);

                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (new Exception("Error on adding player!!"));
            }
            finally
            {
                con.Close();
            }
            return "player Added Successfully!!";
        }

        public string UpdatePlayer(Player player)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\ProjectsV13 ; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            string sqlStatement = "UPDATE players SET P_Name=@pnm,J_No=@pjno,Country=@cou,P_Type=@ty WHERE Id=@id";
            try
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, con);

                cmd.Parameters.AddWithValue("@id", player.Id);
                cmd.Parameters.AddWithValue("@pnm", player.P_Name);
                cmd.Parameters.AddWithValue("@pjno", player.J_No);
                cmd.Parameters.AddWithValue("@cou", player.Country);
                cmd.Parameters.AddWithValue("@ty", player.P_Type);
                cmd.CommandType = CommandType.Text;
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
            finally
            {
                con.Close();
            }
            return "player Updated Successfully!!";
        }

        public String DeletePlayer(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\ProjectsV13; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            string sqlStatement = "DELETE FROM players WHERE Id= @id";

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sqlStatement, con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error on deleting player");
            }
            finally
            {
                con.Close();
            }
            return "player Deleted Successfully";
        }
  

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
    }
}
