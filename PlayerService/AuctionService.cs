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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "AuctionService" in both code and config file together.
    public class AuctionService : IAuctionService
    {
        public DataSet GetAuctions()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id, S_Name, T_Player,T_Team, I_Player, F_Player, Season  FROM auctions",
               @"Data Source = (localdb)\ProjectsV13; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            DataSet ds = new DataSet();
            da.Fill(ds, "auctions");
            return ds;
        }
        public string AddAuction(Auction auction)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\ProjectsV13; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO auctions (S_Name, T_Player,T_Team, I_Player, F_Player, Season) VALUES (@sn,@tp,@tt,@ip,@fp,@s)";
                SqlParameter p0 = new SqlParameter("@sn", auction.S_Name);
                SqlParameter p1 = new SqlParameter("@tp", auction.T_Player);
                SqlParameter p2 = new SqlParameter("@tt", auction.T_Team);
                SqlParameter p3 = new SqlParameter("@ip", auction.I_Player);
                SqlParameter p4 = new SqlParameter("@fp", auction.F_Player);
                SqlParameter p5 = new SqlParameter("@s", auction.Season);

                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                cmd.Parameters.Add(p5);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (new Exception("Error on adding auction!!"));
            }
            finally
            {
                con.Close();
            }
            return "auction Added Successfully!!";
        }

        public string UpdateAuction(Auction auction)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\ProjectsV13 ; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            string sqlStatement = "UPDATE auctions SET S_Name=@sn,T_Player=@tp,T_Team=@tt,I_Player=@ip,F_Player=@fp,Season=@s WHERE Id=@id";
            try
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, con);

                cmd.Parameters.AddWithValue("@id", auction.Id);
                cmd.Parameters.AddWithValue("@sn", auction.S_Name);
                cmd.Parameters.AddWithValue("@tp", auction.T_Player);
                cmd.Parameters.AddWithValue("@tt", auction.T_Team);
                cmd.Parameters.AddWithValue("@ip", auction.I_Player);
                cmd.Parameters.AddWithValue("@fp", auction.F_Player);
                cmd.Parameters.AddWithValue("@s", auction.Season);
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
            return "auction Updated Successfully!!";
        }

        public String DeleteAuction(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\ProjectsV13; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            string sqlStatement = "DELETE FROM auctions WHERE Id= @id";

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
                throw new Exception("Error on deleting auction");
            }
            finally
            {
                con.Close();
            }
            return "auction Deleted Successfully";
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
    }
}
