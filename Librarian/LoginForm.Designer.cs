namespace Librarian
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.logo = new System.Windows.Forms.PictureBox();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.txt_dbname = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.login.SuspendLayout();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.Image = ((System.Drawing.Image)(resources.GetObject("logo.Image")));
            this.logo.Location = new System.Drawing.Point(135, 12);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(300, 227);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(3, 21);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.Size = new System.Drawing.Size(231, 20);
            this.txt_ip.TabIndex = 1;
            this.txt_ip.Text = "127.0.0.1";
            // 
            // txt_port
            // 
            this.txt_port.Location = new System.Drawing.Point(3, 60);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(231, 20);
            this.txt_port.TabIndex = 1;
            this.txt_port.Text = "5432";
            // 
            // txt_dbname
            // 
            this.txt_dbname.Location = new System.Drawing.Point(3, 99);
            this.txt_dbname.Name = "txt_dbname";
            this.txt_dbname.Size = new System.Drawing.Size(231, 20);
            this.txt_dbname.TabIndex = 1;
            this.txt_dbname.Text = "Library";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(3, 159);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(231, 20);
            this.txt_id.TabIndex = 1;
            this.txt_id.Text = "postgres";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(3, 198);
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '*';
            this.txt_password.Size = new System.Drawing.Size(231, 20);
            this.txt_password.TabIndex = 2;
            this.txt_password.Text = "1994";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Port:";
            // 
            // login
            // 
            this.login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.login.Controls.Add(this.label5);
            this.login.Controls.Add(this.txt_ip);
            this.login.Controls.Add(this.txt_id);
            this.login.Controls.Add(this.label2);
            this.login.Controls.Add(this.txt_password);
            this.login.Controls.Add(this.label4);
            this.login.Controls.Add(this.label3);
            this.login.Controls.Add(this.txt_dbname);
            this.login.Controls.Add(this.label1);
            this.login.Controls.Add(this.txt_port);
            this.login.Location = new System.Drawing.Point(165, 245);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(241, 240);
            this.login.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Database IP:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "User ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Database name:";
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(169, 502);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(89, 26);
            this.btn_login.TabIndex = 5;
            this.btn_login.Text = "Log In";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(311, 502);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(89, 26);
            this.btn_exit.TabIndex = 6;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_about
            // 
            this.btn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_about.Image = ((System.Drawing.Image)(resources.GetObject("btn_about.Image")));
            this.btn_about.Location = new System.Drawing.Point(535, 495);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(33, 33);
            this.btn_about.TabIndex = 7;
            this.btn_about.UseVisualStyleBackColor = true;
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(580, 540);
            this.ControlBox = false;
            this.Controls.Add(this.btn_about);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.login);
            this.Controls.Add(this.logo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.TextBox txt_dbname;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.MaskedTextBox txt_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel login;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_about;
    }
}

