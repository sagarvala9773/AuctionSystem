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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TeamService : ITeamService
    {
        public DataSet GetTeam()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT Id, T_Name, T_Owner, T_BValue, T_Captain ,T_HCoach FROM teams",
               @"Data Source = (localdb)\ProjectsV13; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            DataSet ds = new DataSet();
            da.Fill(ds, "teams");
            return ds;
        }
        public string AddTeam(Team team)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\ProjectsV13; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            SqlCommand cmd = new SqlCommand();
            try
            {
                cmd.Connection = con;
                cmd.CommandText = "INSERT INTO teams (T_Name, T_Owner, T_BValue, T_Captain ,T_HCoach) VALUES (@tnm,@to,@tb,@tc,@th)";
                SqlParameter p0 = new SqlParameter("@tnm", team.T_Name);
                SqlParameter p1 = new SqlParameter("@to", team.T_Owner);
                SqlParameter p2 = new SqlParameter("@tb", team.T_BValue);
                SqlParameter p3 = new SqlParameter("@tc", team.T_Captain);
                SqlParameter p4 = new SqlParameter("@th", team.T_HCoach);

                cmd.Parameters.Add(p0);
                cmd.Parameters.Add(p1);
                cmd.Parameters.Add(p2);
                cmd.Parameters.Add(p3);
                cmd.Parameters.Add(p4);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw (new Exception("Error on adding team!!"));
            }
            finally
            {
                con.Close();
            }
            return "team Added Successfully!!";
        }

        public string UpdateTeam(Team team)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\ProjectsV13 ; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            string sqlStatement = "UPDATE teams SET T_Name=@tnm,T_Owner=@to,T_BValue=@tb,T_Captain=@tc,T_HCoach=@th WHERE Id=@id";
            try
            {
                SqlCommand cmd = new SqlCommand(sqlStatement, con);

                cmd.Parameters.AddWithValue("@id", team.Id);
                cmd.Parameters.AddWithValue("@tnm", team.T_Name);
                cmd.Parameters.AddWithValue("@to", team.T_Owner);
                cmd.Parameters.AddWithValue("@tb", team.T_BValue);
                cmd.Parameters.AddWithValue("@tc", team.T_Captain);
                cmd.Parameters.AddWithValue("@th", team.T_HCoach);
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
            return "team Updated Successfully!!";
        }

        public String DeleteTeam(int id)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (localdb)\ProjectsV13; Initial Catalog = Ipl; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
            string sqlStatement = "DELETE FROM teams WHERE Id= @id";

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
                throw new Exception("Error on deleting team");
            }
            finally
            {
                con.Close();
            }
            return "team Deleted Successfully";
        }


        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            throw new NotImplementedException();
        }
    }
}
