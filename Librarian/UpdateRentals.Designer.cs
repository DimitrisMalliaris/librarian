namespace Librarian
{
    partial class UpdateRentals
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
            this.txt_book = new System.Windows.Forms.TextBox();
            this.txt_member = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book title:";
            // 
            // txt_book
            // 
            this.txt_book.Location = new System.Drawing.Point(15, 66);
            this.txt_book.Name = "txt_book";
            this.txt_book.ReadOnly = true;
            this.txt_book.Size = new System.Drawing.Size(220, 20);
            this.txt_book.TabIndex = 1;
            // 
            // txt_member
            // 
            this.txt_member.Location = new System.Drawing.Point(15, 106);
            this.txt_member.Name = "txt_member";
            this.txt_member.ReadOnly = true;
            this.txt_member.Size = new System.Drawing.Size(220, 20);
            this.txt_member.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member name:";
            // 
            // btn_Update
            // 
            this.btn_Update.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_Update.Location = new System.Drawing.Point(28, 132);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 4;
            this.btn_Update.Text = "UPDATE";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(119, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "CANCEL";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txt_date
            // 
            this.txt_date.Location = new System.Drawing.Point(15, 26);
            this.txt_date.Name = "txt_date";
            this.txt_date.Size = new System.Drawing.Size(100, 20);
            this.txt_date.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // UpdateRentals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 167);
            this.ControlBox = false;
            this.Controls.Add(this.txt_date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.txt_member);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_book);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateRentals";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateRentals";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_book;
        private System.Windows.Forms.TextBox txt_member;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_date;
        private System.Windows.Forms.Label label3;
    }
}