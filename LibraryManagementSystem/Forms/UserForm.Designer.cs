namespace LibraryManagementSystem.UI.Forms
{
    partial class UserForm
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
            grpBoxBooks = new GroupBox();
            SuspendLayout();
            // 
            // grpBoxBooks
            // 
            grpBoxBooks.Location = new Point(12, 12);
            grpBoxBooks.Name = "grpBoxBooks";
            grpBoxBooks.Size = new Size(641, 526);
            grpBoxBooks.TabIndex = 0;
            grpBoxBooks.TabStop = false;
            grpBoxBooks.Text = "Kitaplar";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GrayText;
            ClientSize = new Size(1013, 550);
            Controls.Add(grpBoxBooks);
            Font = new Font("Segoe UI", 11F);
            Margin = new Padding(4);
            Name = "UserForm";
            Text = "UserForm";
            Load += UserForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpBoxBooks;
    }
}