using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.TerminetClasses
{
    class TerminetClass
    {

        //Getter and seter
        public int Terminet_ID { get; set; }
        public String Emri_tr { get; set; }
        public String Mbiemri_tr { get; set; }
        public String Numri_tr { get; set; }
        public String Data_tr { get; set; }
        public String Koha_tr { get; set; }

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
            catch (Exception)
            {

            }
            finally
            {

            }
            return dt;
        }

        public bool Insert(TerminetClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                string sql = "INSERT INTO tbl_terminet(Emri_tr, Mbiemri_tr, Numri_tr, Data_tr, Koha_tr)VALUES (@Emri_tr, @Mbiemri_tr, @Numri_tr, @Data_tr, @Koha_tr)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Emri_tr", c.Emri_tr);
                cmd.Parameters.AddWithValue("@Mbiemri_tr", c.Mbiemri_tr);
                cmd.Parameters.AddWithValue("@Numri_tr", c.Numri_tr);
                cmd.Parameters.AddWithValue("@Data_tr", c.Data_tr);
                cmd.Parameters.AddWithValue("@Koha_tr", c.Koha_tr);

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
            catch (Exception )
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }
        public bool Update(TerminetClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                string sql = "UPDATE tbl_terminet SET Emri_tr=@Emri_tr, Mbiemri_tr=@Mbiemri_tr, Numri_tr=@Numri_tr, Data_tr=@Data_tr, Koha_tr=@Koha_tr WHERE terminet_id=@terminet_id";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Emri_tr", c.Emri_tr);
                cmd.Parameters.AddWithValue("@Mbiemri_tr", c.Mbiemri_tr);
                cmd.Parameters.AddWithValue("@Numri_tr", c.Numri_tr);
                cmd.Parameters.AddWithValue("@Data_tr", c.Data_tr);
                cmd.Parameters.AddWithValue("@Koha_tr", c.Koha_tr);
                cmd.Parameters.AddWithValue("@terminet_id", c.Terminet_ID);

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
            catch (Exception)
            {

            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Delete(TerminetClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                string sql = "DELETE FROM tbl_terminet WHERE terminet_id=@terminet_id";

                SqlCommand cmd = new SqlCommand(sql, conn);


                cmd.Parameters.AddWithValue("@terminet_id", c.Terminet_ID);

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
            catch (Exception)
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
