using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Econtact.econtactClasses
{
    class contactClass
    {

        //Getter and seter
        public int ContactID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String ContactNo { get; set; }
        public String Address { get; set; }
        public String Gender { get; set; }

        static String myconnstrng = ConfigurationManager.ConnectionStrings["connString"].ConnectionString;

        //select data from database
        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try {
                string sql = "SELECT * FROM tbl_contact";

                SqlCommand cmd = new SqlCommand(sql, conn);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                conn.Open();
                adapter.Fill(dt);
              
            }
            catch(Exception ) {

            }
            finally
            {

            }
            return dt;
        }

        // insertimi i te dhenave ne databaz

        public bool Insert(contactClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try {

                string sql = "INSERT INTO tbl_contact(FirstName, LastName, ContactNo, Address, Gender)VALUES (@FirstName, @LastName, @ContactNo, @Address, @Gender)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }else
                {
                    isSuccess = false;
                }

            }
            catch(Exception )
            {
                
            }
            finally
            {
                conn.Close();
            }

            return isSuccess;
        }

        public bool Update(contactClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                string sql = "UPDATE tbl_contact SET FirstName=@FirstName, LastName=@LastName, ContactNo=@ContactNo, Address=@Address, Gender=@Gender WHERE ContactID=@ContactID";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

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

        public bool Delete(contactClass c)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myconnstrng);
            try
            {

                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";

                SqlCommand cmd = new SqlCommand(sql, conn);

              
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

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


    }
}
