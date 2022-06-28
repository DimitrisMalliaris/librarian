namespace Librarian
{
    partial class UpdateBooks
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_isbn10 = new System.Windows.Forms.TextBox();
            this.grid_artists = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_pub = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_isbn13 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_rating = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_num_of_pages = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_lang = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add_author = new System.Windows.Forms.Button();
            this.btn_delete_author = new System.Windows.Forms.Button();
            this.txt_auth = new System.Windows.Forms.TextBox();
            this.txt_pdate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_stock = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_artists)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Title:";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(12, 33);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(116, 20);
            this.txt_title.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ISBN10:";
            // 
            // txt_isbn10
            // 
            this.txt_isbn10.Location = new System.Drawing.Point(12, 77);
            this.txt_isbn10.Name = "txt_isbn10";
            this.txt_isbn10.Size = new System.Drawing.Size(116, 20);
            this.txt_isbn10.TabIndex = 5;
            // 
            // grid_artists
            // 
            this.grid_artists.AllowUserToAddRows = false;
            this.grid_artists.AllowUserToDeleteRows = false;
            this.grid_artists.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_artists.BackgroundColor = System.Drawing.Color.White;
            this.grid_artists.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_artists.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.grid_artists.GridColor = System.Drawing.Color.White;
            this.grid_artists.Location = new System.Drawing.Point(313, 85);
            this.grid_artists.Name = "grid_artists";
            this.grid_artists.ReadOnly = true;
            this.grid_artists.RowHeadersVisible = false;
            this.grid_artists.Size = new System.Drawing.Size(123, 131);
            this.grid_artists.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Author";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(131, 146);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Publication Date:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(131, 100);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Publisher:";
            // 
            // txt_pub
            // 
            this.txt_pub.Location = new System.Drawing.Point(134, 121);
            this.txt_pub.Name = "txt_pub";
            this.txt_pub.Size = new System.Drawing.Size(116, 20);
            this.txt_pub.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ISBN13:";
            // 
            // txt_isbn13
            // 
            this.txt_isbn13.Enabled = false;
            this.txt_isbn13.Location = new System.Drawing.Point(12, 121);
            this.txt_isbn13.Name = "txt_isbn13";
            this.txt_isbn13.Size = new System.Drawing.Size(116, 20);
            this.txt_isbn13.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Rating:";
            // 
            // txt_rating
            // 
            this.txt_rating.Location = new System.Drawing.Point(12, 167);
            this.txt_rating.Name = "txt_rating";
            this.txt_rating.Size = new System.Drawing.Size(116, 20);
            this.txt_rating.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(131, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Number of pages:";
            // 
            // txt_num_of_pages
            // 
            this.txt_num_of_pages.Location = new System.Drawing.Point(134, 33);
            this.txt_num_of_pages.Name = "txt_num_of_pages";
            this.txt_num_of_pages.Size = new System.Drawing.Size(116, 20);
            this.txt_num_of_pages.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 56);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Language:";
            // 
            // txt_lang
            // 
            this.txt_lang.Location = new System.Drawing.Point(134, 77);
            this.txt_lang.Name = "txt_lang";
            this.txt_lang.Size = new System.Drawing.Size(116, 20);
            this.txt_lang.TabIndex = 3;
            // 
            // btn_update
            // 
            this.btn_update.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_update.Location = new System.Drawing.Point(12, 193);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(75, 23);
            this.btn_update.TabIndex = 21;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(106, 193);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 22;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "New author:";
            // 
            // btn_add_author
            // 
            this.btn_add_author.Location = new System.Drawing.Point(313, 56);
            this.btn_add_author.Name = "btn_add_author";
            this.btn_add_author.Size = new System.Drawing.Size(45, 23);
            this.btn_add_author.TabIndex = 25;
            this.btn_add_author.Text = "add";
            this.btn_add_author.UseVisualStyleBackColor = true;
            this.btn_add_author.Click += new System.EventHandler(this.btn_add_author_Click);
            // 
            // btn_delete_author
            // 
            this.btn_delete_author.Location = new System.Drawing.Point(391, 56);
            this.btn_delete_author.Name = "btn_delete_author";
            this.btn_delete_author.Size = new System.Drawing.Size(45, 23);
            this.btn_delete_author.TabIndex = 26;
            this.btn_delete_author.Text = "delete";
            this.btn_delete_author.UseVisualStyleBackColor = true;
            this.btn_delete_author.Click += new System.EventHandler(this.btn_delete_author_Click);
            // 
            // txt_auth
            // 
            this.txt_auth.Location = new System.Drawing.Point(313, 33);
            this.txt_auth.Name = "txt_auth";
            this.txt_auth.Size = new System.Drawing.Size(123, 20);
            this.txt_auth.TabIndex = 0;
            // 
            // txt_pdate
            // 
            this.txt_pdate.Location = new System.Drawing.Point(134, 167);
            this.txt_pdate.Name = "txt_pdate";
            this.txt_pdate.Size = new System.Drawing.Size(116, 20);
            this.txt_pdate.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Stock:";
            // 
            // txt_stock
            // 
            this.txt_stock.Location = new System.Drawing.Point(256, 33);
            this.txt_stock.Name = "txt_stock";
            this.txt_stock.Size = new System.Drawing.Size(51, 20);
            this.txt_stock.TabIndex = 8;
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 224);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_stock);
            this.Controls.Add(this.txt_auth);
            this.Controls.Add(this.btn_delete_author);
            this.Controls.Add(this.btn_add_author);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_title);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_lang);
            this.Controls.Add(this.txt_isbn10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.grid_artists);
            this.Controls.Add(this.txt_num_of_pages);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_pdate);
            this.Controls.Add(this.txt_rating);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_pub);
            this.Controls.Add(this.txt_isbn13);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            ((System.ComponentModel.ISupportInitialize)(this.grid_artists)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_isbn10;
        private System.Windows.Forms.DataGridView grid_artists;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_pub;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_isbn13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_rating;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_num_of_pages;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_lang;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add_author;
        private System.Windows.Forms.Button btn_delete_author;
        private System.Windows.Forms.TextBox txt_auth;
        private System.Windows.Forms.TextBox txt_pdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_stock;
    }
}