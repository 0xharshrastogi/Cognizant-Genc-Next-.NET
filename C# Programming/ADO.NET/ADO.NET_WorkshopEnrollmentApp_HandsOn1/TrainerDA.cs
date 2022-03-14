using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WorkShopEnrollmentApp
{
    public class TraineeDA
    {
        public string ConnectionString
        {
            get => ConfigurationManager.ConnectionStrings["SqlCon"].ConnectionString;
        }
        public bool AddTraineeDetails(TraineeBO objBO)
        {

            long id = objBO.TraineeId;
            string n = objBO.TraineeName;
            string b = objBO.BatchCode;
            try
            {
                SqlConnection con = new SqlConnection(ConnectionString);
                string q = "insert into tblTrainee values(" + id + ",'" + n + "','" + b + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(q, con);


                int r = cmd.ExecuteNonQuery();
                if (r > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}