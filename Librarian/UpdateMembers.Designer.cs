namespace Librarian
{
    partial class UpdateMembers
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
            this.txt_userid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_gender = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_bday = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_saddress = new System.Windows.Forms.TextBox();
            this.btn_update_save = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_userid
            // 
            this.txt_userid.Enabled = false;
            this.txt_userid.Location = new System.Drawing.Point(11, 25);
            this.txt_userid.Name = "txt_userid";
            this.txt_userid.Size = new System.Drawing.Size(100, 20);
            this.txt_userid.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "User ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "First name:";
            // 
            // txt_fname
            // 
            this.txt_fname.Location = new System.Drawing.Point(11, 68);
            this.txt_fname.Name = "txt_fname";
            this.txt_fname.Size = new System.Drawing.Size(100, 20);
            this.txt_fname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Last name:";
            // 
            // txt_lname
            // 
            this.txt_lname.Location = new System.Drawing.Point(11, 116);
            this.txt_lname.Name = "txt_lname";
            this.txt_lname.Size = new System.Drawing.Size(100, 20);
            this.txt_lname.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Email:";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(126, 25);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Gender:";
            // 
            // txt_gender
            // 
            this.txt_gender.Location = new System.Drawing.Point(126, 68);
            this.txt_gender.Name = "txt_gender";
            this.txt_gender.Size = new System.Drawing.Size(100, 20);
            this.txt_gender.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(127, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Birth Date:";
            // 
            // txt_bday
            // 
            this.txt_bday.Location = new System.Drawing.Point(126, 116);
            this.txt_bday.Name = "txt_bday";
            this.txt_bday.Size = new System.Drawing.Size(100, 20);
            this.txt_bday.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Street Address";
            // 
            // txt_saddress
            // 
            this.txt_saddress.Location = new System.Drawing.Point(242, 25);
            this.txt_saddress.Name = "txt_saddress";
            this.txt_saddress.Size = new System.Drawing.Size(100, 20);
            this.txt_saddress.TabIndex = 6;
            // 
            // btn_update_save
            // 
            this.btn_update_save.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_update_save.Location = new System.Drawing.Point(49, 154);
            this.btn_update_save.Name = "btn_update_save";
            this.btn_update_save.Size = new System.Drawing.Size(75, 23);
            this.btn_update_save.TabIndex = 14;
            this.btn_update_save.Text = "UPDATE";
            this.btn_update_save.UseVisualStyleBackColor = true;
            this.btn_update_save.Click += new System.EventHandler(this.btn_update_save_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(220, 154);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 15;
            this.btn_cancel.Text = "CANCEL";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // UpdateMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 192);
            this.ControlBox = false;
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_update_save);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_saddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_bday);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_gender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_userid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateMembers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_userid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_lname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_gender;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_bday;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_saddress;
        private System.Windows.Forms.Button btn_update_save;
        private System.Windows.Forms.Button btn_cancel;
    }
}