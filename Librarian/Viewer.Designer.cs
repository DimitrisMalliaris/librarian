namespace Librarian
{
    partial class Viewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Viewer));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_rentals = new System.Windows.Forms.Button();
            this.btn_members = new System.Windows.Forms.Button();
            this.btn_books = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.grid_members = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_search_member = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lst_SearchBy_member = new System.Windows.Forms.ComboBox();
            this.txt_search2 = new System.Windows.Forms.TextBox();
            this.btn_member_delete = new System.Windows.Forms.Button();
            this.btn_member_add = new System.Windows.Forms.Button();
            this.btn_member_edit = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.grid_books = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_rented = new System.Windows.Forms.TextBox();
            this.btn_search_book = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_instock = new System.Windows.Forms.TextBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lst_SearchBy_Book = new System.Windows.Forms.ComboBox();
            this.btn_delete_book = new System.Windows.Forms.Button();
            this.btn_add_book = new System.Windows.Forms.Button();
            this.btn_update_book = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grid_rentals = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search_rent = new System.Windows.Forms.Button();
            this.lst_SearchBy_rent = new System.Windows.Forms.ComboBox();
            this.txt_search3 = new System.Windows.Forms.TextBox();
            this.btn_delete_rent = new System.Windows.Forms.Button();
            this.btn_add_rent = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_members)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_books)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_rentals)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_refresh);
            this.panel1.Controls.Add(this.btn_about);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.btn_rentals);
            this.panel1.Controls.Add(this.btn_members);
            this.panel1.Controls.Add(this.btn_books);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 73);
            this.panel1.TabIndex = 0;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_logout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_logout.Image = ((System.Drawing.Image)(resources.GetObject("btn_logout.Image")));
            this.btn_logout.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_logout.Location = new System.Drawing.Point(968, 0);
            this.btn_logout.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(98, 73);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "Log out";
            this.btn_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_rentals
            // 
            this.btn_rentals.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_rentals.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_rentals.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_rentals.Image = ((System.Drawing.Image)(resources.GetObject("btn_rentals.Image")));
            this.btn_rentals.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_rentals.Location = new System.Drawing.Point(196, 0);
            this.btn_rentals.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.btn_rentals.Name = "btn_rentals";
            this.btn_rentals.Size = new System.Drawing.Size(98, 73);
            this.btn_rentals.TabIndex = 2;
            this.btn_rentals.Text = "Rentals";
            this.btn_rentals.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_rentals.UseVisualStyleBackColor = false;
            this.btn_rentals.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_members
            // 
            this.btn_members.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_members.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_members.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_members.Image = ((System.Drawing.Image)(resources.GetObject("btn_members.Image")));
            this.btn_members.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_members.Location = new System.Drawing.Point(98, 0);
            this.btn_members.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.btn_members.Name = "btn_members";
            this.btn_members.Size = new System.Drawing.Size(98, 73);
            this.btn_members.TabIndex = 1;
            this.btn_members.Text = "Members";
            this.btn_members.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_members.UseVisualStyleBackColor = false;
            this.btn_members.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn_books
            // 
            this.btn_books.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_books.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_books.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_books.Image = ((System.Drawing.Image)(resources.GetObject("btn_books.Image")));
            this.btn_books.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_books.Location = new System.Drawing.Point(0, 0);
            this.btn_books.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.btn_books.Name = "btn_books";
            this.btn_books.Size = new System.Drawing.Size(98, 73);
            this.btn_books.TabIndex = 0;
            this.btn_books.Text = "Books";
            this.btn_books.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_books.UseVisualStyleBackColor = false;
            this.btn_books.Click += new System.EventHandler(this.btn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Bisque;
            this.tabPage4.Controls.Add(this.grid_members);
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1058, 516);
            this.tabPage4.TabIndex = 3;
            // 
            // grid_members
            // 
            this.grid_members.AllowUserToAddRows = false;
            this.grid_members.AllowUserToDeleteRows = false;
            this.grid_members.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_members.BackgroundColor = System.Drawing.Color.Sienna;
            this.grid_members.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_members.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_members.Location = new System.Drawing.Point(0, 73);
            this.grid_members.Name = "grid_members";
            this.grid_members.ReadOnly = true;
            this.grid_members.RowHeadersVisible = false;
            this.grid_members.Size = new System.Drawing.Size(1058, 443);
            this.grid_members.TabIndex = 3;
            this.grid_members.CurrentCellChanged += new System.EventHandler(this.grid_members_CurrentCellChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.btn_member_delete);
            this.panel4.Controls.Add(this.btn_member_add);
            this.panel4.Controls.Add(this.btn_member_edit);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1058, 73);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_search_member);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Controls.Add(this.lst_SearchBy_member);
            this.panel7.Controls.Add(this.txt_search2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel7.Location = new System.Drawing.Point(557, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(501, 73);
            this.panel7.TabIndex = 32;
            // 
            // btn_search_member
            // 
            this.btn_search_member.BackColor = System.Drawing.Color.White;
            this.btn_search_member.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search_member.BackgroundImage")));
            this.btn_search_member.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search_member.FlatAppearance.BorderSize = 0;
            this.btn_search_member.Location = new System.Drawing.Point(467, 3);
            this.btn_search_member.Name = "btn_search_member";
            this.btn_search_member.Size = new System.Drawing.Size(26, 25);
            this.btn_search_member.TabIndex = 6;
            this.btn_search_member.UseVisualStyleBackColor = false;
            this.btn_search_member.Click += new System.EventHandler(this.btn_search_member_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(142, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Search By:";
            // 
            // lst_SearchBy_member
            // 
            this.lst_SearchBy_member.FormattingEnabled = true;
            this.lst_SearchBy_member.Items.AddRange(new object[] {
            "ID",
            "Last Name",
            "Email"});
            this.lst_SearchBy_member.Location = new System.Drawing.Point(223, 3);
            this.lst_SearchBy_member.Name = "lst_SearchBy_member";
            this.lst_SearchBy_member.Size = new System.Drawing.Size(132, 26);
            this.lst_SearchBy_member.TabIndex = 2;
            // 
            // txt_search2
            // 
            this.txt_search2.Location = new System.Drawing.Point(361, 3);
            this.txt_search2.Name = "txt_search2";
            this.txt_search2.Size = new System.Drawing.Size(100, 25);
            this.txt_search2.TabIndex = 0;
            // 
            // btn_member_delete
            // 
            this.btn_member_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_member_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_member_delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_member_delete.Image")));
            this.btn_member_delete.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_member_delete.Location = new System.Drawing.Point(232, 0);
            this.btn_member_delete.Name = "btn_member_delete";
            this.btn_member_delete.Size = new System.Drawing.Size(115, 73);
            this.btn_member_delete.TabIndex = 5;
            this.btn_member_delete.Text = "Delete member";
            this.btn_member_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_member_delete.UseVisualStyleBackColor = true;
            this.btn_member_delete.Click += new System.EventHandler(this.btn_member_delete_Click);
            // 
            // btn_member_add
            // 
            this.btn_member_add.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_member_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_member_add.Image = ((System.Drawing.Image)(resources.GetObject("btn_member_add.Image")));
            this.btn_member_add.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_member_add.Location = new System.Drawing.Point(116, 0);
            this.btn_member_add.Name = "btn_member_add";
            this.btn_member_add.Size = new System.Drawing.Size(116, 73);
            this.btn_member_add.TabIndex = 4;
            this.btn_member_add.Text = "Add member";
            this.btn_member_add.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_member_add.UseVisualStyleBackColor = true;
            this.btn_member_add.Click += new System.EventHandler(this.btn_member_add_Click);
            // 
            // btn_member_edit
            // 
            this.btn_member_edit.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_member_edit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_member_edit.Image = ((System.Drawing.Image)(resources.GetObject("btn_member_edit.Image")));
            this.btn_member_edit.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_member_edit.Location = new System.Drawing.Point(0, 0);
            this.btn_member_edit.Name = "btn_member_edit";
            this.btn_member_edit.Size = new System.Drawing.Size(116, 73);
            this.btn_member_edit.TabIndex = 3;
            this.btn_member_edit.Text = "Edit member";
            this.btn_member_edit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_member_edit.UseVisualStyleBackColor = true;
            this.btn_member_edit.Click += new System.EventHandler(this.btn_member_edit_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Bisque;
            this.tabPage3.Controls.Add(this.panel3);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1058, 516);
            this.tabPage3.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.grid_books);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 73);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1058, 443);
            this.panel3.TabIndex = 4;
            // 
            // grid_books
            // 
            this.grid_books.AllowUserToAddRows = false;
            this.grid_books.AllowUserToDeleteRows = false;
            this.grid_books.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_books.BackgroundColor = System.Drawing.Color.Sienna;
            this.grid_books.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_books.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_books.Location = new System.Drawing.Point(0, 0);
            this.grid_books.Name = "grid_books";
            this.grid_books.ReadOnly = true;
            this.grid_books.RowHeadersVisible = false;
            this.grid_books.Size = new System.Drawing.Size(1058, 443);
            this.grid_books.TabIndex = 2;
            this.grid_books.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_books_CellClick);
            this.grid_books.CurrentCellChanged += new System.EventHandler(this.grid_books_CurrentCellChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel8);
            this.panel5.Controls.Add(this.btn_delete_book);
            this.panel5.Controls.Add(this.btn_add_book);
            this.panel5.Controls.Add(this.btn_update_book);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1058, 73);
            this.panel5.TabIndex = 1;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label5);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.txt_rented);
            this.panel8.Controls.Add(this.btn_search_book);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.txt_instock);
            this.panel8.Controls.Add(this.txt_search);
            this.panel8.Controls.Add(this.lst_SearchBy_Book);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(557, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(501, 73);
            this.panel8.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 18);
            this.label5.TabIndex = 31;
            this.label5.Text = "Rented:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 18);
            this.label1.TabIndex = 30;
            this.label1.Text = "In Stock:";
            // 
            // txt_rented
            // 
            this.txt_rented.Location = new System.Drawing.Point(74, 42);
            this.txt_rented.Name = "txt_rented";
            this.txt_rented.Size = new System.Drawing.Size(40, 25);
            this.txt_rented.TabIndex = 29;
            // 
            // btn_search_book
            // 
            this.btn_search_book.BackColor = System.Drawing.Color.White;
            this.btn_search_book.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search_book.BackgroundImage")));
            this.btn_search_book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search_book.FlatAppearance.BorderSize = 0;
            this.btn_search_book.Location = new System.Drawing.Point(472, 3);
            this.btn_search_book.Name = "btn_search_book";
            this.btn_search_book.Size = new System.Drawing.Size(26, 25);
            this.btn_search_book.TabIndex = 3;
            this.btn_search_book.UseVisualStyleBackColor = false;
            this.btn_search_book.Click += new System.EventHandler(this.btn_search_book_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Search By:";
            // 
            // txt_instock
            // 
            this.txt_instock.Location = new System.Drawing.Point(74, 8);
            this.txt_instock.Name = "txt_instock";
            this.txt_instock.Size = new System.Drawing.Size(40, 25);
            this.txt_instock.TabIndex = 28;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(366, 3);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(100, 25);
            this.txt_search.TabIndex = 0;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // lst_SearchBy_Book
            // 
            this.lst_SearchBy_Book.FormattingEnabled = true;
            this.lst_SearchBy_Book.Items.AddRange(new object[] {
            "ISBN(13)",
            "Title",
            "Author",
            "Publisher"});
            this.lst_SearchBy_Book.Location = new System.Drawing.Point(228, 3);
            this.lst_SearchBy_Book.Name = "lst_SearchBy_Book";
            this.lst_SearchBy_Book.Size = new System.Drawing.Size(132, 26);
            this.lst_SearchBy_Book.TabIndex = 2;
            // 
            // btn_delete_book
            // 
            this.btn_delete_book.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_delete_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete_book.Image")));
            this.btn_delete_book.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_delete_book.Location = new System.Drawing.Point(230, 0);
            this.btn_delete_book.Name = "btn_delete_book";
            this.btn_delete_book.Size = new System.Drawing.Size(115, 73);
            this.btn_delete_book.TabIndex = 27;
            this.btn_delete_book.Text = "Delete book";
            this.btn_delete_book.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delete_book.UseVisualStyleBackColor = true;
            this.btn_delete_book.Click += new System.EventHandler(this.btn_delete_book_Click);
            // 
            // btn_add_book
            // 
            this.btn_add_book.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_add_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_book.Image")));
            this.btn_add_book.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add_book.Location = new System.Drawing.Point(115, 0);
            this.btn_add_book.Name = "btn_add_book";
            this.btn_add_book.Size = new System.Drawing.Size(115, 73);
            this.btn_add_book.TabIndex = 26;
            this.btn_add_book.Text = "Add book";
            this.btn_add_book.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add_book.UseVisualStyleBackColor = true;
            this.btn_add_book.Click += new System.EventHandler(this.btn_add_book_Click);
            // 
            // btn_update_book
            // 
            this.btn_update_book.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_update_book.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_update_book.Image = ((System.Drawing.Image)(resources.GetObject("btn_update_book.Image")));
            this.btn_update_book.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_update_book.Location = new System.Drawing.Point(0, 0);
            this.btn_update_book.Name = "btn_update_book";
            this.btn_update_book.Size = new System.Drawing.Size(115, 73);
            this.btn_update_book.TabIndex = 23;
            this.btn_update_book.Text = "Update book";
            this.btn_update_book.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_update_book.UseVisualStyleBackColor = true;
            this.btn_update_book.Click += new System.EventHandler(this.btn_update_book_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 73);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1066, 547);
            this.tabControl.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Bisque;
            this.tabPage2.Controls.Add(this.grid_rentals);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1058, 516);
            this.tabPage2.TabIndex = 4;
            // 
            // grid_rentals
            // 
            this.grid_rentals.AllowUserToAddRows = false;
            this.grid_rentals.AllowUserToDeleteRows = false;
            this.grid_rentals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_rentals.BackgroundColor = System.Drawing.Color.Sienna;
            this.grid_rentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_rentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid_rentals.Location = new System.Drawing.Point(0, 73);
            this.grid_rentals.Name = "grid_rentals";
            this.grid_rentals.ReadOnly = true;
            this.grid_rentals.RowHeadersVisible = false;
            this.grid_rentals.Size = new System.Drawing.Size(1058, 443);
            this.grid_rentals.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel2);
            this.panel6.Controls.Add(this.btn_delete_rent);
            this.panel6.Controls.Add(this.btn_add_rent);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1058, 73);
            this.panel6.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_search_rent);
            this.panel2.Controls.Add(this.lst_SearchBy_rent);
            this.panel2.Controls.Add(this.txt_search3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(557, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(501, 73);
            this.panel2.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(142, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Search By:";
            // 
            // btn_search_rent
            // 
            this.btn_search_rent.BackColor = System.Drawing.Color.White;
            this.btn_search_rent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_search_rent.BackgroundImage")));
            this.btn_search_rent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search_rent.FlatAppearance.BorderSize = 0;
            this.btn_search_rent.Location = new System.Drawing.Point(467, 3);
            this.btn_search_rent.Name = "btn_search_rent";
            this.btn_search_rent.Size = new System.Drawing.Size(26, 25);
            this.btn_search_rent.TabIndex = 3;
            this.btn_search_rent.UseVisualStyleBackColor = false;
            this.btn_search_rent.Click += new System.EventHandler(this.btn_search_rent_Click);
            // 
            // lst_SearchBy_rent
            // 
            this.lst_SearchBy_rent.FormattingEnabled = true;
            this.lst_SearchBy_rent.Items.AddRange(new object[] {
            "ISBN(13)",
            "Member ID",
            "Title",
            "Member last name"});
            this.lst_SearchBy_rent.Location = new System.Drawing.Point(223, 3);
            this.lst_SearchBy_rent.Name = "lst_SearchBy_rent";
            this.lst_SearchBy_rent.Size = new System.Drawing.Size(132, 26);
            this.lst_SearchBy_rent.TabIndex = 2;
            // 
            // txt_search3
            // 
            this.txt_search3.Location = new System.Drawing.Point(361, 3);
            this.txt_search3.Name = "txt_search3";
            this.txt_search3.Size = new System.Drawing.Size(100, 25);
            this.txt_search3.TabIndex = 0;
            // 
            // btn_delete_rent
            // 
            this.btn_delete_rent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_delete_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete_rent.Image = ((System.Drawing.Image)(resources.GetObject("btn_delete_rent.Image")));
            this.btn_delete_rent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_delete_rent.Location = new System.Drawing.Point(116, 0);
            this.btn_delete_rent.Name = "btn_delete_rent";
            this.btn_delete_rent.Size = new System.Drawing.Size(116, 73);
            this.btn_delete_rent.TabIndex = 30;
            this.btn_delete_rent.Text = "Return book";
            this.btn_delete_rent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_delete_rent.UseVisualStyleBackColor = true;
            this.btn_delete_rent.Click += new System.EventHandler(this.btn_delete_rent_Click);
            // 
            // btn_add_rent
            // 
            this.btn_add_rent.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_add_rent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_rent.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_rent.Image")));
            this.btn_add_rent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_add_rent.Location = new System.Drawing.Point(0, 0);
            this.btn_add_rent.Name = "btn_add_rent";
            this.btn_add_rent.Size = new System.Drawing.Size(116, 73);
            this.btn_add_rent.TabIndex = 29;
            this.btn_add_rent.Text = "Rent book";
            this.btn_add_rent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_add_rent.UseVisualStyleBackColor = true;
            this.btn_add_rent.Click += new System.EventHandler(this.btn_add_rent_Click);
            // 
            // btn_about
            // 
            this.btn_about.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_about.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_about.Image = ((System.Drawing.Image)(resources.GetObject("btn_about.Image")));
            this.btn_about.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_about.Location = new System.Drawing.Point(870, 0);
            this.btn_about.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(98, 73);
            this.btn_about.TabIndex = 5;
            this.btn_about.Text = "About";
            this.btn_about.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_about.UseVisualStyleBackColor = false;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.Color.LemonChiffon;
            this.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_refresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_refresh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refresh.Image")));
            this.btn_refresh.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_refresh.Location = new System.Drawing.Point(772, 0);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(98, 73);
            this.btn_refresh.TabIndex = 6;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Viewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1066, 620);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 7, 2, 7);
            this.Name = "Viewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIBRARIAN v1.0.0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Viewer_FormClosed);
            this.Load += new System.EventHandler(this.Viewer_Load);
            this.panel1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_members)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_books)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_rentals)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_rentals;
        private System.Windows.Forms.Button btn_members;
        private System.Windows.Forms.Button btn_books;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox lst_SearchBy_member;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_search2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView grid_books;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btn_search_book;
        private System.Windows.Forms.ComboBox lst_SearchBy_Book;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btn_search_rent;
        private System.Windows.Forms.ComboBox lst_SearchBy_rent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_search3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_update_book;
        private System.Windows.Forms.Button btn_member_delete;
        private System.Windows.Forms.Button btn_member_add;
        private System.Windows.Forms.Button btn_member_edit;
        private System.Windows.Forms.Button btn_delete_book;
        private System.Windows.Forms.Button btn_add_book;
        private System.Windows.Forms.DataGridView grid_members;
        private System.Windows.Forms.DataGridView grid_rentals;
        private System.Windows.Forms.Button btn_search_member;
        private System.Windows.Forms.Button btn_delete_rent;
        private System.Windows.Forms.Button btn_add_rent;
        private System.Windows.Forms.TextBox txt_rented;
        private System.Windows.Forms.TextBox txt_instock;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.Button btn_about;
    }
}