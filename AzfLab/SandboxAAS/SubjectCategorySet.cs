using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace SandboxAAS
{
    public class SubjectCategorySet
    {
        public List<String> GetCategories(string subjectName)
        {
            var cnStr = Environment.GetEnvironmentVariable("GALLERY_CONSTR");
            SqlConnection cn = null;
            var ret = new List<String>();
            try
            {
                cn = new SqlConnection(cnStr);
                cn.Open();
                var sp = new SqlCommand("getSubjectCategories", cn) { CommandType = CommandType.StoredProcedure };
                sp.Parameters.Add(new SqlParameter("@name", subjectName));
                var rdr = sp.ExecuteReader();
                while(rdr.Read())
                {
                    var cat = rdr["CategoryName"].ToString();
                    ret.Add(cat);
                }
            }
            catch(Exception ex)
            {
                Trace.WriteLine(ex.ToString());
            }
            finally
            {
                if(cn != null) cn.Close();
            }
            return ret;
        }
    }
}
