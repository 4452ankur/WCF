using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace WpfApp2.DataModel
{
   public class ConObject
    {
        string connection = ConfigurationManager.ConnectionStrings["Test"].ConnectionString;
    }
}
