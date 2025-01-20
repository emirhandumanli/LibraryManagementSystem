namespace LibraryManagementSystem.UI.Forms
{
    partial class LogInForm
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
            txtEmail = new TextBox();
            lblEmail = new Label();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRegister = new LinkLabel();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F);
            txtEmail.Location = new Point(322, 140);
            txtEmail.Margin = new Padding(4, 4, 4, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(263, 32);
            txtEmail.TabIndex = 0;
            txtEmail.Text = "Email";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(322, 100);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(264, 31);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(322, 195);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(50, 25);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Şifre";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 11F);
            txtPassword.Location = new Point(322, 240);
            txtPassword.Margin = new Padding(4, 4, 4, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(263, 32);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "Şifre";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.LinkColor = Color.Yellow;
            lblRegister.Location = new Point(322, 392);
            lblRegister.Margin = new Padding(4, 0, 4, 0);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(239, 25);
            lblRegister.TabIndex = 4;
            lblRegister.TabStop = true;
            lblRegister.Text = "Hesabınız yok mu? Kayıt Ol";
            lblRegister.LinkClicked += lblRegister_LinkClicked;
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(322, 314);
            btnLogIn.Margin = new Padding(4, 4, 4, 4);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(264, 58);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Giriş Yap";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // LogInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(917, 511);
            Controls.Add(btnLogIn);
            Controls.Add(lblRegister);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(txtEmail);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "LogInForm";
            Text = "Log in";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEmail;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtPassword;
        private LinkLabel lblRegister;
        private Button btnLogIn;
    }
}