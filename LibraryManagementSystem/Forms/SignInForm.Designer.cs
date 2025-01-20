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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
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
            // textBox1
            // 
            textBox1.Location = new Point(314, 77);
            textBox1.Margin = new Padding(4, 4, 4, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(155, 32);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(314, 146);
            textBox2.Margin = new Padding(4, 4, 4, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(155, 32);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(314, 209);
            textBox3.Margin = new Padding(4, 4, 4, 4);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(155, 32);
            textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(314, 274);
            textBox4.Margin = new Padding(4, 4, 4, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(155, 32);
            textBox4.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(314, 331);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 39);
            btnSave.TabIndex = 2;
            btnSave.Text = "Kayıt Ol";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(703, 495);
            Controls.Add(btnSave);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblSoyad);
            Controls.Add(lblName);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4, 4, 4, 4);
            Name = "SignInForm";
            Text = "SignInForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSoyad;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button btnSave;
    }
}