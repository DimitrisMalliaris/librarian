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
    public partial class UpdateBooks : Form
    {
        NpgsqlConnection DB_connection;
        String selected_ISBN13 = String.Empty;
        public UpdateBooks(NpgsqlConnection DB_connection, String ISBN13)
        {
            InitializeComponent();
            this.DB_connection = DB_connection;
            this.selected_ISBN13 = ISBN13;
            Load_();
            txt_auth.Text = String.Empty;
        }
        List<String> book_info = new List<string>();
        public void Set_Values(DataTable DT_selected_book_info, DataTable DT_selected_book_artists)
        {
            foreach (DataColumn dataColumn in DT_selected_book_info.Columns)
            {
                book_info.Add(DT_selected_book_info.Rows[0][dataColumn].ToString());
            }
            foreach (TextBox txt in this.Controls.OfType<TextBox>())
            {
                txt.Text = book_info[txt.TabIndex];
            }

            foreach (DataRow row in DT_selected_book_artists.Rows)
            {
                grid_artists.Rows.Add(row[0].ToString());
            }
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            if (btn_update.Text == "UPDATE")
            {
                Update_Book();
            }
            else
            {
                Save_Book();
            }
        }
        private void Update_Book()
        {
            try
            {
                DataTable result = new DataTable();
                String sql_query =
                    "UPDATE Books " +
                    $"SET title = $${txt_title.Text}$$, " +
                    $"average_rating = $${decimal.Parse(txt_rating.Text).ToString("F1")}$$, " +
                    $"ISBN10 = $${txt_isbn10.Text}$$, " +
                    $"language_code = $${txt_lang.Text}$$, " +
                    $"num_pages = $${txt_num_of_pages.Text}$$, " +
                    $"publication_date = \'{DateTime.Parse(txt_pdate.Text).ToString("yyyy-MM-dd")}\', " +
                    $"book_stock = $${ txt_stock.Text }$$ " +
                    $"WHERE isbn13 = \'{txt_isbn13.Text}\';"; // QUERY 9
                Viewer.DB_Run_Query(sql_query, DB_connection);

                // DELETE PREVIOUS AUTHORS
                sql_query = $"DELETE FROM books_authors WHERE isbn13 = $${txt_isbn13.Text}$$"; // QUERY 10
                Viewer.DB_Run_Query(sql_query, DB_connection);
                // FOR EACH AUTHOR
                foreach (DataGridViewRow row in grid_artists.Rows)
                {
                    String author_ID = String.Empty;
                    // CHECK IF AUTHOR EXISTS AND GET ID
                    sql_query = $"SELECT author_id FROM authors WHERE author_name = $${row.Cells[0].Value}$$;"; // QUERY 11
                    result = Viewer.DB_Run_Query(sql_query, DB_connection);
                    if (result.Rows.Count.Equals(0))
                    {
                        //IF NOT
                        // INSERT NEW AUTHOR 
                        sql_query = $"INSERT INTO authors (author_id, author_name) SELECT MAX(author_id)+1 , $${row.Cells[0].Value}$$ FROM authors;"; // QUERY 12
                        Viewer.DB_Run_Query(sql_query, DB_connection);
                        // GET AUTHOR ID
                        sql_query = $"SELECT author_id FROM authors WHERE author_name = $${row.Cells[0].Value}$$;"; // QUERY 13
                        result = Viewer.DB_Run_Query(sql_query, DB_connection);
                        author_ID = result.Rows[0]["author_ID"].ToString();
                    }
                    else
                    {
                        author_ID = result.Rows[0]["author_ID"].ToString();
                    }
                    // ADD NEW AUTHOR RELATION
                    sql_query = $"INSERT INTO books_authors VALUES ($${txt_isbn13.Text}$$,$${author_ID}$$);"; // QUERY 14
                    Viewer.DB_Run_Query(sql_query, DB_connection);
                }
                // PUBLISHER
                String publisher_ID = String.Empty;
                // CHECK IF PUBLISHER EXISTS AND GET ID
                sql_query = $"SELECT publisher_id FROM publishers WHERE publisher_name = $${ txt_pub.Text }$$; "; // QUERY 15
                result = Viewer.DB_Run_Query(sql_query, DB_connection);

                if (result.Rows.Count.Equals(0))
                {
                    // IF NOT 
                    // ADD NEW PUBLISHER IN PUBLISHERS
                    sql_query = $"INSERT INTO publishers (publisher_id, publisher_name) SELECT MAX(publisher_id)+1 , $${ txt_pub.Text }$$ FROM publishers;"; // QUERY 16
                    Viewer.DB_Run_Query(sql_query, DB_connection);
                    // GET NEW ID FROM NEW PUBLISHER
                    sql_query = $"SELECT publisher_id FROM publishers WHERE publisher_name = $${ txt_pub.Text }$$;"; // QUERY 17
                    result = Viewer.DB_Run_Query(sql_query, DB_connection);
                }

                publisher_ID = result.Rows[0]["publisher_id"].ToString();
                // UPDATE PUBLISHER ID IN BOOKS
                sql_query = $"UPDATE Books SET publisher_id = $${ publisher_ID }$$ WHERE isbn13 = $${ txt_isbn13.Text }$$;"; // QUERY 18
                Viewer.DB_Run_Query(sql_query, DB_connection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } // QUERY 9,10,11,12,13,14,15,16,17,18
        private void Load_()
        {
            try
            {
                String sql_query =
                    "SELECT " +
                    "Books.isbn13 AS \"ISBN13\",  " +
                    "title AS \"Title\",  " +
                    "Publishers.publisher_name AS \"Publisher\",  " +
                    "language_code AS \"Language\", " +
                    "num_pages AS \"Number of pages\", " +
                    "isbn10 AS \"ISBN10\", " +
                    "average_rating AS \"Average Rating\", " +
                    "publication_date AS \"Publication Date\", " +
                    "book_stock AS  \"Stock\" " +
                    "FROM Books " +
                    "NATURAL JOIN Publishers " +
                    $"WHERE isbn13 = \'{selected_ISBN13}\'";
                DataTable DT_selected_book_info = Viewer.DB_Run_Query(sql_query, DB_connection);
                sql_query =
                    "SELECT Authors.author_name AS \"Author\" " +
                    "FROM Authors " +
                    "NATURAL JOIN Books_Authors " +
                    "NATURAL JOIN Books " +
                    $"WHERE Books.isbn13 = \'{selected_ISBN13}\';";
                DataTable DT_selected_book_artists = Viewer.DB_Run_Query(sql_query, DB_connection);

                Set_Values(DT_selected_book_info, DT_selected_book_artists);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Close();
            }
        }
        private void btn_add_author_Click(object sender, EventArgs e)
        {
            grid_artists.Rows.Add(txt_auth.Text);
        }
        private void btn_delete_author_Click(object sender, EventArgs e)
        {
            if (grid_artists.CurrentCell.RowIndex.Equals(-1))
            {
                return;
            }
            grid_artists.Rows.Remove(grid_artists.Rows[grid_artists.CurrentCell.RowIndex]);
        }
        public UpdateBooks(NpgsqlConnection DB_connection)
        {
            InitializeComponent();
            this.DB_connection = DB_connection;
            txt_isbn13.Enabled = true;
            btn_update.Text = "SAVE";
            this.Text = "Add new book";
        }
        private void Save_Book()
        {
            //QUERY 7
            DataTable result = new DataTable();
            String sql_query = String.Empty;
            try
            {
                // PUBLISHER
                String publisher_ID = String.Empty;
                // CHECK IF PUBLISHER EXISTS AND GET ID
                sql_query = $"SELECT publisher_id FROM publishers WHERE publisher_name = $${ txt_pub.Text }$$; "; // QUERY 15
                result = Viewer.DB_Run_Query(sql_query, DB_connection);

                if (result.Rows.Count.Equals(0))
                {
                    // IF NOT 
                    // ADD NEW PUBLISHER IN PUBLISHERS
                    sql_query = $"INSERT INTO publishers (publisher_id, publisher_name) SELECT MAX(publisher_id)+1 , $${ txt_pub.Text }$$ FROM publishers;"; // QUERY 16
                    Viewer.DB_Run_Query(sql_query, DB_connection);
                    // GET NEW ID FROM NEW PUBLISHER
                    sql_query = $"SELECT publisher_id FROM publishers WHERE publisher_name = $${ txt_pub.Text }$$;"; // QUERY 17
                    result = Viewer.DB_Run_Query(sql_query, DB_connection);
                }
                publisher_ID = result.Rows[0]["publisher_id"].ToString();

                // INSERT INTO BOOKS BOOK
                sql_query =
                    $"INSERT INTO Books VALUES( " +
                    $"$${ txt_title.Text }$$, " +
                    $"$${ decimal.Parse(txt_rating.Text).ToString("F1") }$$, " +
                    $"$${ txt_isbn10.Text }$$, " +
                    $"$${ txt_isbn13.Text }$$, " +
                    $"$${ txt_lang.Text }$$ , " +
                    $"$${ txt_num_of_pages.Text }$$ , " +
                    $"$${ DateTime.Parse(txt_pdate.Text).ToString("yyyy-MM-dd") }$$ , " +
                    $"$${ publisher_ID }$$ , " +
                    $"$${ txt_stock.Text }$$);"; // QUERY 9
                Viewer.DB_Run_Query(sql_query, DB_connection);

                // AUTHOR
                // CHECK IF AUTHORS EXISTS GET ID
                // FOR EACH AUTHOR
                foreach (DataGridViewRow row in grid_artists.Rows)
                {
                    String author_ID = String.Empty;
                    // CHECK IF AUTHOR EXISTS AND GET ID
                    sql_query = $"SELECT author_id FROM authors WHERE author_name = $${row.Cells[0].Value}$$;"; // QUERY 11
                    result = Viewer.DB_Run_Query(sql_query, DB_connection);
                    if (result.Rows.Count.Equals(0))
                    {
                        //IF NOT
                        // INSERT NEW AUTHOR 
                        sql_query = $"INSERT INTO authors (author_id, author_name) SELECT MAX(author_id)+1 , $${row.Cells[0].Value}$$ FROM authors;"; // QUERY 12
                        Viewer.DB_Run_Query(sql_query, DB_connection);
                        // GET AUTHOR ID
                        sql_query = $"SELECT author_id FROM authors WHERE author_name = $${row.Cells[0].Value}$$;"; // QUERY 13
                        result = Viewer.DB_Run_Query(sql_query, DB_connection);
                        author_ID = result.Rows[0]["author_ID"].ToString();
                    }
                    else
                    {
                        author_ID = result.Rows[0]["author_ID"].ToString();
                    }
                    // ADD NEW book - AUTHOR RELATION
                    sql_query = $"INSERT INTO books_authors VALUES ($${txt_isbn13.Text}$$,$${author_ID}$$);"; // QUERY 14
                    Viewer.DB_Run_Query(sql_query, DB_connection);
                }
            }
            catch (PostgresException ex)
            {
                if (ex.SqlState == "23505")
                {
                    MessageBox.Show("The book with the ISBN13 you entered already exists.");
                }
                DB_connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                DB_connection.Close();
            }
        } // QUERY 9,11,12,13,14,15,16,17
    }
}
