using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.terminetClasses
{
    class TerminetClass
    {
        //Getter and seter
        public int Terminet_ID { get; set; }
        public String Emri_trr { get; set; }
        public String Mbiemri_trr { get; set; }
        public String Data_trr { get; set; }
        public String Koha_trr { get; set; }
    
        static String myconnstrng = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;


        //select data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM tbl_terminet";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {

            }
            return dt;
        }


        // insertimi i te dhenave ne databaz

        public bool Insert(TerminetClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                string sql = "INSERT INTO tbl_terminet(Emri_tr, Mbiemri_tr, Data_tr, Koha_tr)VALUES(@Emri_tr, @Mbiemri_tr, @Data_tr, @Koha_tr)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Emri_tr", c.Emri_trr);
                cmd.Parameters.AddWithValue("@Mbiemri_tr", c.Mbiemri_trr);
                cmd.Parameters.AddWithValue("@Data_tr", c.Data_trr);
                cmd.Parameters.AddWithValue("@Koha_tr", c.Koha_trr);
            

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }





    }
}
