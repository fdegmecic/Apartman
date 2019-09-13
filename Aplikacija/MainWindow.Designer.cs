namespace Aplikacija
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.sidePannel = new System.Windows.Forms.Panel();
            this.welcomeLabel2 = new System.Windows.Forms.Label();
            this.buttonPannel = new System.Windows.Forms.Panel();
            this.dodajButton = new System.Windows.Forms.Button();
            this.pretragaButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.firstUserControl = new Aplikacija.FirstUserControl();
            this.thirdUserControl = new Aplikacija.ThirdUserControl();
            this.sidePannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sidePannel
            // 
            this.sidePannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.sidePannel.Controls.Add(this.welcomeLabel2);
            this.sidePannel.Controls.Add(this.buttonPannel);
            this.sidePannel.Controls.Add(this.dodajButton);
            this.sidePannel.Controls.Add(this.pretragaButton);
            this.sidePannel.Controls.Add(this.homeButton);
            this.sidePannel.Controls.Add(this.welcomeLabel);
            this.sidePannel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePannel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sidePannel.Location = new System.Drawing.Point(0, 0);
            this.sidePannel.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.sidePannel.Name = "sidePannel";
            this.sidePannel.Size = new System.Drawing.Size(183, 640);
            this.sidePannel.TabIndex = 0;
            // 
            // welcomeLabel2
            // 
            this.welcomeLabel2.AutoSize = true;
            this.welcomeLabel2.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel2.Location = new System.Drawing.Point(3, 51);
            this.welcomeLabel2.Name = "welcomeLabel2";
            this.welcomeLabel2.Size = new System.Drawing.Size(41, 30);
            this.welcomeLabel2.TabIndex = 4;
            this.welcomeLabel2.Text = "<>";
            // 
            // buttonPannel
            // 
            this.buttonPannel.BackColor = System.Drawing.Color.DodgerBlue;
            this.buttonPannel.Location = new System.Drawing.Point(0, 181);
            this.buttonPannel.Name = "buttonPannel";
            this.buttonPannel.Size = new System.Drawing.Size(12, 56);
            this.buttonPannel.TabIndex = 1;
            // 
            // dodajButton
            // 
            this.dodajButton.FlatAppearance.BorderSize = 0;
            this.dodajButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodajButton.ForeColor = System.Drawing.Color.White;
            this.dodajButton.Image = ((System.Drawing.Image)(resources.GetObject("dodajButton.Image")));
            this.dodajButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dodajButton.Location = new System.Drawing.Point(11, 305);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(172, 56);
            this.dodajButton.TabIndex = 3;
            this.dodajButton.Text = "Obriši stan";
            this.dodajButton.UseVisualStyleBackColor = true;
            this.dodajButton.Click += new System.EventHandler(this.dodajButton_Click);
            // 
            // pretragaButton
            // 
            this.pretragaButton.FlatAppearance.BorderSize = 0;
            this.pretragaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pretragaButton.ForeColor = System.Drawing.Color.White;
            this.pretragaButton.Image = ((System.Drawing.Image)(resources.GetObject("pretragaButton.Image")));
            this.pretragaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pretragaButton.Location = new System.Drawing.Point(12, 243);
            this.pretragaButton.Name = "pretragaButton";
            this.pretragaButton.Size = new System.Drawing.Size(171, 56);
            this.pretragaButton.TabIndex = 2;
            this.pretragaButton.Text = "Pretraga";
            this.pretragaButton.UseVisualStyleBackColor = true;
            this.pretragaButton.Click += new System.EventHandler(this.pretragaButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.FlatAppearance.BorderSize = 0;
            this.homeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeButton.ForeColor = System.Drawing.Color.White;
            this.homeButton.Image = ((System.Drawing.Image)(resources.GetObject("homeButton.Image")));
            this.homeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.homeButton.Location = new System.Drawing.Point(12, 181);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(171, 56);
            this.homeButton.TabIndex = 1;
            this.homeButton.Text = "Home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(3, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(41, 30);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "<>";
            // 
            // firstUserControl
            // 
            this.firstUserControl.BackColor = System.Drawing.Color.White;
            this.firstUserControl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.firstUserControl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.firstUserControl.Location = new System.Drawing.Point(182, 0);
            this.firstUserControl.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.firstUserControl.Name = "firstUserControl";
            this.firstUserControl.Size = new System.Drawing.Size(1138, 640);
            this.firstUserControl.TabIndex = 1;
            // 
            // thirdUserControl
            // 
            this.thirdUserControl.BackColor = System.Drawing.Color.White;
            this.thirdUserControl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.thirdUserControl.ForeColor = System.Drawing.Color.DodgerBlue;
            this.thirdUserControl.Location = new System.Drawing.Point(182, 0);
            this.thirdUserControl.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.thirdUserControl.Name = "thirdUserControl";
            this.thirdUserControl.Size = new System.Drawing.Size(1138, 640);
            this.thirdUserControl.TabIndex = 2;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1312, 640);
            this.Controls.Add(this.thirdUserControl);
            this.Controls.Add(this.firstUserControl);
            this.Controls.Add(this.sidePannel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.sidePannel.ResumeLayout(false);
            this.sidePannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePannel;
        private System.Windows.Forms.Panel buttonPannel;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button pretragaButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.Label welcomeLabel;
        
        
        
        private FirstUserControl firstUserControl;
        private ThirdUserControl thirdUserControl;
        private System.Windows.Forms.Label welcomeLabel2;
    }
}