using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Librarian
{
    public partial class Viewer : Form
    {
        Button selected_Button;
        String connection_string;
        NpgsqlConnection DB_connection;

        public Viewer()
        {
            InitializeComponent();
        }
        public bool CreateConnection(String newServerip, String newServerport, String newUserid, String newPassword, String newDatabase)
        {
            this.connection_string = String.Format($"Server = {newServerip}; Port = {newServerport}; User Id = {newUserid}; Password = {newPassword}; Database = {newDatabase};");
            this.DB_connection = new NpgsqlConnection(connection_string);
            return TryConnection(connection_string);
        }
        private bool TryConnection(String connection_string)
        {
            try
            {
                using (NpgsqlConnection cnn = new NpgsqlConnection(connection_string))
                {
                    cnn.Open();
                    String sql_query = "SELECT 1"; // QUERY 0
                    var command = new NpgsqlCommand(sql_query, cnn);
                    var result = (int)command.ExecuteScalar();
                    if ( result == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception)// ex) 
            {
                //MessageBox.Show(ex.Message);
                return false;
            }
        } // QUERY 0
        private void Viewer_Load(object sender, EventArgs e)
        {
            selected_Button = btn_books;
            selected_Button.FlatStyle = FlatStyle.Popup;
            selected_Button.BackColor = Color.PaleGreen;
            //tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            lst_SearchBy_Book.SelectedIndex = 0;
            lst_SearchBy_member.SelectedIndex = 0;
            DB_Load_Data();
        }
        private void DB_Load_Data()
        {
            try
            {
                // BOOKS
                String sql_query = "SELECT Books.isbn13 AS \"ISBN13\", " +
                    "title AS \"Title\", " +
                    "Authors.author_name AS \"Author\", " +
                    "Publishers.publisher_name AS \"Publisher\", " +
                    "publication_date AS \"Publication date\", " +
                    "language_code AS \"Language\", " +
                    "average_rating AS \"Rating\" " +
                    "FROM Books " +
                    "INNER JOIN " +
                    "(SELECT Books_Authors.isbn13, min(Books_Authors.author_id) AS mx " +
                    "FROM Books_Authors " +
                    "GROUP BY Books_Authors.isbn13) AS Grouped_Authors " +
                    "ON Grouped_Authors.isbn13 = Books.isbn13 " +
                    "INNER JOIN Authors " +
                    "ON Authors.author_id = Grouped_Authors.mx " +
                    "NATURAL JOIN Publishers " +
                    "ORDER BY Books.isbn13;";  // QUERY 1
                grid_books.DataSource = DB_Run_Query(sql_query, DB_connection);
                grid_books.CurrentCell = grid_books.Rows[0].Cells[0];
                // MEMBERS
                sql_query = "SELECT user_id AS \"User ID\", " +
                    "first_name AS \"First Name\", " +
                    "last_name AS \"Last Name\", " +
                    "email AS \"Email\", " +
                    "gender AS \"Gender\", " +
                    "birth_date AS \"Birth Date\", " +
                    "street_address AS \"Address\" " +
                    "FROM Users ;"; // QUERY 2
                grid_members.DataSource = DB_Run_Query(sql_query, DB_connection);
                grid_members.CurrentCell = grid_members.Rows[0].Cells[0];
                // RENTALS
                sql_query = "SELECT rent_date AS \"Rent Date\", " +
                    "Users.user_id AS \"User ID\", " +
                    "first_name AS \"First Name\", " +
                    "last_name AS \"Last Name\", " +
                    "Books.isbn13 AS \"ISBN13\", " +
                    "title AS \"Title\" " +
                    "FROM Users " +
                    "NATURAL JOIN Users_Books " +
                    "NATURAL JOIN Books " +
                    "ORDER BY rent_date;"; // QUERY 3
                grid_rentals.DataSource = DB_Run_Query(sql_query, DB_connection);
                grid_rentals.CurrentCell = grid_rentals.Rows[0].Cells[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// QUERY 1, QUERY 2, QUERY 3
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            DB_Load_Data();
        }
        private void btn_logout_Click(object sender, EventArgs e)
        {
            logout();
        }
        private void logout()
        {
            this.Owner.Show();
            this.Dispose();
        }
        private void Viewer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btn_Click(object sender, EventArgs e)
        {
            selected_Button.FlatStyle = FlatStyle.Standard;
            selected_Button.BackColor = Color.LemonChiffon;
            selected_Button = (Button)sender;
            selected_Button.BackColor = Color.PaleGreen;
            selected_Button.FlatStyle = FlatStyle.Popup;
            tabControl.SelectedIndex = selected_Button.TabIndex;
        }
        public static DataTable DB_Run_Query(String sql_query, NpgsqlConnection DB_connection)
        {
            DataTable result = new DataTable();
            DB_connection.Open();
            var command = new NpgsqlCommand(sql_query, DB_connection);
            NpgsqlDataReader dataReader = command.ExecuteReader();
            result.Load(dataReader);
            DB_connection.Close();
            return result;
        }
        // TAB 1 : Books
        String selected_isbn13 = String.Empty;
        private void grid_books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex < 0)
                {
                    return;
                }
                String ISBN13 = grid_books.Rows[e.RowIndex].Cells["ISBN13"].Value.ToString();
                int stock = 0;
                int rented = 0;
                String sql_query =
                    "SELECT book_stock " +
                    "FROM Books " +
                    $"WHERE isbn13 = $${ISBN13}$$ "; // QUERY 4
                DataTable result = Viewer.DB_Run_Query(sql_query, DB_connection);
                stock = int.Parse(result.Rows[0]["book_stock"].ToString());
                sql_query =
                    "SELECT Users_books.isbn13, COUNT(user_id) " +
                    "FROM Books " +
                    "INNER JOIN Users_Books " +
                    "ON Books.isbn13 = Users_Books.isbn13 " +
                    $"WHERE Users_books.isbn13 = $${ISBN13}$$ " +
                    "GROUP BY Users_books.isbn13; ";  // QUERY 5
                result = Viewer.DB_Run_Query(sql_query, DB_connection);
                if (result.Rows.Count > 0)
                {
                    rented = int.Parse(result.Rows[0]["count"].ToString());
                }
                else
                {
                    rented = 0;
                }
                txt_instock.Text = stock.ToString();
                txt_rented.Text = rented.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // QUERY 4, QUERY 5
        private void btn_search_book_Click(object sender, EventArgs e)
        {
            String search_criteria;
            String sql_query = String.Empty;
            String[] array_criteria = new String[] { "isbn13", "title", "author", "publisher" };
            String search_text;
            try
            {
                if (txt_search.Text.Length.Equals(0) || lst_SearchBy_Book.SelectedIndex.Equals(-1))
                {
                    return;
                }
                search_criteria = array_criteria[lst_SearchBy_Book.SelectedIndex];
                search_text = txt_search.Text;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            try
            {
                switch (search_criteria)
                {
                    case "author":
                        sql_query =
                        "SELECT " +
                        "Authors.author_id AS \"Author ID\", " +
                        "Authors.author_name AS \"Author\", " +
                        "title AS \"Title\", " +
                        "Books.isbn13 AS \"ISBN13\", " +
                        "Publishers.publisher_name AS \"Publisher\", " +
                        "language_code AS \"Language\", " +
                        "average_rating AS \"Average Rating\" " +
                        "FROM Authors "+
                        "NATURAL JOIN Books_Authors "+
                        "NATURAL JOIN Books "+
                        "NATURAL JOIN Publishers "+
                        $"WHERE author_name ILIKE $$%{search_text}%$$ " +
                        "ORDER BY Authors.author_name; "; // QUERY 6
                        break;
                    case "publisher":
                        sql_query =
                        "SELECT " +
                        "Authors.author_id AS \"Author ID\", " +
                        "Authors.author_name AS \"Author\", " +
                        "title AS \"Title\", " +
                        "Books.isbn13 AS \"ISBN13\", " +
                        "Publishers.publisher_name AS \"Publisher\", " +
                        "language_code AS \"Language\", " +
                        "average_rating AS \"Average Rating\" " +
                        "FROM Authors " +
                        "NATURAL JOIN Books_Authors " +
                        "NATURAL JOIN Books " +
                        "NATURAL JOIN Publishers " +
                        $"WHERE publisher_name ILIKE $$%{search_text}%$$ " +
                        "ORDER BY Authors.author_name; "; // QUERY 7
                        break;
                    default:
                        sql_query =
                        "SELECT " +
                        "Books.isbn13 AS \"ISBN13\", " +
                        "title AS \"Title\", " +
                        "Authors.author_name AS \"Author\", " +
                        "Publishers.publisher_name AS \"Publisher\", " +
                        "language_code AS \"Language\", " +
                        "average_rating AS \"Average Rating\" " +
                        "FROM Books " +
                        "INNER JOIN " +
                             "(SELECT Books_Authors.isbn13, min(Books_Authors.author_id) AS mx " +
                             "FROM Books_Authors " +
                             "GROUP BY Books_Authors.isbn13) AS Grouped_Authors " +
                        "ON Grouped_Authors.isbn13 = Books.isbn13 " +
                        "INNER JOIN Authors " +
                        "ON Authors.author_id = Grouped_Authors.mx " +
                        "NATURAL JOIN Publishers " +
                        $"WHERE CAST(Books.{search_criteria} AS TEXT) ILIKE $$%{search_text}%$$ " +
                        "ORDER BY Books.title; "; // QUERY 8
                        break;
                }
                grid_books.DataSource = DB_Run_Query(sql_query, DB_connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Owner.Show();
                this.Dispose();
            }
        } // QUERY 6, QUERY 7, QUERY 8
        private void btn_update_book_Click(object sender, EventArgs e)
        {
            UpdateBooks update;
            try
            {
                if (selected_isbn13.Length == 0)
                {
                    return;
                }
                update = new UpdateBooks(DB_connection, selected_isbn13);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DB_Load_Data();
                return;
            }
            update.ShowDialog(); // QUERY 9,10,11,12,13,14,15,16,17,18
            DB_Load_Data();
        }// QUERY 9,10,11,12,13,14,15,16,17,18
        private void btn_add_book_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateBooks update = new UpdateBooks(DB_connection);
                update.ShowDialog();// QUERY 9,10,11,12,13,14,15,16,17,18
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DB_Load_Data();
        }// QUERY 9,10,11,12,13,14,15,16,17,18
        private void btn_delete_book_Click(object sender, EventArgs e)
        {
            try
            {
                String sql_query = $"DELETE FROM Books WHERE isbn13 = $${selected_isbn13}$$ ;"; // QUERY 19
                DB_Run_Query(sql_query, DB_connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DB_Load_Data();
        }
        private void grid_books_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (grid_books.CurrentCell == null)
                {
                    return;
                }
                selected_isbn13 = grid_books.Rows[grid_books.CurrentCell.RowIndex].Cells["ISBN13"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // TAB 2 : Members
        String selected_userid = String.Empty;
        private void grid_members_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                if (grid_members.CurrentCell == null)
                {
                    return;
                }
                selected_userid = grid_members.Rows[grid_members.CurrentCell.RowIndex].Cells["User ID"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btn_member_edit_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateMembers edit = new UpdateMembers(selected_userid, DB_connection);
                edit.ShowDialog();// QUERY 20, 21, 22
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DB_Load_Data();
        }// QUERY 20, 21, 22
        private void btn_member_add_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateMembers save = new UpdateMembers(DB_connection);
                save.ShowDialog();// QUERY 20, 21, 22
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DB_Load_Data();
        }// QUERY 20, 21, 22
        private void btn_member_delete_Click(object sender, EventArgs e)
        {
            try
            {
                String sql_query = $"DELETE FROM Users WHERE user_id = $${ selected_userid }$$;";// QUERY 23
                DB_Run_Query(sql_query, DB_connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DB_Load_Data();
        }// QUERY 23
        private void btn_search_member_Click(object sender, EventArgs e)
        {
            try
            {
                String[] search_criteria = new string[] { "user_id", "last_name", "email" };
                String sql_query = String.Empty;
                if (lst_SearchBy_member.SelectedIndex.Equals(0))
                {
                    sql_query = "SELECT user_id AS \"User ID\", " +
                        "first_name AS \"First Name\", " +
                        "last_name AS \"Last Name\", " +
                        "email AS \"Email\", " +
                        "gender AS \"Gender\", " +
                        "birth_date AS \"Birth Date\", " +
                        "street_address AS \"Address\" " +
                        "FROM Users " +
                        $"WHERE { search_criteria[lst_SearchBy_member.SelectedIndex] } = $${ txt_search2.Text }$$;";// QUERY 24
                }
                else
                {
                    sql_query = "SELECT user_id AS \"User ID\", " +
                        "first_name AS \"First Name\", " +
                        "last_name AS \"Last Name\", " +
                        "email AS \"Email\", " +
                        "gender AS \"Gender\", " +
                        "birth_date AS \"Birth Date\", " +
                        "street_address AS \"Address\" " +
                        "FROM Users " +
                        $"WHERE { search_criteria[lst_SearchBy_member.SelectedIndex] } ILIKE $$%{ txt_search2.Text }%$$;";// QUERY 25
                }

                DataTable dt = DB_Run_Query(sql_query, DB_connection);
                grid_members.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }// QUERY 24, 25
        // TAB 3 : Rentals
        private void btn_add_rent_Click(object sender, EventArgs e)
        {
            UpdateRentals rentals;
            try
            {
                if (!Is_Book_Available(selected_isbn13))
                {
                    MessageBox.Show($"Selected book is not available.\nISBN13 = {selected_isbn13}");
                    return;
                }
                rentals = new UpdateRentals(selected_isbn13, selected_userid, DB_connection);
                rentals.SetText(
                    grid_books.Rows[grid_books.CurrentCell.RowIndex].Cells["Title"].Value.ToString(),
                    grid_members.Rows[grid_members.CurrentCell.RowIndex].Cells["First Name"].Value.ToString(),
                    grid_members.Rows[grid_members.CurrentCell.RowIndex].Cells["Last Name"].Value.ToString()
                    );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            rentals.ShowDialog();// QUERY 26
            DB_Load_Data();
        }// QUERY 26
        private void btn_delete_rent_Click(object sender, EventArgs e)
        {
            try
            {
                String isbn13 = grid_rentals.Rows[grid_rentals.CurrentCell.RowIndex].Cells["ISBN13"].Value.ToString();
                String user_id = grid_rentals.Rows[grid_rentals.CurrentCell.RowIndex].Cells["User ID"].Value.ToString();
                String sql_query =
                    "DELETE FROM Users_Books " +
                    $"WHERE user_id = $${user_id}$$ " +
                    $"AND isbn13 = $${isbn13}$$ "; // QUERY 27
                DB_Run_Query(sql_query, DB_connection);
                DB_Load_Data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }// QUERY 27
        public bool Is_Book_Available(String ISBN13)
        {
            int stock = 0;
            int rented = 0;

            String sql_query =
                "SELECT book_stock " +
                "FROM Books " +
                $"WHERE isbn13 = $${ISBN13}$$ ";
            DataTable result = Viewer.DB_Run_Query(sql_query, DB_connection); // QUERY 28
            stock = int.Parse(result.Rows[0]["book_stock"].ToString());

            sql_query =
                "SELECT Users_books.isbn13, COUNT(user_id) " +
                "FROM Books " +
                "INNER JOIN Users_Books " +
                "ON Books.isbn13 = Users_Books.isbn13 " +
                $"WHERE Users_books.isbn13 = $${ISBN13}$$ " +
                "GROUP BY Users_books.isbn13; "; // QUERY 29
            result = Viewer.DB_Run_Query(sql_query, DB_connection);
            if (result.Rows.Count.Equals(0))
            {
                rented = 0;
            }
            else
            {
                rented = int.Parse(result.Rows[0]["count"].ToString());
            }
            return stock > rented;
        }// QUERY 28, 29
        private void btn_search_rent_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_search3.Text.Length.Equals(0) || lst_SearchBy_rent.SelectedIndex.Equals(-1))
                {
                    return;
                }
                String[] array_criteria = new String[] { "isbn13", "user_id", "title", "last_name" };
                String sql_query = String.Empty;
                if (lst_SearchBy_rent.SelectedIndex > 1)
                {
                    sql_query =
                        "SELECT rent_date AS \"Rent Date\", " +
                        "Users.user_id AS \"User ID\", " +
                        "first_name AS \"First Name\", " +
                        "last_name AS \"Last Name\", " +
                        "Books.isbn13 AS \"ISBN13\", " +
                        "title AS \"Title\" " +
                        "FROM Users " +
                        "NATURAL JOIN Users_Books " +
                        "NATURAL JOIN Books " +
                        $"WHERE { array_criteria[lst_SearchBy_rent.SelectedIndex] } ILIKE $$%{ txt_search3.Text }%$$; ";// QUERY 30
                }
                else
                {
                    sql_query =
                        "SELECT rent_date AS \"Rent Date\", " +
                        "Users.user_id AS \"User ID\", " +
                        "first_name AS \"First Name\", " +
                        "last_name AS \"Last Name\", " +
                        "Books.isbn13 AS \"ISBN13\", " +
                        "title AS \"Title\" " +
                        "FROM Users " +
                        "NATURAL JOIN Users_Books " +
                        "NATURAL JOIN Books " +
                        $"WHERE { array_criteria[lst_SearchBy_rent.SelectedIndex] } = $${ txt_search3.Text }$$; ";// QUERY 31
                }
                DataTable result = DB_Run_Query(sql_query, DB_connection);
                grid_rentals.DataSource = result;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }// QUERY 30, 31

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            //
            // ΑΝΑΖΗΤΗΣΗ ΚΑΘΩΣ Ο ΧΡΗΣΤΗΣ ΓΡΑΦΕΙ ΣΤΗΝ ΕΙΣΟΔΟ ΤΟ ΚΕΙΜΕΝΟ ΑΝΑΖΗΤΗΣΗΣ
            // ΓΙΑ ΤΑ ΒΙΒΛΙΑ


            //String search_criteria;
            //String sql_query = String.Empty;
            //String[] array_criteria = new String[] { "isbn13", "title", "author", "publisher" };
            //String search_text;
            //try
            //{
            //    if (txt_search.Text.Length.Equals(0) || lst_SearchBy_Book.SelectedIndex.Equals(-1))
            //    {
            //        return;
            //    }
            //    search_criteria = array_criteria[lst_SearchBy_Book.SelectedIndex];
            //    search_text = txt_search.Text;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;
            //}
            //try
            //{
            //    switch (search_criteria)
            //    {
            //        case "author":
            //            sql_query =
            //            "SELECT " +
            //            "Authors.author_id AS \"Author ID\", " +
            //            "Authors.author_name AS \"Author\", " +
            //            "title AS \"Title\", " +
            //            "Books.isbn13 AS \"ISBN13\", " +
            //            "Publishers.publisher_name AS \"Publisher\", " +
            //            "language_code AS \"Language\", " +
            //            "average_rating AS \"Average Rating\" " +
            //            "FROM Authors " +
            //            "NATURAL JOIN Books_Authors " +
            //            "NATURAL JOIN Books " +
            //            "NATURAL JOIN Publishers " +
            //            $"WHERE author_name ILIKE $$%{search_text}%$$ " +
            //            "ORDER BY Authors.author_name; "; // QUERY 6
            //            break;
            //        case "publisher":
            //            sql_query =
            //            "SELECT " +
            //            "Authors.author_id AS \"Author ID\", " +
            //            "Authors.author_name AS \"Author\", " +
            //            "title AS \"Title\", " +
            //            "Books.isbn13 AS \"ISBN13\", " +
            //            "Publishers.publisher_name AS \"Publisher\", " +
            //            "language_code AS \"Language\", " +
            //            "average_rating AS \"Average Rating\" " +
            //            "FROM Authors " +
            //            "NATURAL JOIN Books_Authors " +
            //            "NATURAL JOIN Books " +
            //            "NATURAL JOIN Publishers " +
            //            $"WHERE publisher_name ILIKE $$%{search_text}%$$ " +
            //            "ORDER BY Authors.author_name; "; // QUERY 7
            //            break;
            //        default:
            //            sql_query =
            //            "SELECT " +
            //            "Books.isbn13 AS \"ISBN13\", " +
            //            "title AS \"Title\", " +
            //            "Authors.author_name AS \"Author\", " +
            //            "Publishers.publisher_name AS \"Publisher\", " +
            //            "language_code AS \"Language\", " +
            //            "average_rating AS \"Average Rating\" " +
            //            "FROM Books " +
            //            "INNER JOIN " +
            //                 "(SELECT Books_Authors.isbn13, min(Books_Authors.author_id) AS mx " +
            //                 "FROM Books_Authors " +
            //                 "GROUP BY Books_Authors.isbn13) AS Grouped_Authors " +
            //            "ON Grouped_Authors.isbn13 = Books.isbn13 " +
            //            "INNER JOIN Authors " +
            //            "ON Authors.author_id = Grouped_Authors.mx " +
            //            "NATURAL JOIN Publishers " +
            //            $"WHERE CAST(Books.{search_criteria} AS TEXT) ILIKE $$%{search_text}%$$ " +
            //            "ORDER BY Books.title; "; // QUERY 8
            //            break;
            //    }
            //    grid_books.DataSource = DB_Run_Query(sql_query, DB_connection);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    this.Owner.Show();
            //    this.Dispose();
            //}
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This application was created by:\nMaria Traga, mppl19058, mariatr25li@gmail.com\nDimitris Malliaris, mppl19034, dimitris.mlr@outlook.com");
        }
    }
}