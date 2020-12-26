using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using WpfApp2.DataModel;


namespace WpfApp2.DataModel
{
    public class InsertObject
    {
        BaseLayer ObjBaseLayer = new BaseLayer();
        public void InsertStudent(string _NAME, string _gender, int _age,ref string error_msg)
        {
            error_msg = "";
            string strConnString = ObjBaseLayer.ConnectionString;
            SqlConnection con = new SqlConnection(strConnString);
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sqladp = new SqlDataAdapter();
            ObjBaseLayer.StoredProcedure = "insert_student";
            cmd.Parameters.Add("@NAME", SqlDbType.NVarChar, 50).Value = _NAME;

            cmd.Parameters.Add("@Gender", SqlDbType.NVarChar, 50).Value = _gender;
            cmd.Parameters.Add("@Age", SqlDbType.Int).Value = _age;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = ObjBaseLayer.StoredProcedure;
            cmd.Connection = con;
            sqladp.SelectCommand = cmd;
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                error_msg = ex.Message.ToString();
            }
            finally
            {
                con.Close();
                con.Dispose();

            }

            // return error_msg;
        }
    }
}
