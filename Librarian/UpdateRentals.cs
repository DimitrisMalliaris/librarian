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
    public partial class UpdateRentals : Form
    {
        String ISBN13 = String.Empty;
        String member_id = String.Empty;
        NpgsqlConnection DB_connection = null;
        public UpdateRentals()
        {
            InitializeComponent();
        }
        public UpdateRentals(String book_id, String member_id, NpgsqlConnection DB_connection)
        {
            InitializeComponent();

            this.Text = "Add Rental Entry";
            btn_Update.Text = "SAVE";
            this.ISBN13 = book_id;
            this.member_id = member_id;
            this.DB_connection = DB_connection;
        }
        public void SetText(String bookTitle, String name, String lastName)
        {
            txt_member.Text = $"{name} {lastName}";
            txt_book.Text = bookTitle;
            txt_date.Text = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            try { 
                String sql_query =
                    "INSERT INTO Users_Books (user_id, rent_date, isbn13) " +
                    $"VALUES ($${member_id}$$, $${DateTime.Parse(txt_date.Text).ToString("yyyy-MM-dd")}$$, $${ISBN13}$$); "; // QUERY 26
                Viewer.DB_Run_Query(sql_query, DB_connection);
            }
            catch (PostgresException ex)
            {
                if(ex.SqlState == "23505")
                {
                    MessageBox.Show("This member has already rented this book");
                }
                DB_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                DB_connection.Close();
            }
        }
    }
}
