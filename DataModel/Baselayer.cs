using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

namespace WpfApp2.DataModel
{
    public class BaseLayer
    {
        private string   _StoredProcedure;
        private static string _duser_name, _remarks;
      

       private string _constr = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;

        public string ConnectionString
        {
            get
            {
                return this._constr;
            }
            set
            {
                this._constr = value;
            }
        }

    
      
        public static string Duser_Name
        {
            get
            {
                return _duser_name;
            }
            set
            {
                _duser_name = value;

            }
        }

        public static string Remarks
        {
            get
            {
                return _remarks;
            }
            set
            {
                _remarks = value;
            }
        }

        public string StoredProcedure
        {
            get
            {
                return _StoredProcedure;
            }
            set
            {
                _StoredProcedure = value;
            }
        }



        public static bool IsServerConnected()
        {
            BaseLayer objBBaseLayer = new BaseLayer();
            string Constr = objBBaseLayer.ConnectionString;

            {
                try
                {
                    SqlConnection con = new SqlConnection(Constr);
                    con.Open();
                    con.Close();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }


            }
        }






    }
}
