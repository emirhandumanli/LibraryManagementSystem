namespace LibraryManagementSystem.UI.Forms
{
    partial class SignInForm
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
            lblName = new Label();
            lblSoyad = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.Location = new Point(174, 77);
            lblName.Margin = new Padding(4, 0, 4, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(85, 24);
            lblName.TabIndex = 0;
            lblName.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.Location = new Point(174, 146);
            lblSoyad.Margin = new Padding(4, 0, 4, 0);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(85, 25);
            lblSoyad.TabIndex = 0;
            lblSoyad.Text = "Soyad";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(174, 209);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(85, 25);
            lblEmail.TabIndex = 0;
            lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            lblPassword.Location = new Point(174, 277);
            lblPassword.Margin = new Padding(4, 0, 4, 0);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(85, 25);
            lblPassword.TabIndex = 0;
            lblPassword.Text = "Şifre";
            // 
            // txtName
            // 
            txtName.Location = new Point(314, 77);
            txtName.Margin = new Padding(4);
            txtName.Name = "txtName";
            txtName.Size = new Size(155, 32);
            txtName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(314, 146);
            txtLastName.Margin = new Padding(4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(155, 32);
            txtLastName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(314, 209);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(155, 32);
            txtEmail.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(314, 274);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(155, 32);
            txtPassword.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(314, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 39);
            btnSave.TabIndex = 2;
            btnSave.Text = "Kayıt Ol";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(703, 495);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblSoyad);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "SignInForm";
            Text = "SignInForm";
            Load += SignInForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSoyad;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnSave;
    }
}