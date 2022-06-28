using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librarian
{
    public partial class UpdateMembers : Form
    {
        String selected_user_id = string.Empty;
        NpgsqlConnection DB_connection;
        public UpdateMembers(String user_id, NpgsqlConnection DB_connection)
        {
            InitializeComponent();
            selected_user_id = user_id;
            this.DB_connection = DB_connection;
            this.Text = "Update member info";
            DBLoadData(selected_user_id);
        }
        public UpdateMembers(NpgsqlConnection DB_connection)
        {
            InitializeComponent();
            btn_update_save.Text = "SAVE";
            this.DB_connection = DB_connection;
            this.Text = "Add new member";
        }
        private void DBLoadData(String selected_user_id)
        {
            String sql_query = "SELECT user_id AS \"User ID\", " +
                "first_name AS \"First Name\", " +
                "last_name AS \"Last Name\", " +
                "email AS \"Email\", " +
                "gender AS \"Gender\", " +
                "birth_date AS \"Birth Date\", " +
                "street_address AS \"Address\" " +
                "FROM Users " +
                $"WHERE user_id = $${selected_user_id}$$"; // QUERY 20
            DataTable DT_selected_member_info = Viewer.DB_Run_Query(sql_query, DB_connection);
            Set_Values(DT_selected_member_info);
        }// QUERY 20
        public void Set_Values(DataTable DT_selected_member_info)
        {
            List<String> user_info = new List<string>();
            foreach (DataColumn dataColumn in DT_selected_member_info.Columns)
            {
                user_info.Add(DT_selected_member_info.Rows[0][dataColumn].ToString());
            }
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Text = user_info[txt.TabIndex];
            }
        }
        private void btn_update_save_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_update_save.Text == "UPDATE")
                {
                    String sql_query =
                        "UPDATE Users " +
                        $"SET first_name = $${ txt_fname.Text }$$, " +
                        $"last_name = $${ txt_lname.Text }$$, " +
                        $"email = $${ txt_email.Text }$$, " +
                        $"gender = $${ txt_gender.Text }$$, " +
                        $"birth_date = $${ DateTime.Parse(txt_bday.Text).ToString("yyyy-MM-dd") }$$, " +
                        $"street_address = $${ txt_saddress.Text }$$ " +
                        $"WHERE user_id = $${ selected_user_id }$$ ;";// QUERY 21
                    Viewer.DB_Run_Query(sql_query, DB_connection);
                }
                else
                {
                    String sql_query =
                        "INSERT INTO Users(user_id, first_name, last_name, email, gender, birth_date, street_address) " +
                        "SELECT MAX(user_id)+1, " +
                        $"$${ txt_fname.Text }$$, " +
                        $"$${ txt_lname.Text }$$, " +
                        $"$${ txt_email.Text }$$, " +
                        $"$${ txt_gender.Text }$$, " +
                        $"$${ DateTime.Parse(txt_bday.Text).ToString("yyyy-MM-dd") }$$, " +
                        $"$${ txt_saddress.Text }$$ " +
                        "FROM Users; ";// QUERY 22
                    Viewer.DB_Run_Query(sql_query, DB_connection);
                }
            }// QUERY 21, 22
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DB_connection.Close();
            }
        }
    }
}
