namespace Aplikacija
{
    partial class Register
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
            this.headerLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.mobitelLabel = new System.Windows.Forms.Label();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.confirmPasswordText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.prezimeText = new System.Windows.Forms.TextBox();
            this.imeText = new System.Windows.Forms.TextBox();
            this.prezimeLabel = new System.Windows.Forms.Label();
            this.imeLabel = new System.Windows.Forms.Label();
            this.mobitelText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.headerLabel.Location = new System.Drawing.Point(12, 9);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(230, 37);
            this.headerLabel.TabIndex = 0;
            this.headerLabel.Text = "Registrirajte račun";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(63, 73);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(146, 30);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Korisničko ime";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(62, 222);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(83, 30);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Lozinka";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Location = new System.Drawing.Point(63, 293);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(159, 30);
            this.confirmPasswordLabel.TabIndex = 3;
            this.confirmPasswordLabel.Text = "Provjera lozinke";
            // 
            // mobitelLabel
            // 
            this.mobitelLabel.AutoSize = true;
            this.mobitelLabel.Location = new System.Drawing.Point(338, 73);
            this.mobitelLabel.Name = "mobitelLabel";
            this.mobitelLabel.Size = new System.Drawing.Size(84, 30);
            this.mobitelLabel.TabIndex = 4;
            this.mobitelLabel.Text = "Mobitel";
            // 
            // usernameText
            // 
            this.usernameText.Location = new System.Drawing.Point(69, 106);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(239, 35);
            this.usernameText.TabIndex = 0;
            // 
            // passwordText
            // 
            this.passwordText.Location = new System.Drawing.Point(67, 255);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '*';
            this.passwordText.Size = new System.Drawing.Size(240, 35);
            this.passwordText.TabIndex = 2;
            // 
            // confirmPasswordText
            // 
            this.confirmPasswordText.Location = new System.Drawing.Point(68, 326);
            this.confirmPasswordText.Name = "confirmPasswordText";
            this.confirmPasswordText.PasswordChar = '*';
            this.confirmPasswordText.Size = new System.Drawing.Size(239, 35);
            this.confirmPasswordText.TabIndex = 3;
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(68, 181);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(239, 35);
            this.emailText.TabIndex = 1;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(237, 388);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(164, 57);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Registrirajte se";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // prezimeText
            // 
            this.prezimeText.Location = new System.Drawing.Point(340, 255);
            this.prezimeText.Name = "prezimeText";
            this.prezimeText.Size = new System.Drawing.Size(240, 35);
            this.prezimeText.TabIndex = 6;
            // 
            // imeText
            // 
            this.imeText.Location = new System.Drawing.Point(341, 181);
            this.imeText.Name = "imeText";
            this.imeText.Size = new System.Drawing.Size(239, 35);
            this.imeText.TabIndex = 5;
            // 
            // prezimeLabel
            // 
            this.prezimeLabel.AutoSize = true;
            this.prezimeLabel.Location = new System.Drawing.Point(338, 222);
            this.prezimeLabel.Name = "prezimeLabel";
            this.prezimeLabel.Size = new System.Drawing.Size(87, 30);
            this.prezimeLabel.TabIndex = 11;
            this.prezimeLabel.Text = "Prezime";
            // 
            // imeLabel
            // 
            this.imeLabel.AutoSize = true;
            this.imeLabel.Location = new System.Drawing.Point(335, 148);
            this.imeLabel.Name = "imeLabel";
            this.imeLabel.Size = new System.Drawing.Size(48, 30);
            this.imeLabel.TabIndex = 10;
            this.imeLabel.Text = "Ime";
            // 
            // mobitelText
            // 
            this.mobitelText.Location = new System.Drawing.Point(341, 106);
            this.mobitelText.Name = "mobitelText";
            this.mobitelText.Size = new System.Drawing.Size(239, 35);
            this.mobitelText.TabIndex = 4;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(64, 148);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(63, 30);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "Email";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 457);
            this.Controls.Add(this.mobitelText);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.prezimeText);
            this.Controls.Add(this.imeText);
            this.Controls.Add(this.prezimeLabel);
            this.Controls.Add(this.imeLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.confirmPasswordText);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.mobitelLabel);
            this.Controls.Add(this.confirmPasswordLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label mobitelLabel;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox confirmPasswordText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox prezimeText;
        private System.Windows.Forms.TextBox imeText;
        private System.Windows.Forms.Label prezimeLabel;
        private System.Windows.Forms.Label imeLabel;
        private System.Windows.Forms.TextBox mobitelText;
        private System.Windows.Forms.Label emailLabel;
    }
}